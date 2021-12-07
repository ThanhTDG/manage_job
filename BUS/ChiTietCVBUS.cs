using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;

namespace BUS
{
    public class ChiTietCVBUS
    {
        ChiTietCVRepository ChiTietCVRepository;
        public ChiTietCVBUS()
        {
            ChiTietCVRepository = new ChiTietCVRepository();
        }

        public IEnumerable<ChiTietCV> GetAll()
        {
            return ChiTietCVRepository.GetAll();
        }
        public int Insert(ChiTietCV chiTietCV)
        {
            chiTietCV = ChiTietCVRepository.Add(chiTietCV);
            ChiTietCVRepository.Commit();
            return chiTietCV.iD;
        }
        public void Update(ChiTietCV ChiTietCV)
        {
            ChiTietCVRepository.Update(ChiTietCV);
            ChiTietCVRepository.Commit();
        }

        public void Delete(ChiTietCV ChiTietCV)
        {
            ChiTietCVRepository.Delete(ChiTietCV);
            ChiTietCVRepository.Commit();
        }
     
    }
}
