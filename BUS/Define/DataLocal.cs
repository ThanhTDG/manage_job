using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
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
    }
}
