using DAO.Model;
using DAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Delete(int iD)
        {
            ChiTietCVRepository.Delete(iD);
            ChiTietCVRepository.Commit();
        }

        public ChiTietCV GetChiTietCongViecByID(int iD)
        {
            return ChiTietCVRepository.GetSingleById(iD);
        }

        public IEnumerable<ChiTietCV> GetChiTietByCongViec(CongViec cv)
        {
            return ChiTietCVRepository.GetMulti(x => x.iDCongviec == cv.iD);
        }

        public int Process(CongViec cv)
        {
<<<<<<< HEAD

            int total = GetChiTietByCongViec(cv).ToList().Count;
            int complete = GetChiTietByCongViec(cv).Where(x => x.trangThai == 1).Count();
            return total == 0 ? 0 : (complete / total) * 100;
=======
            double total = GetChiTietByCongViec(cv).ToList().Count;
            double complete = GetChiTietByCongViec(cv).Where(x => x.trangThai == 1).Count();
            return total == 0 ? 0 : Convert.ToInt32(complete * 100 / total);
>>>>>>> 1fb9e440669791b5c9df12dbe0d2fed1a202a4f2
        }
    }
}
