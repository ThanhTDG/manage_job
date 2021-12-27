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
using BUS.Define;

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
            mucdo0.Text = DefineMucDo.GetString(0);
            mucdo1.Text = DefineMucDo.GetString(1);
            mucdo2.Text = DefineMucDo.GetString(2);
            mucdo3.Text = DefineMucDo.GetString(3);
            mucdo4.Text = DefineMucDo.GetString(4);
            trangthai0.Text = DefineTrangThai.GetString(0);
            trangthai1.Text = DefineTrangThai.GetString(1);
            trangthai2.Text = DefineTrangThai.GetString(2);
            trangthai3.Text = DefineTrangThai.GetString(3);
            trangthai4.Text = DefineTrangThai.GetString(4);
        }
        void EnabelTrangThai(bool enable)
        {
            trangthai0.Enabled = enable;
            trangthai1.Enabled = enable;
            trangthai2.Enabled = enable;
            trangthai3.Enabled = enable;
            trangthai4.Enabled = enable;
            if (!enable)
                unckeckTrangThai();
        }
        void EnableMucDo(bool enable)
        {
            mucdo0.Enabled = enable;
            mucdo1.Enabled = enable;
            mucdo2.Enabled = enable;
            mucdo3.Enabled = enable;
            mucdo4.Enabled = enable;
            if (!enable)
                unckeckMucDo();
        }
        void unckeckMucDo()
        {
            mucdo0.Checked = false;
            mucdo1.Checked = false;
            mucdo2.Checked = false;
            mucdo3.Checked = false;
            mucdo4.Checked = false;
        }
        void unckeckTrangThai()
        {
            trangthai0.Checked = false;
            trangthai1.Checked = false;
            trangthai2.Checked = false;
            trangthai3.Checked = false;
            trangthai4.Checked = false;
        }

        private void getData()
        {
            DataCheck.Instance.resetData();
            getTime();
            getCheckTrangThai();
            getCheckMucDo();
        }

        private void getCheckMucDo()
        {
            if (mucdo0.Checked)
                DataCheck.Instance.mucdo.Add(0);
            if (mucdo1.Checked)
                DataCheck.Instance.mucdo.Add(1);
            if (mucdo2.Checked)
                DataCheck.Instance.mucdo.Add(2);
            if (mucdo3.Checked)
                DataCheck.Instance.mucdo.Add(3);
            if (mucdo4.Checked)
                DataCheck.Instance.mucdo.Add(4);
        }

        private void getTime()
        {
            DataCheck.Instance.time.Add(dtpStart.Value.Date);
            DataCheck.Instance.time.Add(dtpEnd.Value.Date.AddDays(1));
        }

        private void getCheckTrangThai()
        {
            if (trangthai0.Checked)
                DataCheck.Instance.trangthai.Add(0);
            if (trangthai1.Checked)
                DataCheck.Instance.trangthai.Add(1);
            if (trangthai2.Checked)
                DataCheck.Instance.trangthai.Add(2);
            if (trangthai3.Checked)
                DataCheck.Instance.trangthai.Add(3);
        }

        private void CheckTime()
        {
            if (dtpStart.Value > dtpStart.Value)
                return;
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

            loadData();
            rdAllMucDo.Checked = true;
            rdAllTrangThai.Checked = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value.Date > dtpEnd.Value.Date)
            {
                ThongBao.SoSanh("Ngày bắt đầu không được lớn hơn ngày kết thúc");
                return;
            }
            getData();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rdTrangThaiChitiet_CheckedChanged(object sender, EventArgs e)
        {
            EnabelTrangThai(true);
            rdAllMucDo.PerformClick();
        }

        private void rdAllTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            EnabelTrangThai(false);

        }
        private void rdMucDo_CheckedChanged(object sender, EventArgs e)
        {
            EnableMucDo(true);

        }
        private void rdAllMucDo_CheckedChanged(object sender, EventArgs e)
        {
            EnableMucDo(false);
            rdAllTrangThai.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
