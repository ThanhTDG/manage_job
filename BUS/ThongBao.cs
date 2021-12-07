using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public static class ThongBao
    {
        public static void CanhBao(string message)
        {
            MessageBox.Show(message + " không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }      
    }
}
