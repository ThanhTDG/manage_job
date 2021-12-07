using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public void GetChuDe(ref TreeView treeView)
        {
            foreach (var temp in GetAll())
            {
                var node = treeView.Nodes.Add(temp.ten);
                node.Tag = temp;
            }
        }
    }
}
