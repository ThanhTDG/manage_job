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
        CongViecBUS congViecBUS;
        int idCV = 0;

        public frmChiTietCV(ChiTietCV chiTietCV = null)
        {
            InitializeComponent();
            chiTietCVBUS = new ChiTietCVBUS();
            congViecBUS = new CongViecBUS();
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
            txtJobDetail.Text = _chiTietCV.ten;
            int[] dhm;
            if (_chiTietCV.ThoiGianDukien != null)
            {
                dhm = dayHourMinute(_chiTietCV.ThoiGianDukien.Value);
                nudIntentDay.Text = dhm[0].ToString();
                nudIntentHour.Text = dhm[1].ToString();
                nudIntentMinute.Text = dhm[2].ToString();
            }
            if (_chiTietCV.ThoiGianThucTe != null)
            {
                dhm = dayHourMinute(_chiTietCV.ThoiGianThucTe.Value);
                nudRealDay.Text = dhm[0].ToString();
                nudRealHour.Text = dhm[1].ToString();
                nudRealMinute.Text = dhm[2].ToString();
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

        private void SaveJobDetail(ref ChiTietCV _chiTietCV, int i = -1)
        {
            int? intentMinute = MinuteConvert(nudIntentDay.Text, nudIntentHour.Text, nudIntentMinute.Text);
            _chiTietCV.iDCongviec = idCV;
            _chiTietCV.ten = txtJobDetail.Text;
            _chiTietCV.moTa = richDescription.Text;
            _chiTietCV.ThoiGianDukien = intentMinute;
            _chiTietCV.mucDo = Convert.ToInt32(cbbLevel.SelectedIndex);
            _chiTietCV.trangThai = 0;
            if (i != -1)
            {
                int realMinute = Extension.UpdateMinute();
                _chiTietCV.ThoiGianThucTe = realMinute;
            }
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
                SaveJobDetail(ref _chiTietCV, 1);
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

        internal void LoadCV(CongViec congViec)
        {
            txtJob.Text = congViec.ten;
            idCV = congViec.iD;
        }
    }
}