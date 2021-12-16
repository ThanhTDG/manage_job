using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Define
{
    public static class DefineLoaiChuDe
    {
        #region Chung
        private static string[] ListLoaiChuDe =
             {
                 "Hàng ngày",
                 "Hàng tuần",
                 "Hàng tháng",
                 "Hàng năm"
            };

        public static string[] getListLoaiChuDe()
        {
            return ListLoaiChuDe;
        }

        public static int getInt(string name)
        {

            for (int i = 0; i < ListLoaiChuDe.Length; i++)
            {
                if (name == ListLoaiChuDe[i])
                    return i+1;
            }
            return -1;
        }
        public static string GetString(int number)
        {
            number -= 1;
            if (number >= 0 && number < ListLoaiChuDe.Length)
                return ListLoaiChuDe[number];
            return null;

        }
        #endregion
    }
}
