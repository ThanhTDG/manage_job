using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public enum find
    {
        thoigian,
        mucdo,
        trangthai
    }

    public enum sort
    {
        TangTheoTG,
        GiamTheoTG,
        TangTheoMucDo,
        GiamTheoMucDo,
        TangTheoTen,
        GiamTheoTen
    }


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
        public static int TimeToMinute(int day, int hour, int minute)
        {
            return (((day * 24) + hour) * 60) + minute;
        }
        public static int TimeToSecond(int day, int hour, int minute, int second)
        {
            return ((((day * 24) + hour) * 60) + minute) * 60 + second;
        }
        /// <summary>
        /// [0] day
        /// [1] hour
        /// [2] minute
        /// </summary>
        /// <param name="minute"></param>
        /// <returns></returns>
        public static int[] MinuteToTime(int minute)
        {
            int[] time = new int[3];
            time[0] = minute / 60 / 24;
            time[1] = minute / 60 % 24;
            time[2] = minute % 60 % 24;
            return time;
        }
        public static CongViec GetcongViec(CongViec cv)
        {
            CongViec congViec = new CongViec();
            congViec.iD = cv.iD;
            congViec.ten = cv.ten;
            congViec.IDChuDe = cv.IDChuDe;
            congViec.thoiGianBD = cv.thoiGianBD;
            congViec.thoiGianKT = cv.thoiGianKT;
            congViec.tienDo = cv.tienDo;
            congViec.trangThai = cv.trangThai;
            return congViec;
        }
        public static CongViec UpdateComing(CongViec congViec, CongViecBUS congViecBUS)
        {
            congViec.mucDo = 2;
            congViecBUS.Update(congViec);
            return congViec;
        }
        public static CongViec UpdateOver(CongViec congViec, CongViecBUS congViecBUS)
        {
            congViec.mucDo = 3;
            congViecBUS.Update(congViec);
            return congViec;
        }
    }
}
