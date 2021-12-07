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
        public frmThemChuDe()
        {
            InitializeComponent();
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
                chuDeBUS.Insert(new ChuDe
                {
                    ten = txtTenChuDe.Text,                  
                    Email = _nd.email 
                });
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemChuDe_Load(object sender, EventArgs e)
        {
            _nd = Extension.LoadSetting(Properties.Settings.Default.email);
        }
    }
}
