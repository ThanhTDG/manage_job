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
				ListCongViecQuaHanHomNay();
            LoadListViewThongBao(DateTime.Now);
        }

		  private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		  {
            selectDate = e.Start;
				if(selectDate.Date == DateTime.Now.Date)
				{
					 selectDate = DateTime.Now;
				}
            lvThongBaoCongViec.Items.Clear();
            LoadListViewThongBao(selectDate);
        }
		  private void ListCongViecQuaHanHomNay()
		  {
				foreach (CongViec congviec in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
				{
					 var cv = congViecBUS.GetCongViecByID(congviec.iD);
					 if (cv.thoiGianKT < DateTime.Now && cv.trangThai == 1)
					 {
						  cv.trangThai = 3;
						  congViecBUS.Update(cv);
					 }
				}
		  }
		  private void LoadListViewThongBao(DateTime date)
		  {
				if(date == DateTime.Now)
				{
					 foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
					 {
						  if (cv.thoiGianKT < date && cv.trangThai == 3)
						  {
								TimeSpan time = date - cv.thoiGianKT;
								int days = time.Days;
								int hours = time.Hours;
								int minutes = time.Minutes;
								ListViewItem item = new ListViewItem(cv.ten);
								if (days == 0)
								{
									 item.SubItems.Add("Quá hạn " + hours.ToString() + " giờ " + minutes.ToString() + " phút");
								}
								else
								{
									 item.SubItems.Add("Quá hạn " + days.ToString() + " ngày " + hours.ToString() + " giờ");
								}
								lvThongBaoCongViec.Items.Add(item);
						  }
					 }
					 foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
					 {
						  if (cv.thoiGianBD <= date && date <= cv.thoiGianKT && cv.trangThai == 1)
						  {
								TimeSpan time = cv.thoiGianKT - date;
								int days = time.Days;
								int hours = time.Hours;
								int minutes = time.Minutes;
								ListViewItem item = new ListViewItem(cv.ten);
								if (days == 0)
								{
									 item.SubItems.Add("Còn " + hours.ToString() + " giờ " + minutes.ToString() + " phút ");
								}
								else
								{
									 item.SubItems.Add("Còn " + days.ToString() + " ngày " + hours.ToString() + " giờ ");
								}
								// tô màu
								int type = 0;
								if (days == 0 && hours == 0 && minutes <= 60)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Red;
								}
								else if (days == 0 && 1 <= hours && hours < 2)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Orange;
								}
								else if (days == 0 && 2 <= hours && hours < 5)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.FromArgb(253, 208, 35);
								}
								else if (5 <= hours && days < 2)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Green;
								}
								else if (2 <= days)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Blue;
								}
								lvThongBaoCongViec.Items.Add(item);
						  }
					 }
					 foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
					 {
						  if (date < cv.thoiGianBD && cv.trangThai == 0)
						  {
								TimeSpan time = cv.thoiGianBD - date;
								int days = time.Days;
								int hours = time.Hours;
								int minutes = time.Minutes;
								ListViewItem item = new ListViewItem(cv.ten);
								if (days == 0)
								{
									 item.SubItems.Add(hours.ToString() + " giờ " + minutes.ToString() + " phút sẽ bắt đầu công việc");
								}
								else
								{
									 item.SubItems.Add(days.ToString() + " ngày " + hours.ToString() + " giờ sẽ bắt đầu công việc");
								}
								item.ForeColor = Color.White;
								item.BackColor = Color.LightSkyBlue;
								lvThongBaoCongViec.Items.Add(item);
						  }
					 }
				}
				else
				{
					 foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
					 {
						  if (cv.thoiGianKT < date && cv.trangThai != 2 && cv.trangThai !=4)
						  {
								TimeSpan time = date - cv.thoiGianKT;
								int days = time.Days;
								int hours = time.Hours;
								int minutes = time.Minutes;
								ListViewItem item = new ListViewItem(cv.ten);
								if (days == 0)
								{
									 item.SubItems.Add("Quá hạn " + hours.ToString() + " giờ " + minutes.ToString() + " phút");
								}
								else
								{
									 item.SubItems.Add("Quá hạn " + days.ToString() + " ngày " + hours.ToString() + " giờ");
								}
								lvThongBaoCongViec.Items.Add(item);
						  }
					 }
					 foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
					 {
						  if (cv.thoiGianBD <= date && date <= cv.thoiGianKT && cv.trangThai != 2)
						  {
								TimeSpan time = cv.thoiGianKT - date;
								int days = time.Days;
								int hours = time.Hours;
								int minutes = time.Minutes;
								ListViewItem item = new ListViewItem(cv.ten);
								if (days == 0)
								{
									 item.SubItems.Add("Còn " + hours.ToString() + " giờ " + minutes.ToString() + " phút ");
								}
								else
								{
									 item.SubItems.Add("Còn " + days.ToString() + " ngày " + hours.ToString() + " giờ ");
								}
								// tô màu
								if (days == 0 && hours == 0 && minutes <= 60)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Red;
								}
								else if (days == 0 && 1 <= hours && hours < 2)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Orange;
								}
								else if (days == 0 && 2 <= hours && hours < 5)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.FromArgb(253, 208, 35);
								}
								else if (5 <= hours && days < 2)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Green;
								}
								else if (2 <= days)
								{
									 item.ForeColor = Color.White;
									 item.BackColor = Color.Blue;
								}
								lvThongBaoCongViec.Items.Add(item);
						  }
					 }
					 foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd).OrderBy(x => x.thoiGianKT))
					 {
						  if (date < cv.thoiGianBD)
						  {
								TimeSpan time = cv.thoiGianBD - date;
								int days = time.Days;
								int hours = time.Hours;
								int minutes = time.Minutes;
								ListViewItem item = new ListViewItem(cv.ten);
								if (days == 0)
								{
									 item.SubItems.Add(hours.ToString() + " giờ " + minutes.ToString() + " phút sẽ bắt đầu công việc");
								}
								else
								{
									 item.SubItems.Add(days.ToString() + " ngày " + hours.ToString() + " giờ sẽ bắt đầu công việc");
								}
								item.ForeColor = Color.White;
								item.BackColor = Color.LightSkyBlue;
								lvThongBaoCongViec.Items.Add(item);
						  }
					 }
				}
				tslTongSoCongViec.Text = "Tổng số công việc : " + lvThongBaoCongViec.Items.Count.ToString();
		  }
	 }
}
