using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class Extension
    {
        public static NguoiDung LoadSetting(string email, string emailDefault = null)
        {
            NguoiDungBUS nguoidungBus = new NguoiDungBUS();
            NguoiDung _nd;
            if (email == emailDefault)
                _nd = nguoidungBus.GetNguoiDungByEmail(email);
            else
                _nd = nguoidungBus.GetNguoiDungByEmail(email);

            if (_nd == null)
            {
                _nd = new NguoiDung()
                {
                    email = email,
                    tenND = "default",
                };
                nguoidungBus.Insert(_nd);
            }
            return _nd;
        }
    }
}
