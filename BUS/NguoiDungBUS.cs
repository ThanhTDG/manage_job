using DAO.Model;
using DAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDungRepository nguoiDungRepository;
        public NguoiDungBUS()
        {
            nguoiDungRepository = new NguoiDungRepository();
        }

        public IEnumerable<NguoiDung> GetAll()
        {
            return nguoiDungRepository.GetAll();
        }
        public void Insert(NguoiDung nguoiDung)
        {
            nguoiDung = nguoiDungRepository.Add(nguoiDung);
            nguoiDungRepository.Commit();
        }
        public void Update(NguoiDung nguoiDung)
        {
            nguoiDungRepository.Update(nguoiDung);
            nguoiDungRepository.Commit();
        }

        public void Delete(NguoiDung nguoiDung)
        {
            nguoiDungRepository.Delete(nguoiDung);
            nguoiDungRepository.Commit();
        }

        public NguoiDung GetNguoiDungByEmail(string email)
        {
            return nguoiDungRepository.GetSingleById(email);
        }
    }
}

