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
        private NguoiDung _nd;

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
            _nd = nd;
            cbbTopic.DataSource = chuDeBUS.GetChuDeByLoai0(nd).ToList();
            cbbTopic.DisplayMember = "Ten";
            cbbTopic.ValueMember = "iD";
        }

        public void LoadCV()
        {
            TimeSpan time;
            int id = chuDeBUS.GetIDByNameChuDe(_congviec.ten);
            if (id != -1)
            {
                cbbTypeOfTopic.SelectedIndex = chuDeBUS.GetChuDeByID(id).loaiChuDe;
            }
            cbbTypeOfTopic.Enabled = false;
            cbbTopic.SelectedValue = _congviec.IDChuDe;
            txtTitle.Text = _congviec.ten;
            dtpStart.Value = _congviec.thoiGianBD;
            dtpEnd.Value = _congviec.thoiGianKT;
            cbbLevel.SelectedIndex = _congviec.mucDo;
            txtProcess.Text = _congviec.tienDo.ToString();
            richDescription.Text = _congviec.MoTa;
            if (_congviec.trangThai == 0)
            {
                label7.Text = "Bắt đầu trong";
                time = _congviec.thoiGianBD - DateTime.Now;
                txtRemine.Text = Math.Abs(time.Days).ToString() + " ngày " + Math.Abs(time.Hours).ToString() + " giờ " + Math.Abs(time.Minutes).ToString() + " phút.";
                return;
            }
            else if(_congviec.trangThai == 1)
            {
                label7.Text = "Còn lại";
                time = _congviec.thoiGianKT - DateTime.Now;
                txtRemine.Text = Math.Abs(time.Days).ToString() + " ngày " + Math.Abs(time.Hours).ToString() + " giờ " + Math.Abs(time.Minutes).ToString() + " phút.";
            }
            else if (_congviec.trangThai == 2)
            {
                label7.Text = "Hoàn thành";
                txtRemine.Text = $"{_congviec.ngayHoanThanh.Value.ToString("dd/MM/yy HH:mm:ss")}";
                return;
            }
            else if(_congviec.trangThai == 3)
            {
                label7.Text = "Đã quá hạn";
                time = _congviec.thoiGianKT - DateTime.Now;
                txtRemine.Text = Math.Abs(time.Days).ToString() + " ngày " + Math.Abs(time.Hours).ToString() + " giờ " + Math.Abs(time.Minutes).ToString() + " phút.";
            }
            else if (_congviec.trangThai == 4)
            {
                label7.Text = "Hoàn thành Trễ";
                txtRemine.Text = $"{_congviec.ngayHoanThanh.Value.ToString("dd/MM/yy HH:mm:ss")}";
                return;
            }
        }

        public bool CheckValid()
        {
            bool kq = true;
            if (string.IsNullOrWhiteSpace(cbbTopic.Text) && cbbTypeOfTopic.SelectedIndex==0)
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
            if (_congviec == null && cbbTypeOfTopic.SelectedIndex == 0)
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
            else if(cbbTypeOfTopic.SelectedIndex == 0)
            {
                _congviec.IDChuDe = Convert.ToInt32(cbbTopic.SelectedValue);
                _congviec.ten = txtTitle.Text;
                _congviec.MoTa = richDescription.Text;
                _congviec.thoiGianBD = dtpStart.Value;
                _congviec.thoiGianKT = dtpEnd.Value;
                _congviec.tienDo = chiTietCVBUS.Process(_congviec);
                _congviec.mucDo = Convert.ToInt32(cbbLevel.SelectedIndex);
                _congviec.trangThai = Extension.typeStatusOfTheJob(dtpStart.Value, dtpEnd.Value, _congviec.trangThai);
                congViecBUS.Update(_congviec);
            }
            else if (cbbTypeOfTopic.SelectedIndex != 0 && _congviec != null)
            {
                UpdateFollowTypeOfTopic();
            }
            else
            {
                AddJobVia();
            }
            DialogResult = DialogResult.OK;
        }

        private CongViec UpdateCVTheoLoai(CongViec cv)
        {
            cv.IDChuDe = cv.IDChuDe;
            cv.ten = txtTitle.Text;
            cv.MoTa = richDescription.Text;
            cv.tienDo = chiTietCVBUS.Process(cv);
            cv.mucDo = Convert.ToInt32(cbbLevel.SelectedIndex);
            cv.trangThai = Extension.typeStatusOfTheJob(dtpStart.Value, dtpEnd.Value, cv.trangThai);
            return cv;
        }

        private void UpdateFollowTypeOfTopic()
        {
            int type = cbbTypeOfTopic.SelectedIndex;
            List<CongViec> cvs = congViecBUS.GetCongViecByLoaiChuDe(type, _nd).Where(x=>x.ten==_congviec.ten).ToList();
            UpdateChuDe();
            int size = Extension.DayWeekMonthYear(type);
            var s1 = new CongViec();
            s1.thoiGianBD = dtpStart.Value;
            s1.thoiGianKT = dtpEnd.Value;
            foreach (CongViec i in cvs)
            {
                var item = congViecBUS.GetCongViecByID(i.iD);
                var cv =UpdateCVTheoLoai(item);
                cv.thoiGianBD = s1.thoiGianBD;
                cv.thoiGianKT = s1.thoiGianKT;
                congViecBUS.Update(cv);
                AddFollowDMY(ref s1, cv, type);
            }
        }

        private void AddJobVia()
        {
            int type = cbbTypeOfTopic.SelectedIndex;
            int id = ChuyenChuDe(type);
            if (id == -1) return;
            int size = Extension.DayWeekMonthYear(type);
            var s1 = new CongViec();
            s1.thoiGianBD = dtpStart.Value;
            s1.thoiGianKT = dtpEnd.Value;
            for (int i = 0; i < size; i++)
            {
                var cv = new CongViec();
                CongViecBUS congViecBUS = new CongViecBUS();
                cv.IDChuDe = id;
                cv.ten = txtTitle.Text;
                cv.MoTa = richDescription.Text;
                cv.tienDo = 0;
                cv.thoiGianBD = s1.thoiGianBD;
                cv.thoiGianKT = s1.thoiGianKT;
                cv.mucDo = Convert.ToInt32(cbbLevel.SelectedIndex);
                cv.trangThai = Extension.typeStatusOfTheJob(cv.thoiGianBD, cv.thoiGianKT);
                congViecBUS.Insert(cv);
                AddFollowDMY(ref s1, cv, type);
            }
        }

        private void AddFollowDMY(ref CongViec cv, CongViec s1, int type)
        {
            switch (type)
            {
                case 1:
                    cv.thoiGianBD = s1.thoiGianBD.AddDays(1);
                    cv.thoiGianKT = s1.thoiGianKT.AddDays(1);
                    break;
                case 2:
                    cv.thoiGianBD = s1.thoiGianBD.AddDays(7);
                    cv.thoiGianKT = s1.thoiGianKT.AddDays(7);
                    break;
                case 3:
                    cv.thoiGianBD = s1.thoiGianBD.AddMonths(1);
                    cv.thoiGianKT = s1.thoiGianKT.AddMonths(1);
                    break;
                case 4:
                    cv.thoiGianBD = s1.thoiGianBD.AddYears(1);
                    cv.thoiGianKT = s1.thoiGianKT.AddYears(1);
                    break;
            }
        }

        private int ChuyenChuDe(int type)
        {
            ChuDeBUS chuDeBUS = new ChuDeBUS();
            int kq;
            kq = chuDeBUS.Insert(new ChuDe
            {
                ten = txtTitle.Text,
                Email = _nd.email,
                loaiChuDe = type
            });
            return kq;
        }

        private void UpdateChuDe()
        {
            ChuDe chuDe = chuDeBUS.GetChuDeByID(_congviec.IDChuDe);
            chuDe.ten = txtTitle.Text;
            chuDeBUS.Update(chuDe);
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
            if (cbbTypeOfTopic.SelectedIndex == 0)
            {
                cbbTopic.Enabled = true;
                dtpStart.CustomFormat = "dd/MM/yyyy  H:mm:ss";
                dtpEnd.CustomFormat = "dd/MM/yyyy  H:mm:ss";
                label4.Text = "Thời gian bắt đầu";
                label2.Text = "Thời gian kết thúc";
            }
            if (cbbTypeOfTopic.SelectedIndex == 1 || cbbTypeOfTopic.SelectedIndex == 2)//dayly, weekly
            {
                cbbTopic.Enabled = false;
                cbbTopic.SelectedValue = "";
                dtpStart.CustomFormat = "H: mm: ss";
                dtpEnd.CustomFormat = "H: mm: ss";
                label4.Text = "Giờ bắt đầu";
                label2.Text = "Giờ kết thúc";
            }
            else if (cbbTypeOfTopic.SelectedIndex == 3)//monthly
            {
                cbbTopic.Enabled = false;
                cbbTopic.SelectedValue = "";
                dtpStart.CustomFormat = "dd H:mm:ss";
                dtpEnd.CustomFormat = "dd H:mm:ss";
                label4.Text = "Ngày bắt đầu";
                label2.Text = "Ngày kết thúc";
            }
            else if (cbbTypeOfTopic.SelectedIndex == 4)//Yearly
            {
                cbbTopic.Enabled = false;
                cbbTopic.SelectedValue = "";
                dtpStart.CustomFormat = "dd/MM H:mm:ss";
                dtpEnd.CustomFormat = "dd/MM H:mm:ss";
                label4.Text = "Thời gian bắt đầu";
                label2.Text = "Thời gian kết thúc";
            }
        }
    }
}
