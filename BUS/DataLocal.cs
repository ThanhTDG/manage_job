using DAO.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public enum find
    {
        thoigian,
        mucdo,
        trangthai
    }

    public class ColorMN
    {
        public static Color ColorLevel(int mucDo)
        {
            return Color.FromArgb(255 - mucDo * 51, 50, 0 + mucDo * 51);
        }
        public static Color GREEN = Color.Green;
    }


    public class TinhTrang
    {
        private static TinhTrang instance;
        private Dictionary<int, string> mucdo;
        private Dictionary<int, string> trangthai;
        public List<int> _mucdo;
        public List<int> _trangthai;
        public List<DateTime> _time;
        public static TinhTrang Instance
        {
            get { if (instance == null) return instance = new TinhTrang(); return instance; }
            private set { instance = value; }
        }
        private TinhTrang()
        {

            mucdo = new Dictionary<int, string>();
            trangthai = new Dictionary<int, string>();
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
        }
    }
}
