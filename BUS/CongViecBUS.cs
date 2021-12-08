using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;

namespace BUS
{
    public class CongViecBUS
    {
        CongViecRepository congViecRepository;
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
            congViecRepository.Delete(congViec);
            congViecRepository.Commit();
        }

        public void GetCongViec(ref TreeView treeView, IEnumerable<CongViec> dsCongViec)
        {
            ChiTietCVBUS chiTietCVBus = new ChiTietCVBUS();
            var str = "";
            treeView.Nodes.Clear();
            foreach (var temp in dsCongViec)
            {
                str = string.Format("{0}           ({1} - {2})         {3}%", temp.ten, temp.thoiGianBD.ToShortDateString(), temp.thoiGianKT.ToShortDateString(), temp.tienDo);          
                var node = treeView.Nodes.Add(str);
                node.Tag = temp;

                foreach (var ctcv in chiTietCVBus.GetChiTietByCongViec(temp))
                {
                    str = string.Format("{0}", ctcv.ten);
                    var childNode = node.Nodes.Add(str);
                    childNode.Tag = ctcv;
                }
            }
            treeView.ExpandAll();
        }

        public IEnumerable<CongViec> GetCongViecByChuDe(ChuDe chuDe)
        {
            return congViecRepository.GetMulti(x => x.IDChuDe == chuDe.iD);
        }

        public IEnumerable<CongViec> GetCongViecByNguoiDung(NguoiDung nd)
        {
            return congViecRepository.GetCongViecByNguoiDung(nd.email);
        }
    }
}
