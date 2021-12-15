using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Define
{
    public static class DefineMucDo
    {
        private static string[] ListMucDo =
             {
                "Cực kỳ quan trọng",
                "Rất quan trọng",
                "Quan trọng",
                "hơi quan trọng",
                "Không quan trọng"
            };

        public static string[] getListMucDo()
        {
            return ListMucDo;
        }

        public static int getInt(string name)
        {
            for (int i = 0; i < ListMucDo.Length; i++)
            {
                if (name == ListMucDo[i])
                    return i;
            }
            return -1;
        }
        public static string GetString(int number)
        {
            if (number >= 0 && number < ListMucDo.Length)
                return ListMucDo[number];
            return null;

        }
    }
}
