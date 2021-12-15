using System.Drawing;

namespace BUS.Define
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
    public class ColorMN
    {
        public static Color ColorLevel(int mucDo)
        {
            return Color.FromArgb(255 - mucDo * 51, 50, 0 + mucDo * 51);
        }
        public static Color GREEN = Color.Green;
    }
}
