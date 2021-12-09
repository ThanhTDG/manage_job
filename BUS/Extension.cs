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
        public static int TimeToMinute(int day,int hour,int minute)
        {
            return (((day * 24) + hour) * 60) + minute;
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
            time[1] = minute / 60 % 24 ;
            time[2] = minute %60 % 24;
            return time;

        }
    }
}
