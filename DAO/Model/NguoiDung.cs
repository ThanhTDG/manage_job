using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class NguoiDung
    {
        [Key]
        public string email { get; set; }
        public string banQuyen { get; set; }
        public string tenND { get; set; }

        public NguoiDung() { }

        public NguoiDung(string email, string banQuyen, string tenND)
        {
            this.email = email;
            this.banQuyen = banQuyen;
            this.tenND = tenND;
        }
    }
}
/*context.nguoiDung.AddOrUpdate(new Model.NguoiDung() { email = "thanh@gmail.com", tenND = "Thanh nè" });
context.nguoiDung.AddOrUpdate(new Model.NguoiDung() { email = "ly@gmail.com", tenND = "Lý lanh lợi" });
context.nguoiDung.AddOrUpdate(new Model.NguoiDung() { email = "long@gmail.com", tenND = "Rồng nhưng xoay" });
context.nguoiDung.AddOrUpdate(new Model.NguoiDung() { email = "khoa@gmail.com", tenND = "Mine C à mà thôi" });

context.chuDe.AddOrUpdate(x => x.iD, new Model.ChuDe() { ten = "Mặc định" });//1
context.chuDe.AddOrUpdate(x => x.iD, new Model.ChuDe() { ten = "Gia đình" });//2
context.chuDe.AddOrUpdate(x => x.iD, new Model.ChuDe() { ten = "Thể thao" });//3
context.chuDe.AddOrUpdate(x => x.iD, new Model.ChuDe() { ten = "E sờ pọt" });//4
context.chuDe.AddOrUpdate(x => x.iD, new Model.ChuDe() { ten = "Học tập" });//5
context.chuDe.AddOrUpdate(x => x.iD, new Model.ChuDe() { ten = "Cho nhiều lần 1" });//6
context.chuDe.AddOrUpdate(x => x.iD, new Model.ChuDe() { ten = "Cho nhiều lần 2" });//7

context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Mặc định 1", IDChuDe = 1, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "thanh@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Mặc định 2", IDChuDe = 1, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "thanh@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Cưới ai", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "ly@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Ăn cưới ", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "long@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Ăn cưới ai ", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "khoa@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Thể thao", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "long@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "làm tí mine", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "khoa@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Liên quân xíu", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "khoa@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "code đê", IDChuDe = 5, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "khoa@gmail.com" });
context.congViec.AddOrUpdate(x => x.iD, new Model.CongViec() { ten = "Học lập trình nà", IDChuDe = 5, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0, Email = "long@gmail.com" });

// chi tiet cong viec
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "Học ", iDCongviec = 1, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 0 });
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "Chơi ", iDCongviec = 1, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 4, iDChiTietCV = 1 });
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "chuẩn bị", iDCongviec = 2, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 1 });
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "Tiền", iDCongviec = 3, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 4 });
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "Cưới", iDCongviec = 3, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 3 });
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "100 kim cương ", iDCongviec = 7, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 1 });
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "1000 sắt ", iDCongviec = 7, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 2, iDChiTietCV = 7 });
context.chiTietCV.AddOrUpdate(x => x.iD, new Model.ChiTietCV() { ten = "Thách đâu thoaiii", iDCongviec = 8, trangThai = 0, ThoiGianDukien = DateTime.Now, mucDo = 1 });*/