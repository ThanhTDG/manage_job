using ctk43_Nhom1_Manage_Job.myUserControl;
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
    public partial class frmThongBaoCV : Form
    {
        List<CongViec> congViecs;
        public frmThongBaoCV(List<CongViec> congViecs)
        {
            this.congViecs = congViecs;
            InitializeComponent();
        }
        #region Hàm bổ trợ 
        void GetListCV()
        {
            Music.Instance.PlayMusic();
            int countCV = congViecs.Count;
            if (countCV == 0)
                this.Close();
            UscThongBao[] thongbaos = new UscThongBao[countCV];
            for (int i = 0; i < countCV; i++)
            {
                thongbaos[i] = new UscThongBao();
                thongbaos[i]._CongViec = congViecs[i];
                thongbaos[i].setdata();
                int height = thongbaos[i].Size.Height;
                if (flowLayoutPanel1 != null)
                {
                    flowLayoutPanel1.Controls.Add(thongbaos[i]);
                    if(countCV == 1)
                    {
                        this.Size = new Size((thongbaos[i].Size.Width)+40, height + this.Size.Height +5);
                    }
                    else
                    {
                        if (i < 2) { this.Size = new Size((thongbaos[i].Size.Width) + 40, height + this.Size.Height + 20); }
                    }
                }

            }
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        #endregion

        #region event
        private void frmThongBaoCV_Load(object sender, EventArgs e)
        {
            GetListCV();
        }
        #endregion

        private void frmThongBaoCV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmThongBaoCV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Music.Instance.stopMusic();
        }
    }
}
