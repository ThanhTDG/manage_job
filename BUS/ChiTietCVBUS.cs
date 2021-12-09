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

            int total = GetChiTietByCongViec(cv).ToList().Count;
            int complete = GetChiTietByCongViec(cv).Where(x => x.trangThai == 1).Count();
            return total == 0 ? 0 : (complete / total) * 100;
        }
    }
}
