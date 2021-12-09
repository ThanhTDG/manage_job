using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Drawing;

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
<<<<<<< HEAD
            congViecRepository = new CongViecRepository();
=======
            CongViecRepository congViecRepository = new CongViecRepository();
>>>>>>> 2577b88e552965a018ed6e759fb3904f3a18fd24
            congViec = congViecRepository.GetSingleById(congViec.iD);
            congViecRepository.Delete(congViec);
            congViecRepository.Commit();
        }

        public void GetCongViec(ref TreeView treeView, List<CongViec> dsCongViec)
        {
            chiTietCVBus = new ChiTietCVBUS();
            var str = "";
            treeView.Nodes.Clear();
            foreach (var temp in dsCongViec.OrderBy(x=>x.mucDo))
            {
                str = string.Format("{0}           ({1} - {2})         {3}%", temp.ten, temp.thoiGianBD.ToShortDateString(), temp.thoiGianKT.ToShortDateString(), temp.tienDo);

                var node = treeView.Nodes.Add(str);
                node.ForeColor = Color.FromArgb(255 - temp.mucDo * 51, 50, 0 + temp.mucDo*51);
                node.NodeFont = new Font("Times New Roman", 13, FontStyle.Regular); 
                node.Tag = temp;

                foreach (var ctcv in chiTietCVBus.GetChiTietByCongViec(temp).OrderBy(x => x.mucDo))
                {
                    str = string.Format("{0}", ctcv.ten);
                    var childNode = node.Nodes.Add(str);
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
            return cv.Where(x => x.thoiGianBD <= date && date <= x.thoiGianKT);
        }

        public IEnumerable<CongViec> GetCongViecByImportant(DateTime date, ChuDe chuDe, NguoiDung nd)
        {
            IEnumerable<CongViec> cv;
            if (chuDe == null || chuDe.iD == 0)
                cv = GetCongViecByNguoiDung(nd);
            else
                cv = GetCongViecByChuDe(chuDe);
            return cv.Where(x => (x.mucDo <= 2 && x.thoiGianBD <= date && date <= x.thoiGianKT));
        }
    }
}
