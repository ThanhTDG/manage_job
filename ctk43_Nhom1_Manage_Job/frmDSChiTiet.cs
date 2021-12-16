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
using System.Timers;
using System.Windows.Forms;

namespace ctk43_Nhom1_Manage_Job
{
    public partial class frmDSChiTiet : Form
    {
        private CongViec _congViec;
        System.Timers.Timer t;
        int h, m, s;
        bool check;
        ListViewItem item;
        ChiTietCV chiTietCV;
        ChiTietCVBUS _chiTietCVBUS;
        private CongViecBUS congViecBUS;
        private ChuDeBUS chuDeBUS;

        public frmDSChiTiet(CongViec congViec)
        {
            InitializeComponent();
            _congViec = congViec;
            _chiTietCVBUS = new ChiTietCVBUS();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public string convertMinuteToTime(int min=-1)
        {
            if (min == -1) return "";
            int[] x = Extension.MinuteToTime(min);
            return $"{x[0]} ngày {x[1]} giờ {x[2]} phút.";
        }

        private void LoadCTCV()
        {
            lvDSChiTiet.Items.Clear();
            ChiTietCVBUS chiTietCVBUS = new ChiTietCVBUS();
            List<ChiTietCV> cv1 = chiTietCVBUS.GetChiTietByCongViec(_congViec).ToList().OrderBy(x => x.mucDo).ToList();
            List<ChiTietCV> cv2 = cv1.Where(x=>x.trangThai==1).OrderBy(x => x.trangThai).ToList();
            List<ChiTietCV> cv3 = cv1.Where(x=>x.trangThai!=1).OrderBy(x => x.trangThai).ToList();
            foreach (ChiTietCV ct in cv3.Concat(cv2))
            {
                ListViewItem item = new ListViewItem(ct.ten);
                item.SubItems.Add(convertMinuteToTime(ct.ThoiGianDukien==null?-1:Convert.ToInt32(ct.ThoiGianDukien)));
                item.SubItems.Add(convertMinuteToTime(ct.ThoiGianThucTe == null?-1 : Convert.ToInt32(ct.ThoiGianThucTe)));
                item.Tag = ct;
                if (ct.trangThai == 1) item.Checked = true;
                lvDSChiTiet.Items.Add(item);
            }
        }

        private void frmDSChiTiet_Load(object sender, EventArgs e)
        {
            txtTenCongViec.Text = _congViec.ten;
            rtxtMoTaCongViec.Text = _congViec.MoTa;
            dtpEnd.Value = _congViec.thoiGianKT;
            LoadCTCV();
            t = new System.Timers.Timer();
            t.Interval = 1;
            t.Elapsed += OnTimeEvent;
            check = false;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }
            if (IsHandleCreated)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        lbCountUp.Text = StringHMS();
                    }));
                }
            }
            else
            {
            }
        }

        private string StringHMS()
        {
            return String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Finish")
            {
                t.Stop();
                chiTietCV = _chiTietCVBUS.GetChiTietCongViecByID(chiTietCV.iD);
                chiTietCV.ThoiGianThucTe = h * 60 + m;
                MessageBox.Show(string.Format("Hoàn thành " + StringHMS()));
                chiTietCV.trangThai = 1;
                _chiTietCVBUS.Update(chiTietCV);
                this.DialogResult = DialogResult.OK;
            }
            else if (btnStart.Text == "Start")
            {
                t.Start();
                chiTietCV = item.Tag as ChiTietCV;
                lvDSChiTiet.Enabled = false;
                btnAdd.Enabled = false;
                btnStart.Text = "Finish";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmChiTietCV frm = new frmChiTietCV();
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            frm.LoadCV(_congViec);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCTCV();
            }
        }

        private void frmDSChiTiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check==false)
            {
                if (ThongBao.CauHoi("thoat va dung bo dem ko?") == DialogResult.Yes)
                {
                    t.Stop();
                    Application.DoEvents();
                }
                else
                {
                    e.Cancel = true;
                }
            }
           
        }

        private void lvDSChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lvDSChiTiet_Click(object sender, EventArgs e)
        {
            if (lvDSChiTiet.SelectedItems.Count >= 0)
            {
                item = lvDSChiTiet.SelectedItems[0];
                ChiTietCV ctcv = item.Tag as ChiTietCV;
                rtbMoTa.Text = ctcv.moTa;
                gbChiTiet.Text = ctcv.ten;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                t.Stop();
                check = true;
                btnPause.Text = "Continue";
            }
            else
            {
                t.Start();
                check = false;
                btnPause.Text = "Pause";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
            h = 0;m = 0;s = 0;
            lbCountUp.Text = $"{h}:{m}:{s}";
            lvDSChiTiet.Enabled = true;
            btnAdd.Enabled = true;
            btnStart.Text = "Start";
        }
    }
}
