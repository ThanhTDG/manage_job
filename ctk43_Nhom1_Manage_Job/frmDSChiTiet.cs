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

        public frmDSChiTiet(CongViec congViec)
        {
            InitializeComponent();
            _congViec = congViec;
            _chiTietCVBUS = new ChiTietCVBUS();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void frmDSChiTiet_Load(object sender, EventArgs e)
        {
            txtTenCongViec.Text = _congViec.ten;
            rtxtMoTaCongViec.Text = _congViec.MoTa;

            ChiTietCVBUS chiTietCVBUS = new ChiTietCVBUS();
            foreach (ChiTietCV ct in chiTietCVBUS.GetChiTietByCongViec(_congViec))
            {
                ListViewItem item = new ListViewItem(ct.ten);
                item.SubItems.Add(ct.ThoiGianDukien.ToString());
                item.Tag = ct;
                lvDSChiTiet.Items.Add(item);
            }
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
                chiTietCV = _chiTietCVBUS.GetChiTietCongViecByID(chiTietCV.iD);
                chiTietCV.ThoiGianThucTe = h * 60 + m;
                MessageBox.Show(string.Format("Hoàn thành " + StringHMS()));
                chiTietCV.trangThai = 1;
                _chiTietCVBUS.Update(chiTietCV);
                t.Stop();
                this.DialogResult = DialogResult.OK;
            }
            else if (btnStart.Text == "Start")
            {
                t.Start();
                item.BackColor = Color.Green;
                chiTietCV = item.Tag as ChiTietCV;
            }
            btnStart.Text = "Finish";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
            //if (lvDSChiTiet.SelectedItems.Count >= 0)
            //{
            //    ListViewItem item = lvDSChiTiet.SelectedItems[0];
            //    ChiTietCV cv = item.Tag as ChiTietCV;
            //    rtbMoTa.Text = cv.moTa;
            //}
        }

        private void lvDSChiTiet_Click(object sender, EventArgs e)
        {
            if (lvDSChiTiet.SelectedItems.Count >= 0)
            {
                item = lvDSChiTiet.SelectedItems[0];
                ChiTietCV cv = item.Tag as ChiTietCV;
                rtbMoTa.Text = cv.moTa;
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
        }
    }
}
