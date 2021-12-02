using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class CongViecModel
    {
        public CongViecModel(int iD, string ten, DateTime thoiGianBD, DateTime thoiGianKT, string trangThai, int tienDo, int mucDo, string tenChuDe, string email)
        {
            this.iD = iD;
            this.ten = ten;
            this.thoiGianBD = thoiGianBD;
            this.thoiGianKT = thoiGianKT;
            this.trangThai = trangThai;
            this.tienDo = tienDo;
            this.mucDo = mucDo;
            TenChuDe = tenChuDe;
            Email = email;
        }

        public int iD { get; set; }
        public string ten { get; set; }
        public DateTime thoiGianBD { get; set; }
        public DateTime thoiGianKT { get; set; }
        public string trangThai { get; set; }
        public int tienDo { get; set; }
        public int mucDo { get; set; }
        public string TenChuDe { get; set; }
        public string Email { get; set; }
    }
}
