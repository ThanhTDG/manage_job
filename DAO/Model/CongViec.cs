using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class CongViec
    {
        [Key]
        public int iD { get; set; }
        public string ten { get; set; }
        public DateTime thoiGianBD { get; set; }
        public DateTime thoiGianKT { get; set; }
        public int trangThai { get; set; }
        public int tienDo { get; set; }
        public int mucDo { get; set; }
        public int IDChuDe { get; set; }

        [ForeignKey("IDChuDe")]
        public virtual ChuDe ChuDe { get; set; }

      
        public CongViec(int iD, string ten, DateTime thoiGianBD, DateTime thoiGianKT, int trangThai, int tienDo, int mucDo, int iDChuDe, string email, ChuDe chuDe)
        {
            this.iD = iD;
            this.ten = ten;
            this.thoiGianBD = thoiGianBD;
            this.thoiGianKT = thoiGianKT;
            this.trangThai = trangThai;
            this.tienDo = tienDo;
            this.mucDo = mucDo;
            IDChuDe = iDChuDe;
            ChuDe = chuDe;
        }

        public CongViec()
        {
        }
    }
}
