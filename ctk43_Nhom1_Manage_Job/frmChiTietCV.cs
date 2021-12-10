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
    public partial class frmChiTietCV : Form
    {
        public ChiTietCV _chiTietCV;
        ChiTietCVBUS chiTietCVBUS;

        public frmChiTietCV(ChiTietCV chiTietCV = null)
        {
            InitializeComponent();
            chiTietCVBUS = new ChiTietCVBUS();
            _chiTietCV = chiTietCV;
            cbbLevel.Items.AddRange(ThongBao.strs);
            cbbLevel.SelectedIndex = 0;
        }

        private void frmChiTietCV_Load(object sender, EventArgs e)
        {
            if (_chiTietCV == null) return;
            _chiTietCV = chiTietCVBUS.GetChiTietCongViecByID(_chiTietCV.iD);
            LoadCTCV();
        }

        int[] dayHourMinute(int minute)
        {
            int day = minute / 1440;
            int i = minute % 1400;
            int hour = i / 60;
            int min = i % 60;
            return new int[] { day, hour, min };
        }

        private void LoadCTCV()
        {
            cbbJob.SelectedValue = _chiTietCV.iD;
            txtJobDetail.Text = _chiTietCV.ten;
            int[] dhm;
            if (_chiTietCV.ThoiGianDukien != null)
            {
                dhm = dayHourMinute(_chiTietCV.ThoiGianDukien.Value);
                txtIntentDay.Text = dhm[0].ToString();
                txtIntentHour.Text = dhm[1].ToString();
                txtIntentMinute.Text = dhm[2].ToString();
            }
            if (_chiTietCV.ThoiGianThucTe != null)
            {
                dhm = dayHourMinute(_chiTietCV.ThoiGianThucTe.Value);
                txtRealDay.Text = dhm[0].ToString();
                txtRealHour.Text = dhm[1].ToString();
                txtRealMinute.Text = dhm[2].ToString();
            }
            cbbLevel.SelectedIndex = _chiTietCV.mucDo;
            richDescription.Text = _chiTietCV.moTa;
        }

        private int? MinuteConvert(string d, string h, string m)
        {
            int? minute;
            try
            {
                minute = int.Parse(d) * 24 + int.Parse(h) * 60 + int.Parse(m);
            }
            catch (Exception)
            {
                minute = null;
            }
            return minute;
        }

        private void SaveJobDetail(ref ChiTietCV _chiTietCV)
        {
            int? intentMinute = MinuteConvert(txtIntentDay.Text, txtIntentHour.Text, txtIntentMinute.Text);
            int? realMinute = MinuteConvert(txtRealDay.Text, txtRealHour.Text, txtRealMinute.Text);
            _chiTietCV.iDCongviec = Convert.ToInt32(cbbJob.SelectedValue);
            _chiTietCV.ten = txtJobDetail.Text;
            _chiTietCV.moTa = richDescription.Text;
            _chiTietCV.ThoiGianDukien = intentMinute;
            _chiTietCV.ThoiGianThucTe = realMinute;
            _chiTietCV.mucDo = Convert.ToInt32(cbbLevel.SelectedIndex);
            _chiTietCV.trangThai = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJobDetail.Text))
            {
                MessageBox.Show("Vui long nhap tieu de");
                return;
            }
            if (_chiTietCV == null)
            {
                _chiTietCV = new ChiTietCV();
                SaveJobDetail(ref _chiTietCV);
                chiTietCVBUS.Insert(_chiTietCV);
            }
            else
            {
                SaveJobDetail(ref _chiTietCV);
                chiTietCVBUS.Update(_chiTietCV);
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void LoadCV(List<CongViec> cvs)
        {
            cbbJob.DataSource = cvs;
            cbbJob.DisplayMember = "ten";
            cbbJob.ValueMember = "ID";
        }
    }
}