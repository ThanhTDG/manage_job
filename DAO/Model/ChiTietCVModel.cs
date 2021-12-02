using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{

    public class ChiTietCVModel
    {


        public int iD { get; set; }
        public string TenCongViec { get; set; }
        public string ten { get; set; }
        public int trangThai { get; set; }
        public DateTime ThoiGianDukien { get; set; }
        public DateTime ThoiGianThucTe { get; set; }
        public int mucDo { get; set; }
        public int tienDo { get; set; }
        public string TenChiTiet { get; set; }

        public ChiTietCVModel(int iD, string tenCongViec, string ten, int trangThai, DateTime thoiGianDukien, DateTime thoiGianThucTe, int mucDo, int tienDo, string tenChiTiet)
        {
            this.iD = iD;
            TenCongViec = tenCongViec;
            this.ten = ten;
            this.trangThai = trangThai;
            ThoiGianDukien = thoiGianDukien;
            ThoiGianThucTe = thoiGianThucTe;
            this.mucDo = mucDo;
            this.tienDo = tienDo;
            TenChiTiet = tenChiTiet;
        }



    }
}
