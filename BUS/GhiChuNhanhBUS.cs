using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;

namespace BUS
{
    public class GhiChuNhanhBUS
    {
        GhiChuNhanhRepository ghiChuNhanhRepository;
        public GhiChuNhanhBUS()
        {
            ghiChuNhanhRepository = new GhiChuNhanhRepository();
        }

        public IEnumerable<GhiChuNhanh> GetAll()
        {
            return ghiChuNhanhRepository.GetAll();
        }
        public int Insert(GhiChuNhanh ghiChuNhanh)
        {
            ghiChuNhanh = ghiChuNhanhRepository.Add(ghiChuNhanh);
            ghiChuNhanhRepository.Commit();
            return ghiChuNhanh.id;
        }
        public void Update(GhiChuNhanh ghiChuNhanh)
        {
            ghiChuNhanhRepository.Update(ghiChuNhanh);
            ghiChuNhanhRepository.Commit();
        }

        public void Delete(GhiChuNhanh ghiChuNhanh)
        {
            ghiChuNhanhRepository.Delete(ghiChuNhanh);
            ghiChuNhanhRepository.Commit();
        }
    }
}
