using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Define
{
    public static class DefineTrangThai 
    {
        #region Chung
        private static string[] ListTrangThai =
        {
                "Sắp diễn ra",
                "Đang thực hiện",
                "Đã hoàn thành",
                "Đã quá hạn",
                "Hoàn thành trễ",
                "Tất cả"
        };
        public static string[] getListTrangThai()
        {
            return ListTrangThai;
        }
        public static int getInt(string name)
        {
            for (int i = 0; i < ListTrangThai.Length; i++)
            {
                if (name == ListTrangThai[i])
                    return i;
            }
            return -1;
        }

        public static string GetString(int number)
        {
            if (number >= 0 && number < ListTrangThai.Length)
                return ListTrangThai[number];
            return null;
        }
        #endregion
    }
}
