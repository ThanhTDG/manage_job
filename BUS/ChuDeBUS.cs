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
        public int Insert(string tenChuDe)
        {
            ChuDe temp = new ChuDe();
            temp.ten = tenChuDe;
            ChuDe _chude = chuDeRepository.Add(temp);
            chuDeRepository.Commit();
            return _chude.iD;
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
