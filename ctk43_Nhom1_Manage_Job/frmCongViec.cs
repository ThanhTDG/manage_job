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
            cbbTypeOfTopic.Items.AddRange(ThongBao.typeOfTopic);
            cbbTypeOfTopic.SelectedIndex = 0;
            cbbLevel.SelectedIndex = 0;
        }

        public void LoadChuDe(NguoiDung nd)
        {
            cbbTopic.DataSource = chuDeBUS.GetChuDeByNguoiDung(nd).ToList();
            cbbTopic.DisplayMember = "Ten";
            cbbTopic.ValueMember = "iD";
        }

        public void LoadCV()
        {
            TimeSpan time;
            cbbTopic.SelectedValue = _congviec.IDChuDe;
            txtTitle.Text = _congviec.ten;
            dtpStart.Value = _congviec.thoiGianBD;
            dtpEnd.Value = _congviec.thoiGianKT;
            cbbLevel.SelectedIndex = _congviec.mucDo;
            txtProcess.Text = _congviec.tienDo.ToString();
            richDescription.Text = _congviec.MoTa;
            if (_congviec.trangThai == 2)
            {
                txtRemine.Text = $"Hoàn thành: {_congviec.ngayHoanThanh.Value.ToString("dd/MM/yy HH:mm:ss")}";
                return;
            }
            if (_congviec.thoiGianBD > DateTime.Now)
            {
                time = _congviec.thoiGianBD - DateTime.Now;
                txtRemine.Text = "Bắt đầu trong: " + Math.Abs(time.Days).ToString() + " ngày " + Math.Abs(time.Hours).ToString() + " giờ " + Math.Abs(time.Minutes).ToString() + " phút.";
                return;
            }
            else
            {
                time = _congviec.thoiGianKT - DateTime.Now;
                string s = "";
                if (time.Minutes < 0) s = "Đã quá hạn ";
                else s = "Còn lại: ";
                txtRemine.Text = s + Math.Abs(time.Days).ToString() + " ngày " + Math.Abs(time.Hours).ToString() + " giờ " + Math.Abs(time.Minutes).ToString() + " phút.";
            }
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
                    trangThai = Extension.typeStatusOfTheJob(dtpStart.Value, dtpEnd.Value)
                };
                congViecBUS.Insert(_congviec);
            }
            else
            {
                _congviec.IDChuDe = Convert.ToInt32(cbbTopic.SelectedValue);
                _congviec.ten = txtTitle.Text;
                _congviec.MoTa = richDescription.Text;
                _congviec.thoiGianBD = dtpStart.Value;
                _congviec.thoiGianKT = dtpEnd.Value;
                _congviec.tienDo = chiTietCVBUS.Process(_congviec);
                _congviec.mucDo = Convert.ToInt32(cbbLevel.SelectedIndex);
                _congviec.trangThai = Extension.typeStatusOfTheJob(dtpStart.Value,dtpEnd.Value,_congviec.trangThai);
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

        private void cbbTypeOfTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTopic.Enabled = true;
            if (cbbTypeOfTopic.SelectedIndex != 0)
            {
                cbbTopic.Enabled = false;
                dtpStart.CustomFormat = "dd/MM/yyyy  H:mm:ss";
                dtpEnd.CustomFormat = "dd/MM/yyyy  H:mm:ss";
            }
            if (cbbTypeOfTopic.SelectedIndex == 1)
            {
                dtpStart.CustomFormat = "H: mm: ss";
                dtpEnd.CustomFormat = "H: mm: ss";
            }else if (cbbTypeOfTopic.SelectedIndex == 2)
            {
                dtpStart.CustomFormat = "MM";
                dtpEnd.CustomFormat = "MM";
            }
        }
    }
}
