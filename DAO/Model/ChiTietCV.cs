using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Modules
{
    public class ChiTietCV
    {
        [Key]
        public int iD { get; set; }
        public int iDCongviec { get; set; } 
        public string ten { get; set; }
        public int trangThai { get; set; }
        public DateTime ThoiGianDukien { get; set; }
        public DateTime ThoiGianThucTe { get; set; }
        public int mucDo { get; set; }
        public int iDChiTietCV { get; set; }

        [ForeignKey("iDCongviec")]
        public CongViec congViec { get; set; }
        [ForeignKey("iDChiTietCV")]
        public ChiTietCV chiTietCV {  get; set; }


        public ChiTietCV()
        {

        }

        public ChiTietCV(int iD, int iDCongviec, string ten, int trangThai, DateTime thoiGianDukien, DateTime thoiGianThucTe, int mucDo, int iDChiTietCV, CongViec congViec, ChiTietCV chiTietCV)
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
            this.chiTietCV = chiTietCV;
        }
    }
}
