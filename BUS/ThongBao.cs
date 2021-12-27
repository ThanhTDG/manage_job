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
        #region Chung
        public static string PlaceHolderText = "Nhập tên công việc hoặc ghi chú muốn tìm!";
        public static string NameGroupBox = "Nhập tên công việc hoặc ghi chú muốn tìm!";
        public static string[] strs = { "rất khẩn cấp", "khẩn cấp", "quan trọng", "hơi quan trọng", "Không quan trọng" };
        public static string[] typeOfTopic = { "Common", "Hằng ngày", "Hằng tuần", "Hằng tháng", "Hằng năm" };

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

        public static void SoSanh(string message)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static string SetGroupBoxName(string chuDe, string chucNang = null)
        {
            if (string.IsNullOrWhiteSpace(chucNang))
                return string.Format("Danh sách công việc theo {0}", chuDe);
            else
                return string.Format("Danh sách công việc theo {0} - {1}", chuDe, chucNang);
        }
        #endregion
    }
}