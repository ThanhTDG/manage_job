using DAO.Infastructure;
using DAO.Model;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.SqlClient;

namespace DAO.Repositories
{
    public interface ICongViecRepository : IRepository<CongViec>
    {
        IEnumerable<CongViec> GetCongViecByNguoiDung(string email);
        IEnumerable<CongViec> GetCongViecByLoc(NguoiDung nd, List<int> _trangthai, List<int> _mucdo, List<DateTime> _time);
        IEnumerable<CongViec> GetCongViecByDayRound(DateTime BatDau, DateTime KetThuc, string email);
        IEnumerable<CongViec> GetCongViecByDayRound(DateTime date, string email, int chuDeID);
        IEnumerable<CongViec> GetCongViecByDayRound(DateTime date, string email);
        IEnumerable<CongViec> GetCongViecsComingSoon(DateTime now, string email);
        IEnumerable<CongViec> GetCongViecsAlmostOver(DateTime now, string email);
        IEnumerable<CongViec> GetCongViecByLoaiChuDe(int loaiChuDe, string email);

    }
    public class CongViecRepository : RepositoryBase<CongViec>, ICongViecRepository
    {
        #region Properties
        private ManageJobContext dataContext;
        private readonly IDbSet<CongViec> dbSet;


        protected ManageJobContext DbContext
        {
            get { return dataContext ?? (dataContext = new ManageJobContext()); }
        }
        #endregion

        public CongViecRepository()
        {
            dbSet = DbContext.Set<CongViec>();
        }

        public IEnumerable<CongViec> GetCongViecByNguoiDung(string email)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                        on s.IDChuDe equals r.iD
                        where r.Email == email
                        select s;
            return query;
        }
        public IEnumerable<CongViec> GetCongViecByLoc(NguoiDung nd, List<int> _trangthai, List<int> _mucdo, List<DateTime> _time)
        {
            int i = 0, j = 0;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            string Squery = ("Select C.id ,C.ten ,C.thoiGianBD, C.thoiGianKT, C.trangThai, C.tienDo, C.mucDo, C.IDChuDe, C.MoTa " +
                "from  NguoiDungs A , ChuDes B, CongViecs C  " +
                "where B.Email = @Email AND A.email = B.Email AND B.iD = C.IDChuDe ");
            SqlParameter sqlParameter = new SqlParameter("@Email", nd.email);
            sqlParameters.Add(sqlParameter);
            if(_trangthai ==null || _mucdo == null)


            if (_time.Count != 0 && _time!=null)
            {
                Squery = Squery + " AND c.ThoigianBD > @StartDay AND C.thoiGianKT < @EndDay ";
                sqlParameter = new SqlParameter("@StartDay", _time[0].ToShortDateString());
                sqlParameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@EndDay", _time[1].ToShortDateString());
                sqlParameters.Add(sqlParameter);
            }
            if (_mucdo.Count != 0 && _mucdo !=null)
            {
                foreach (var mucdo in _mucdo)
                {
                    if (j == 0)
                    {
                        Squery = Squery + " AND C.tienDo = @tienDo" + j;
                    }
                    else
                    {
                        Squery = Squery + " OR C.tienDo = @tienDo" + j;
                    }
                    sqlParameter = new SqlParameter("@tienDo" + j, mucdo);
                    sqlParameters.Add(sqlParameter);
                    j++;
                }
            }
            if (_trangthai.Count != 0 && _trangthai !=null)
            {
                foreach (var trangthai in _trangthai)
                {
                    if (i == 0)
                    {

                        Squery = Squery + " AND C.trangThai =" + i;
                    }
                    else
                    {
                        Squery = Squery + " OR C.trangThai =" + i;

                    }
                    sqlParameter = new SqlParameter("@trangthai" + i, trangthai);
                    sqlParameters.Add(sqlParameter);
                    i++;
                }
            }
            return dataContext.congViec.SqlQuery(Squery, sqlParameters.ToArray());
        }

        public IEnumerable<CongViec> GetCongViecByDayRound(DateTime BatDau, DateTime KetThuc, string email)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                        on s.IDChuDe equals r.iD
                        where r.Email == email && BatDau < s.thoiGianBD && s.thoiGianKT < KetThuc 
                        select s;
            return query;
        }

        public IEnumerable<CongViec> GetCongViecByDayRound(DateTime date, string email, int chuDeID)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                        on s.IDChuDe equals r.iD
                        where r.Email == email && s.thoiGianBD <= date && date <= s.thoiGianKT && s.IDChuDe == chuDeID
                        select s;
            return query;
        }

        public IEnumerable<CongViec> GetCongViecByDayRound(DateTime date, string email)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                        on s.IDChuDe equals r.iD
                        where r.Email == email && s.thoiGianBD <= date && date <= s.thoiGianKT
                        select s;
            return query;
        }

        public IEnumerable<CongViec> GetCongViecsComingSoon(DateTime now, string email)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                         on s.IDChuDe equals r.iD
                        where r.Email == email && s.thoiGianBD <= now && s.trangThai == 0
                        select s;
            return query;
        }
        public IEnumerable<CongViec> GetCongViecsAlmostOver(DateTime now, string email)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                         on s.IDChuDe equals r.iD
                        where r.Email == email && s.thoiGianKT >= now && s.trangThai == 1
                        select s;
            return query;
        }
        public IEnumerable<CongViec> GetCongViecByLoaiChuDe(int loaiChuDe, string email)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                        on s.IDChuDe equals r.iD
                        where r.Email == email && r.loaiChuDe == loaiChuDe
                        select s;
            return query;
        }
    }
}
