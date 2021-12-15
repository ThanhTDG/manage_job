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

        public static int TimeToMinute(int day, int hour, int minute)
        {
            return (((day * 24) + hour) * 60) + minute;
        }
        public static int TimeToSecond(int day, int hour, int minute,int second)
        {
            return ((((day * 24) + hour) * 60) + minute)*60 + second;
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

        /// <summary>
        /// 0: chua bat dau
        ///1: Dang dien ra
        ///2: Hoan thanh
        ///3: Qua han
        ///4: Hoan thanh tre
        /// </summary>
        /// <param name="typeStatus"></param>
        /// <returns></returns>
        public static int typeStatusOfTheJob(DateTime start, DateTime end, int status = -1)
        {
            if (status == 2 && DateTime.Now <= end)
                return 2;
            else if (status == 2 && DateTime.Now > end)
                return 4;
            else if (DateTime.Now < start)
                return 0;
            else if (DateTime.Now < end)
                return 1;
            return 3;
        }

        public static int DayWeekMonthYear(int type)
        {
            const int times = 10;
            int x = 0;
            switch (type)
            {
                case 1:
                    //ngay
                    x = times * 365;
                    break;
                case 2:
                    //tuan 
                    x = times * 4 * 12;
                    break;
                case 3:
                    //thang
                    x = times * 12;
                    break;
                case 4:
                    //nam
                    x = times;
                    break;
            }
            return x;
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
            congViec.trangThai = 1;
            congViecBUS.Update(congViec);
            return congViec;
        }
        public static CongViec UpdateOver(CongViec congViec, CongViecBUS congViecBUS)
        {
            congViec.trangThai = 3;
            congViecBUS.Update(congViec);
            return congViec;
        }

    }
}
