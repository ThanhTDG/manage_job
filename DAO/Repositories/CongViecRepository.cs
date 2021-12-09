using DAO.Infastructure;
using DAO.Model;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAO.Repositories
{
    public interface ICongViecRepository : IRepository<CongViec>
    {
        IEnumerable<CongViec> GetCongViecByNguoiDung(string email);
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
    }
}
