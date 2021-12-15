using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Drawing;
using System.Data.SqlClient;


namespace BUS
{
    public class CongViecBUS
    {
        CongViecRepository congViecRepository;
        public ChiTietCVBUS chiTietCVBus;

        public CongViecBUS()
        {
            congViecRepository = new CongViecRepository();
        }

        public IEnumerable<CongViec> GetAll()
        {
            return congViecRepository.GetAll();
        }

        public int Insert(CongViec _CongViec)
        {
            _CongViec = congViecRepository.Add(_CongViec);
            congViecRepository.Commit();
            return _CongViec.iD;
        }

        public void Update(CongViec congViec)
        {
            congViecRepository.Update(congViec);
            congViecRepository.Commit();
        }

        public CongViec GetCongViecByID(int id)
        {
            return congViecRepository.GetSingleById(id);
        }

        public void Delete(CongViec congViec)
        {
            CongViecRepository congViecRepository = new CongViecRepository();
            congViec = congViecRepository.GetSingleById(congViec.iD);
            congViecRepository.Delete(congViec);
            congViecRepository.Commit();
        }

        public void GetCongViec(ref TreeView treeView, List<CongViec> dsCongViec)
        {
            chiTietCVBus = new ChiTietCVBUS();
            var str = "";
            treeView.Nodes.Clear();
            treeView.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            foreach (var temp in dsCongViec)
            {
                str = string.Format("{0}           ({1} - {2})         {3}%", temp.ten, temp.thoiGianBD.ToShortDateString(), temp.thoiGianKT.ToShortDateString(), temp.tienDo);
                var node = treeView.Nodes.Add(str);
                node.ForeColor = ColorMN.ColorLevel(temp.mucDo);
                node.Tag = temp;
                node.Checked = false;
                if (temp.tienDo == 100) { node.Checked = true; }
                foreach (var ctcv in chiTietCVBus.GetChiTietByCongViec(temp).OrderBy(x => x.mucDo))
                {
                    str = string.Format("{0}", ctcv.ten);
                    var childNode = node.Nodes.Add(str);
                    childNode.Checked = false;
                    if (ctcv.trangThai == 1)
                    {
                        childNode.Checked = true;
                        childNode.ForeColor = ColorMN.ColorLevel(5);
                    }
                    childNode.NodeFont = new Font("Times New Roman", 10, FontStyle.Regular);
                    childNode.Tag = ctcv;
                }
            }
            treeView.ExpandAll();
        }

        public List<CongViec> GetCongViecByChuDe(ChuDe chuDe)
        {
            return congViecRepository.GetMulti(x => x.IDChuDe == chuDe.iD).ToList();
        }

        public IEnumerable<CongViec> GetCongViecByNguoiDung(NguoiDung nd)
        {
            return congViecRepository.GetCongViecByNguoiDung(nd.email);
        }

        public IEnumerable<CongViec> GetByLoc(NguoiDung nd )
        {
          /*  int i = 0, j = 0;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            string Squery = ("Select * from  NguoiDungs A , ChuDes B, CongViecs C  where B.Email = @Email AND A.email = B.Email AND B.iD = C.IDChuDe ");
            SqlParameter sqlParameter = new SqlParameter("@Email", nd.email);
            sqlParameters.Add(sqlParameter);
            if (TinhTrang.Instance._time.Count != 0)
            {
                Squery = Squery + " AND C.thoiGianDB >= @StartDay AND C.thoiGianKT <= @EndDay ";
                sqlParameter = new SqlParameter("@StartDay", TinhTrang.Instance._time[0].ToString("yyyy-MM-dd"));
                sqlParameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@EndDay", TinhTrang.Instance._time[1].ToString("yyyy-MM-dd"));
                sqlParameters.Add(sqlParameter);
            }
            if (TinhTrang.Instance._mucdo.Count != 0)
            {
                foreach (var mucdo in TinhTrang.Instance._mucdo)
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
            if (TinhTrang.Instance._trangthai.Count != 0)
            {
                foreach (var trangthai in TinhTrang.Instance._trangthai)
                {
                    if (i == 0)
                    {
                        
                        Squery = Squery + " AND C.trangThai ="+i;
                    }
                    else
                    {
                        Squery = Squery + " OR C.trangThai ="+i;
                      
                    }
                    sqlParameter = new SqlParameter("@trangthai" +i, trangthai);
                    sqlParameters.Add(sqlParameter);
                    i++;
                }
            }
      */
            return congViecRepository.GetCongViecByLoc(nd, TinhTrang.Instance._trangthai, TinhTrang.Instance._mucdo, TinhTrang.Instance._time);
    }

        public IEnumerable<CongViec> GetCongViecByTenCV(string keyword, ChuDe chuDe, NguoiDung nd)
        {
            IEnumerable<CongViec> query;
            IEnumerable<CongViec> cv = GetCongViecByNguoiDung(nd);

            if (chuDe == null || chuDe.iD == 0)
            {
                query = cv;
            }
            else
            {
                query = GetCongViecByChuDe(chuDe);
            }

            return query.Where(f => f.ten.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);          
        }

        public IEnumerable<CongViec> GetCongViecByDay(DateTime date, ChuDe chuDe, NguoiDung nd)
        {
            IEnumerable<CongViec> cv;
            if (chuDe == null || chuDe.iD == 0)
                cv = GetCongViecByNguoiDung(nd);                
            else
                cv = GetCongViecByChuDe(chuDe);
            return cv.Where(x => x.thoiGianBD.Date <= date.Date && date.Date <= x.thoiGianKT);
        }

        public IEnumerable<CongViec> GetCongViecByImportant(DateTime date, ChuDe chuDe, NguoiDung nd)
        {
            IEnumerable<CongViec> cv;
            if (chuDe == null || chuDe.iD == 0)
                cv = GetCongViecByNguoiDung(nd);
            else
                cv = GetCongViecByChuDe(chuDe);
            return cv.Where(x => (x.mucDo <= 2 && x.thoiGianBD.Date <= date.Date && date.Date <= x.thoiGianKT.Date));
        }

        public IEnumerable<CongViec> GetCongViecByLoaiChuDe(int loaiChuDe, NguoiDung nd)
        {
            return congViecRepository.GetCongViecByLoaiChuDe(loaiChuDe, nd.email);
        }

        public List<CongViec> SortCongViec(List<CongViec> cvs, sort sortCongViec)
        {
            switch (sortCongViec)
            {
                case sort.TangTheoTG:
                    cvs = cvs.OrderBy(x => x.thoiGianBD).ToList();
                    break;
                case sort.GiamTheoTG:
                    cvs = cvs.OrderByDescending(x => x.thoiGianBD).ToList();
                    break;
                case sort.TangTheoMucDo:
                    cvs = cvs.OrderByDescending(x => x.mucDo).ToList();
                    break;
                case sort.GiamTheoMucDo:
                    cvs = cvs.OrderBy(x => x.mucDo).ToList();
                    break;
            }
            return cvs;
        }

        public IEnumerable<CongViec> SortCongViecByMucDo(ChuDe chuDe, NguoiDung nd, bool cheDo)
        {
            IEnumerable<CongViec> cv = (chuDe.iD == 0) ? GetCongViecByNguoiDung(nd) : GetCongViecByChuDe(chuDe);
            if (cheDo)
                return cv.OrderByDescending(x => x.mucDo);
            else
                return cv.OrderBy(x => x.mucDo);
        }
    }
}
