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
    public partial class frmThongKe : Form
    {

        CongViecBUS congViecBUS;
        NguoiDung nd = Extension.LoadSetting(Properties.Settings.Default.email, Properties.Settings.Default.emailDefault);
        List<CongViec> listCV;
        int tongCongViec = 0;
        public frmThongKe()
        {
            InitializeComponent();
        }
    }
}
