using DAO.Model;
using DAO.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;
using BUS.Define;

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

        public void DeleteByID(int id)
        {
            ghiChuNhanhRepository.Delete(id);
            ghiChuNhanhRepository.Commit();
        }
        
        public IEnumerable<GhiChuNhanh> GetGhiChuByNguoiDung(NguoiDung nd)
        {
            return ghiChuNhanhRepository.GetMulti(x => x.Email == nd.email).ToList().OrderByDescending(x => x.ThoiGianBD);
        }

        public GhiChuNhanh GetGhiChuByID(int id)
        {
            return ghiChuNhanhRepository.GetSingleById(id);
        }       
        
        public IEnumerable<GhiChuNhanh> GetGhiChuNhanhByTen(string keyword, NguoiDung nd, bool searhDate)
        {
            IEnumerable<GhiChuNhanh> query = GetGhiChuByNguoiDung(nd);
            if (searhDate)
                return query.Where(f => f.TieuDe.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0 || f.ThoiGianBD.ToShortDateString().IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);
            else
                return query.Where(f => f.TieuDe.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);
        }  


        public List<GhiChuNhanh> SortGhiChu(List<GhiChuNhanh> gcs, sort sortGC)
        {
            switch (sortGC)
            {
                case sort.TangTheoTen:
                    gcs = gcs.OrderBy(x => x.TieuDe).ToList();
                    break;
                case sort.GiamTheoTen:
                    gcs = gcs.OrderByDescending(x => x.TieuDe).ToList();
                    break;
                case sort.TangTheoTG:
                    gcs = gcs.OrderBy(x => x.ThoiGianBD).ToList();
                    break;
                case sort.GiamTheoTG:
                    gcs = gcs.OrderByDescending(x => x.ThoiGianBD).ToList();
                    break;
            }

            return gcs;
        }
    }
}
