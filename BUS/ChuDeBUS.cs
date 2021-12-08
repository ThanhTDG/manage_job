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
        public void GetChuDe(ref TreeView treeView, NguoiDung nd)
        {
            treeView.Nodes.Clear();
<<<<<<< HEAD

=======
>>>>>>> ecb59dc936b03dbc2dd44b5c1f10d1ef6cd02a2d
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

        public ChuDe GetChuDeByID(int id)
        {
            return chuDeRepository.GetSingleById(id);
        }

        public IEnumerable<ChuDe> GetChuDeByNguoiDung(NguoiDung nd)
        {
            return chuDeRepository.GetMulti(x => x.Email == nd.email);
        }

        public ChuDe GetChuDeByID(int id)
        {
            return chuDeRepository.GetSingleById(id);
        }
    }
}
