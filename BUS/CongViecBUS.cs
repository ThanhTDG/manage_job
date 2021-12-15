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
            foreach (var temp in dsCongViec.OrderBy(x => x.mucDo))
            {
                str = string.Format("{0}           ({1} - {2})         {3}%", temp.ten, temp.thoiGianBD.ToShortDateString(), temp.thoiGianKT.ToShortDateString(), temp.tienDo);
                var node = treeView.Nodes.Add(str);
                node.ForeColor = Color.FromArgb(255 - temp.mucDo * 51, 50, 0 + temp.mucDo * 51);
                node.Tag = temp;
                node.Checked = false;
                if (temp.trangThai == 1) { node.Checked = true; }
                foreach (var ctcv in chiTietCVBus.GetChiTietByCongViec(temp).OrderBy(x => x.mucDo))
                {
                    str = string.Format("{0}", ctcv.ten);
                    var childNode = node.Nodes.Add(str);
                    childNode.Checked = false;
                    if (ctcv.trangThai == 1)
                    {
                        childNode.Checked = true;
                        childNode.ForeColor = Color.Green;
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

        public IEnumerable<CongViec> GetByLoc(NguoiDung nd)
        {
            return congViecRepository.GetCongViecByLoc(nd, DataCheck.Instance.trangthai, DataCheck.Instance.mucdo, DataCheck.Instance.time);
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
        public List<CongViec> GetCongViecsAlmostOver(string email)
        {
            return (congViecRepository.GetCongViecsAlmostOver(DateTime.Now, email)).OrderBy(x => x.thoiGianKT).ToList();
        }
        public List<CongViec> GetCongViecsCommingSoon(string email)
        {
            return (congViecRepository.GetCongViecsComingSoon(DateTime.Now, email)).OrderBy(x => x.thoiGianBD).ToList();
        }

    }
}
