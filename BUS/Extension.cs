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

    public class TinhTrang{
        private static TinhTrang instance;
        private Dictionary<int, string> mucdo;
        private Dictionary<int, string> trangthai;
        private Dictionary<int, string> loaiChuDe;
        public  List<int> _mucdo;
        public List<int> _trangthai;
        public List<DateTime> _time;
        public static TinhTrang Instance
        {
            get { if (instance == null) return instance = new TinhTrang(); return instance; }
            private set { instance = value; }
        }
        private TinhTrang() {

            mucdo = new Dictionary<int, string>();
            trangthai = new Dictionary<int, string>();
            loaiChuDe = new Dictionary<int, string>();
            getData();
        }
        public Dictionary<int, string> Mucdo()
        {
            return mucdo;
        }
        public Dictionary<int, string> TrangThai()
        {
            return trangthai;
        }

        public Dictionary<int, string> LoaiChuDe()
        {
            return loaiChuDe;
        }

        private void getData()
        {
            mucdo.Add(4, "Không quan trọng");
            mucdo.Add(3, "hơi quan trọng");
            mucdo.Add(2, "Quan trọng");
            mucdo.Add(1, "Rất quan trọng");
            mucdo.Add(0, "Cực kỳ quan trọng");

            trangthai.Add(0, "Sắp diễn ra");
            trangthai.Add(1, "Đang thực hiện");
            trangthai.Add(2, "Đã hoàn thành");
            trangthai.Add(3, "Đã quá hạn");

            loaiChuDe.Add(1, "Hàng ngày");
            loaiChuDe.Add(2, "Hàng tuần");
            loaiChuDe.Add(3, "Hàng tháng");
            loaiChuDe.Add(4, "Hàng năm");
        }

        public int GetIntLoaiChuDe(string value)
        {
            return loaiChuDe.FirstOrDefault(x => x.Value == value).Key;
        }
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
