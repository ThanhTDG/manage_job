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
    public partial class frmThongBao : Form
    {
        NguoiDung nd = Extension.LoadSetting(Properties.Settings.Default.email, Properties.Settings.Default.emailDefault);
        CongViecBUS congViecBUS = new CongViecBUS();
        DateTime selectDate;
        public frmThongBao()
        {
            InitializeComponent();
        }

		  private void frmThongBao_Load(object sender, EventArgs e)
		  {
            LoadListViewThongBao(DateTime.Now);
        }

		  private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		  {
            selectDate = e.Start;
            lvThongBaoCongViec.Items.Clear();
            LoadListViewThongBao(selectDate);
        }
		  private void LoadListViewThongBao(DateTime date)
		  {
				foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
				{
					 if (cv.thoiGianBD <= date && date <= cv.thoiGianKT && cv.trangThai == 0)
					 {
						  TimeSpan time = cv.thoiGianKT - date;
						  int days = time.Days;
						  int hours = time.Hours;
						  int minutes = time.Minutes;
						  ListViewItem item = new ListViewItem(cv.ten);
						  if (days == 0)
						  {
								item.SubItems.Add(hours.ToString() + " giờ " + minutes.ToString() + " phút ");
						  }
						  else
						  {
								item.SubItems.Add(days.ToString() + " ngày " + hours.ToString() + " giờ ");
						  }
						  item.SubItems.Add(cv.tienDo + "%");
						  lvThongBaoCongViec.Items.Add(item);
					 }
				}
		  }
	 }
}
