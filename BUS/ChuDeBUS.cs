     using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace BUS
{

    public class ChuDeBUS
    {
        ChuDeRepository chuDeRepository;
        public ChuDeBUS() {
            chuDeRepository = new ChuDeRepository();
        }

        public IEnumerable<ChuDe> GetAll()
        {
            return chuDeRepository.GetAll();
        }
        public int Insert(ChuDe chuDe)
        {
            chuDe = chuDeRepository.Add(chuDe);
            chuDeRepository.Commit();
            return chuDe.iD;
        }
        public void Update(ChuDe ChuDe)
        {
            chuDeRepository.Update(ChuDe);
            chuDeRepository.Commit();
        }

        public void Delete(ChuDe ChuDe)
        {
            chuDeRepository.Delete(ChuDe);
            chuDeRepository.Commit();
        }

        public void Delete(int id)
        {
            chuDeRepository.Delete(id);
            chuDeRepository.Commit();
        }

        public void GetChuDe(ref TreeView treeView, NguoiDung nd)
        {
            treeView.Nodes.Clear();
            ChuDe chuDe = new ChuDe()
            {
                iD = 0,
                ten = "Tất cả",
                Email = nd.email
            };

            var node = treeView.Nodes.Add(chuDe.ten);            
            node.Tag = chuDe;

            foreach (var temp in GetChuDeByNguoiDung(nd))
            {
                node = treeView.Nodes.Add(temp.ten);
                node.Tag = temp;
            }           
        }

        public int GetIDByNameChuDe(string name)
        {
            var u = GetAll().ToList().Find(x => x.ten == name);
            if (u == null) return -1;
            return u.iD;
        }

        public ChuDe GetChuDeByID(int id)
        {
            return chuDeRepository.GetSingleById(id);
        }

        public IEnumerable<ChuDe> GetChuDeByNguoiDung(NguoiDung nd)
        {
            return chuDeRepository.GetMulti(x => x.Email == nd.email);
        }

        public IEnumerable<ChuDe> GetChuDeByCommon(NguoiDung nd)
        {
            return chuDeRepository.GetMulti(x => x.Email == nd.email && x.loaiChuDe == 0);
        }
    }
}
