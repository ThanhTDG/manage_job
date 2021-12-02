using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Modules
{
    public class CongViec
    {
        [Key]
        public int iD { get; set; }
        public string ten { get; set; }
        public DateTime thoiGianBD { get; set; }
        public DateTime thoiGianKT { get; set; }
        public string trangThai { get; set; }
        public int tienDo { get; set; }
        public int mucDo { get; set; }
        public int IDChuDe { get; set; }
        public string Email { get; set; }

        [ForeignKey("IDChuDe")]
        public ChuDe ChuDe { get; set; }
        [ForeignKey("Email")]
        public NguoiDung nguoiDung { get; set; }
      
        public CongViec(int iD, string ten, DateTime thoiGianBD, DateTime thoiGianKT, string trangThai, int tienDo, int mucDo, int iDChuDe, string email, ChuDe chuDe, NguoiDung nguoiDung)
        {
            this.iD = iD;
            this.ten = ten;
            this.thoiGianBD = thoiGianBD;
            this.thoiGianKT = thoiGianKT;
            this.trangThai = trangThai;
            this.tienDo = tienDo;
            this.mucDo = mucDo;
            IDChuDe = iDChuDe;
            Email = email;
            ChuDe = chuDe;
            this.nguoiDung = nguoiDung;
        }

    }
}
