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

        public static void ThanhCong(string message)
        {
            MessageBox.Show(message + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ThatBai(string message)
        {
            MessageBox.Show(message + " thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult CauHoi(string message)
        {
            return MessageBox.Show("Bạn có chắc chắn muốn " + message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
