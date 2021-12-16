using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Drawing;
using System.Data.SqlClient;
using BUS.Define;

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
            List<CongViec> temp = congViecRepository.GetCongViecByLoai(nd.email).ToList();            
            List<CongViec> temp1 = GetCongViecByLoai(1, nd).ToList().ToList();
            List<CongViec> temp2 = GetCongViecByLoai(2, nd).ToList().ToList();
            List<CongViec> temp3 = GetCongViecByLoai(3, nd).ToList().ToList();
            List<CongViec> temp4 = GetCongViecByLoai(4, nd).ToList().ToList();

            return temp.Concat(temp1).Concat(temp2).Concat(temp3).Concat(temp4);
        }

        public IEnumerable<CongViec> GetByLoc(NguoiDung nd)
        {
            return congViecRepository.GetCongViecByLoc(nd, DataCheck.Instance.trangthai, DataCheck.Instance.mucdo, DataCheck.Instance.time);
        }

        public IEnumerable<CongViec> GetCongViecByTenCV(string keyword, List<CongViec> cvs)
        {
            IEnumerable<CongViec> query = cvs;
            if (cvs != null)
            {
                return query.Where(f => f.ten.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);
            }
            return null;      
        }

        public IEnumerable<CongViec> GetCongViecByDay(DateTime date, NguoiDung nd)
        {
            IEnumerable<CongViec> cv;
                cv = GetCongViecByNguoiDung(nd);
            return cv.Where(x => x.thoiGianBD.Date <= date.Date && date.Date <= x.thoiGianKT.Date);
        }

        public IEnumerable<CongViec> GetCongViecByImportant(DateTime date, NguoiDung nd)
        {
            IEnumerable<CongViec> cv;
            cv = GetCongViecByNguoiDung(nd);
            return cv.Where(x => (x.mucDo <= 2 && x.thoiGianBD.Date <= date.Date && date.Date <= x.thoiGianKT.Date));
        }
        public List<CongViec> GetCongViecsAlmostOver(string email)
        {
            return (congViecRepository.GetCongViecsAlmostOver(DateTime.Now, email)).OrderBy(x => x.thoiGianKT).ToList();
        }
        public List<CongViec> GetCongViecsCommingSoon(string email)
        {
            return (congViecRepository.GetCongViecsComingSoon(DateTime.Now, email)).OrderBy(x => x.thoiGianBD).ToList();
        }

        public IEnumerable<CongViec> GetCongViecByLoai(int loaiChuDe, NguoiDung nd)
        {
            IEnumerable<CongViec> cvs = null;

            DateTime now = DateTime.Now;
            var firstDateWeek = now.StartOfWeek(DayOfWeek.Monday);
            var firstDateMonth = new DateTime(now.Year, now.Month, 1).Date;
            var lastDateMonth = firstDateMonth.AddMonths(1).AddDays(-1).Date.Add(new TimeSpan(23, 59, 59));
            var firstDateYear = new DateTime(now.Year, 1, 1).Date;
            var lastDateYear = new DateTime(now.Year, 12, 31).Date.Add(new TimeSpan(23, 59, 59));

            switch (loaiChuDe)
            {
                case 1:
                    cvs = congViecRepository.GetCongViecByLoai(loaiChuDe, nd.email, now.Date, now.Date.Add(new TimeSpan(23, 59, 59)));
                    break;
                case 2:
                    cvs = congViecRepository.GetCongViecByLoai(loaiChuDe, nd.email, firstDateWeek, firstDateWeek.AddDays(7).Date.Add(new TimeSpan(23, 59, 59))).ToList();
                    break;
                case 3:
                    cvs = congViecRepository.GetCongViecByLoai(loaiChuDe, nd.email, firstDateMonth, lastDateMonth).ToList();
                    break;
                case 4:
                    cvs = congViecRepository.GetCongViecByLoai(loaiChuDe, nd.email, firstDateYear, lastDateYear).ToList();
                    break;
            }
            return cvs;
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

        public void GetCongViecByTrangThai(ref List<CongViec> cvs, string trangThai)
        {           
            switch (trangThai)
            {
                case "Sắp diễn ra":
                    cvs = cvs.Where(x => x.trangThai == 0).ToList();
                    break;
                case "Đang thực hiện":
                    cvs = cvs.Where(x => x.trangThai == 1).ToList();
                    break;
                case "Đã hoàn thành":
                    cvs = cvs.Where(x => x.trangThai == 2).ToList();
                    break;
                case "Đã quá hạn":
                    cvs = cvs.Where(x => x.trangThai == 3).ToList();
                    break;
                case "Hoàn thành trễ":
                    cvs = cvs.Where(x => x.trangThai == 4).ToList();
                    break;
            }             
        }
    }
}
