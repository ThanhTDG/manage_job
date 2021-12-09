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
    public partial class frmCongViec : Form
    {
        public CongViec _congviec;
        private CongViecBUS congViecBUS;
        private ChiTietCVBUS chiTietCVBUS;
        private ChuDeBUS chuDeBUS;
        public frmCongViec(CongViec cv = null)
        {
            InitializeComponent();
            chuDeBUS = new ChuDeBUS();
            congViecBUS = new CongViecBUS();
            chiTietCVBUS = new ChiTietCVBUS();
            _congviec = cv;
            cbbLevel.Items.AddRange(ThongBao.strs);
        }

        public void LoadChuDe(NguoiDung nd)
        {
            cbbTopic.DataSource = chuDeBUS.GetChuDeByNguoiDung(nd).ToList();
            cbbTopic.DisplayMember = "Ten";
            cbbTopic.ValueMember = "iD";
        }

        public void LoadCV()
        {
            cbbTopic.SelectedValue = _congviec.IDChuDe;
            txtTitle.Text = _congviec.ten;
            TimeSpan time = _congviec.thoiGianKT - DateTime.Now;
            string s = "";
            if (time.Minutes < 0) s = "Đã quá hạng ";
            txtRemine.Text = s + Math.Abs(time.Days).ToString() + " ngày " + Math.Abs(time.Hours).ToString() + " giờ " + Math.Abs(time.Minutes).ToString() + " phút.";
            dtpStart.Value = _congviec.thoiGianBD;
            dtpEnd.Value = _congviec.thoiGianKT;
            cbbLevel.SelectedIndex = _congviec.mucDo;
            txtProcess.Text = chiTietCVBUS.Process(_congviec).ToString();
            richDescription.Text = _congviec.MoTa;
        }

        public bool CheckValid()
        {
            bool kq = true;
            if (string.IsNullOrWhiteSpace(cbbTopic.Text))
                kq = false;               
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
                kq = false;
            if (dtpStart.Value > dtpEnd.Value)
                kq = false;            
            return kq;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                ThongBao.CanhBao("Các nội dung");
                return;
            }
            if (_congviec == null)
            {
                _congviec = new CongViec
                {
                    IDChuDe = Convert.ToInt32(cbbTopic.SelectedValue),
                    ten = txtTitle.Text,
                    MoTa = richDescription.Text,
                    thoiGianBD = dtpStart.Value,
                    thoiGianKT = dtpEnd.Value,
                    tienDo = 0,
                    mucDo = Convert.ToInt32(cbbLevel.SelectedIndex),
                    trangThai = 0,
                };
                congViecBUS.Insert(_congviec);
            }
            else
            {
                int tiendo = chiTietCVBUS.Process(_congviec);
                _congviec.IDChuDe = Convert.ToInt32(cbbTopic.SelectedValue);
                _congviec.ten = txtTitle.Text;
                _congviec.MoTa = richDescription.Text;
                _congviec.thoiGianBD = dtpStart.Value;
                _congviec.thoiGianKT = dtpEnd.Value;
                _congviec.tienDo = tiendo;
                _congviec.mucDo = Convert.ToInt32(cbbLevel.SelectedIndex);
                _congviec.trangThai = tiendo==100?1:0;
                congViecBUS.Update(_congviec);
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            if (_congviec == null) return;
            _congviec = congViecBUS.GetCongViecByID(_congviec.iD);
            LoadCV();
        }
    }
}
