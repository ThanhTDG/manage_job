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
    public partial class frmThongKe : Form
    {
        CongViecBUS congViecBUS;
        NguoiDung nd = Extension.LoadSetting(Properties.Settings.Default.email, Properties.Settings.Default.emailDefault);
        List<CongViec> listCV;
        int tongCongViec = 0;
        public frmThongKe()
        {
            InitializeComponent();
            congViecBUS = new CongViecBUS();
            listCV = new List<CongViec>();
        }

		  private void ThongKe_Load(object sender, EventArgs e)
		  {
            ckbMucDo.Enabled = false;
		  }

		  private void btnThongKe_Click(object sender, EventArgs e)
		  {
            double chuahoanthanh=0, hoanthanh=0, hethan=0;
            string trangthaiCV;
            foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd))
            {
					 if (dtpTu.Value >= cv.thoiGianKT && cv.trangThai == 0 )
					 {
                    ListViewItem item = new ListViewItem(cv.ten);
                    TimeSpan time = dtpTu.Value - cv.thoiGianKT;
                    item.SubItems.Add(time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ ");
                    trangthaiCV = "Quá hạn";
                    lvThongKeHetHan.Items.Add(item);

                    ListViewItem itemHetHan = new ListViewItem(cv.ten);
                    itemHetHan.SubItems.Add(trangthaiCV);
                    itemHetHan.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                    itemHetHan.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                    lvThongKeTongCong.Items.Add(itemHetHan);

                    tongCongViec++;
                    hethan++;
                }
                else
					 {
                    if (cv.thoiGianBD <= dtpTu.Value && dtpDen.Value <= cv.thoiGianKT)
                    {
                        if (rdTatCa.Checked == true)
                        {
                            ListViewItem item = new ListViewItem(cv.ten);
                            if (cv.trangThai == 1)
                                trangthaiCV = "Hoàn thành";
                            else
                                trangthaiCV = "Chưa hoàn thành";

                            if(trangthaiCV == "Hoàn thành")
									 {
                                hoanthanh++;
                                ListViewItem itemHoanThanh = new ListViewItem(cv.ten);
                                itemHoanThanh.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                                itemHoanThanh.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                                lvThongKeHoanThanh.Items.Add(itemHoanThanh);
                            }
                            else
									 {
                                chuahoanthanh++;
                                ListViewItem itemChuaHoanThanh = new ListViewItem(cv.ten);
                                TimeSpan time = cv.thoiGianKT - DateTime.Now;
                                if(time.Days == 0)
										  {
                                    itemChuaHoanThanh.SubItems.Add(time.Hours.ToString() + " giờ " + time.Minutes.ToString() + " giờ ");
                                }
                                else
										  {
                                    itemChuaHoanThanh.SubItems.Add(time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ ");
                                }
                                lvThongKeChuaHoanThanh.Items.Add(itemChuaHoanThanh);
                            }
                            item.SubItems.Add(trangthaiCV);
                            item.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                            tongCongViec++;
                            lvThongKeTongCong.Items.Add(item);
                        }
                    }
                }
            }
            lbTongCong.Text = tongCongViec.ToString();
            lbHoanThanh.Text = hoanthanh.ToString();
            lbChuaXong.Text = chuahoanthanh.ToString();
            lbHetHan.Text = hethan.ToString();
            lbTiLeHoanThanh.Text = Math.Round(((hoanthanh / tongCongViec) * 100),2).ToString()+"%";
            lbTiLeChuaXong.Text = Math.Round(((chuahoanthanh / tongCongViec) * 100), 2).ToString() + "%";
            lbTiLeHetHan.Text = Math.Round(((hethan / tongCongViec) * 100), 2).ToString() + "%";
        }

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
		  {
            if(rdTatCa.Checked == false)
				{
                ckbMucDo.Enabled = true;
				}
				else
				{
                ckbMucDo.Enabled = false;
				}
		  }
	 }
}
