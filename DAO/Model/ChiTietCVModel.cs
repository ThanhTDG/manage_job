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
        public int? ThoiGianDukien { get; set; }
        public int? ThoiGianThucTe { get; set; }
        public int? thoiGianBatDau { get; set; }
        public int mucDo { get; set; }
        public int tienDo { get; set; }
        public string TenChiTiet { get; set; }
        public string moTa { get; set; }

        public ChiTietCVModel()
        {
        }
    }
}
