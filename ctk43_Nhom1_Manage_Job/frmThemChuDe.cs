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

namespace ctk43_Nhom1_Manage_Job
{
    public partial class frmThemChuDe : Form
    {
        public frmThemChuDe()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtTenChuDe.Text;
            if(name == "")
            {

            }
            else
            {
                ChuDeBUS chuDeBUS = new ChuDeBUS();
                chuDeBUS.Insert(name);
            }
        }
    }
}
