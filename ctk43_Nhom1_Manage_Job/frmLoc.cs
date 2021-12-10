using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace ctk43_Nhom1_Manage_Job
{
    public partial class frmLoc : Form
    {
        public frmLoc()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            mucdo0.Text = TinhTrang.Instance.Mucdo()[0];
            mucdo1.Text = TinhTrang.Instance.Mucdo()[1];
            mucdo2.Text = TinhTrang.Instance.Mucdo()[2];
            mucdo3.Text = TinhTrang.Instance.Mucdo()[3];
            mucdo4.Text = TinhTrang.Instance.Mucdo()[4];

            trangthai0.Text = TinhTrang.Instance.TrangThai()[0];
            trangthai1.Text = TinhTrang.Instance.TrangThai()[1];
            trangthai2.Text = TinhTrang.Instance.TrangThai()[2];
            trangthai3.Text = TinhTrang.Instance.TrangThai()[3];
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
           loadData();
            rdAllMucDo.Checked = true;
            rdAllTrangThai.Checked = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            TinhTrang.Instance._mucdo = new List<int>();
            TinhTrang.Instance._trangthai = new List<int>();
            TinhTrang.Instance._time = new List<DateTime>();
            TinhTrang.Instance._time.Add(dtpStart.Value);
            TinhTrang.Instance._time.Add(dtpEnd.Value);
            if (trangthai0.Checked)
                TinhTrang.Instance._trangthai.Add(0);
            if (trangthai1.Checked)
                TinhTrang.Instance._trangthai.Add(1);
            if (trangthai2.Checked)
                TinhTrang.Instance._trangthai.Add(2);
            if (trangthai3.Checked)
                TinhTrang.Instance._trangthai.Add(3);
            if (mucdo0.Checked)
                TinhTrang.Instance._mucdo.Add(0);
            if (mucdo1.Checked)
                TinhTrang.Instance._mucdo.Add(1);
            if (mucdo2.Checked)
                TinhTrang.Instance._mucdo.Add(2);
            if (mucdo3.Checked)
                TinhTrang.Instance._mucdo.Add(3);
            if (mucdo4.Checked)
                TinhTrang.Instance._mucdo.Add(4);
            this.Close();

        }

        private void rdTrangThaiChitiet_CheckedChanged(object sender, EventArgs e)
        {
            trangthai0.Enabled = true;
            trangthai1.Enabled = true;
            trangthai2.Enabled = true;
            trangthai3.Enabled = true;
        }
        private void rdAllTrangThai_CheckedChanged(object sender, EventArgs e)
        {

            trangthai0.Enabled = false;
            trangthai1.Enabled = false;
            trangthai2.Enabled = false;
            trangthai3.Enabled = false;
        }
        private void rdMucDo_CheckedChanged(object sender, EventArgs e)
        {
            mucdo0.Enabled = true;
            mucdo1.Enabled = true;
            mucdo2.Enabled = true;
            mucdo3.Enabled = true;
            mucdo4.Enabled = true;
        }
        private void rdAllMucDo_CheckedChanged(object sender, EventArgs e)
        {
            mucdo0.Enabled = false;
            mucdo1.Enabled = false;
            mucdo2.Enabled = false;
            mucdo3.Enabled = false;
            mucdo4.Enabled = false;
        }
    }
}
