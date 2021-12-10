using BUS;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctk43_Nhom1_Manage_Job
{
    public partial class frmGhiChu : Form
    {
        NguoiDung _nd = Extension.LoadSetting(Properties.Settings.Default.email);
        private int _ghiChuId;        
        public frmGhiChu(int ghiChuid = 0)
        {
            InitializeComponent();
            _ghiChuId = ghiChuid;
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(rtxtContent.Text))
            {
                ThongBao.CanhBao("Nội dung hoặc tiêu đề");
                return;
            }

            GhiChuNhanhBUS ghiChuNhanhBUS = new GhiChuNhanhBUS();
            if (_ghiChuId == 0)
            {
                GhiChuNhanh ghiChu = new GhiChuNhanh()
                {
                    Email = _nd.email,
                    TieuDe = txtTitle.Text,
                    NoiDung = rtxtContent.Text,
                    ThoiGianBD = DateTime.Now
                };

                int kq = ghiChuNhanhBUS.Insert(ghiChu);
                if (kq > 0)
                    ThongBao.ThanhCong("Thêm ghi chú nhanh");
            }
            else
            {
                GhiChuNhanh gc = ghiChuNhanhBUS.GetGhiChuByID(_ghiChuId);
                gc.TieuDe = txtTitle.Text;
                gc.NoiDung = rtxtContent.Text;
                ghiChuNhanhBUS.Update(gc);
                ThongBao.ThanhCong("Lưu");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void frmGhiChu_Load(object sender, EventArgs e)
        {
            if (_ghiChuId != 0)
            {
                GhiChuNhanhBUS ghiChuNhanhBUS = new GhiChuNhanhBUS();
                GhiChuNhanh gc = ghiChuNhanhBUS.GetGhiChuByID(_ghiChuId);
                txtTitle.Text = gc.TieuDe;
                rtxtContent.Text = gc.NoiDung;
            }
        }
    }
}
