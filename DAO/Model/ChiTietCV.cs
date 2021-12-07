using DAO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class ChiTietCV
    {
        [Key]
        public int iD { get; set; }
        public int iDCongviec { get; set; } 
        public string ten { get; set; }
        public int trangThai { get; set; }
        public int? ThoiGianDukien { get; set; }
        public int? ThoiGianThucTe { get; set; }
        public int mucDo { get; set; }
        public int iDChiTietCV { get; set; }

        [ForeignKey("iDCongviec")]
        public virtual CongViec congViec { get; set; }
        


        public ChiTietCV()
        {

        }

        public ChiTietCV(int iD, int iDCongviec, string ten, int trangThai, int thoiGianDukien, int thoiGianThucTe, int mucDo, int iDChiTietCV, CongViec congViec)
        {
            this.iD = iD;
            this.iDCongviec = iDCongviec;
            this.ten = ten;
            this.trangThai = trangThai;
            ThoiGianDukien = thoiGianDukien;
            ThoiGianThucTe = thoiGianThucTe;
            this.mucDo = mucDo;
            this.iDChiTietCV = iDChiTietCV;
            this.congViec = congViec;
        }
    }
}
