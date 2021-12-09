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
    public partial class frmDSChiTiet : Form
    {
        private CongViec _congViec;
        public frmDSChiTiet(CongViec congViec)
        {
            InitializeComponent();
            _congViec = congViec;
        }

        private void frmDSChiTiet_Load(object sender, EventArgs e)
        {
            txtTenCongViec.Text = _congViec.ten;
            rtxtMoTaCongViec.Text = _congViec.MoTa;

            ChiTietCVBUS chiTietCVBUS = new ChiTietCVBUS();
            foreach (var ct in chiTietCVBUS.GetChiTietByCongViec(_congViec))
            {
                ListViewItem item = new ListViewItem(ct.ten);
                item.SubItems.Add(ct.ThoiGianDukien.ToString());
                item.SubItems.Add(ct.moTa);
                lvDSChiTiet.Items.Add(item);
            }
        }
    }
}
