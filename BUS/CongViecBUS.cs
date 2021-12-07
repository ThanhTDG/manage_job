using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;

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

        public void Delete(CongViec congViec)
        {
            congViecRepository.Delete(congViec);
            congViecRepository.Commit();
        }
       
    }
}
