using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO.Model;

namespace ctk43_Nhom1_Manage_Job
{
    public partial class frmThemChuDe : Form
    {
        private NguoiDung _nd;
        private ChuDe _chuDe;
        public frmThemChuDe(ChuDe chuDe = null)
        {
            InitializeComponent();
            _chuDe = chuDe;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {            
            if(string.IsNullOrWhiteSpace(txtTenChuDe.Text))
            {
                ThongBao.CanhBao("Tên chủ đề");
                          
            }
            else
            {
                ChuDeBUS chuDeBUS = new ChuDeBUS();
                int kq;
                if (_chuDe == null)
                {
                    kq = chuDeBUS.Insert(new ChuDe
                    {
                        ten = txtTenChuDe.Text,
                        Email = _nd.email,
                        loaiChuDe = 0
                    });
                    if (kq > 0)
                    {
                        ThongBao.ThanhCong("Thêm chủ đề");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        ThongBao.ThatBai("Thêm chủ đề");
                }     
                else
                {
                    ChuDe chuDeUpdate = chuDeBUS.GetChuDeByID(_chuDe.iD);
                    chuDeUpdate.ten = txtTenChuDe.Text;
                    chuDeBUS.Update(chuDeUpdate);
                    ThongBao.ThanhCong("Cập nhật chủ đề");
                    this.DialogResult = DialogResult.OK;
                }           
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemChuDe_Load(object sender, EventArgs e)
        {
            _nd = Extension.LoadSetting(Properties.Settings.Default.email);
            if (_chuDe != null)
            {
                txtTenChuDe.Text = _chuDe.ten;
                this.Text = "Cập nhật chủ đề";
            }
            else
                this.Text = "Thêm chủ đề";
        }
    }
}
