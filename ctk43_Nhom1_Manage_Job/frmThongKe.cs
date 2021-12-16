using BUS;
using BUS.Define;
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
        public frmThongKe()
        {
            InitializeComponent();
            congViecBUS = new CongViecBUS();
            listCV = new List<CongViec>();
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            ckbMucDo.Enabled = false;
        }
        private List<int> ListCheckBoxMucDo()
		  {
            List<int> list = new List<int>();
            for(int i=0;i< ckbMucDo.Items.Count; i++)
				{
                if (ckbMucDo.GetItemChecked(i))
                    list.Add(i);
				}
            return list;
		  }
		  private void btnThongKe_Click(object sender, EventArgs e)
		  {
            lvThongKeTongCong.Items.Clear();
            lvThongKeHoanThanh.Items.Clear();
            lvThongKeChuaHoanThanh.Items.Clear();
            lvThongKeHetHan.Items.Clear();
            lvThongKeHoanThanhTre.Items.Clear();

            if (dtpTu.Value > dtpDen.Value)
				{
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc");
                return;
				}
            double tongCongViec = 0;
            double chuahoanthanh = 0, hoanthanh = 0, hethan = 0,hoanthanhtre=0;
            string trangthaiCV = "";
            if (rdTatCa.Checked == true)
            {
                foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd))
                {
                    if (cv.thoiGianKT < dtpTu.Value && cv.trangThai == 3)
                    {
                        ListViewItem item = new ListViewItem(cv.ten);
                        TimeSpan time = dtpTu.Value - cv.thoiGianKT;
                        item.SubItems.Add(time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ ");
                        trangthaiCV = "Quá hạn";
                        item.ForeColor = MyColor.ColorLevel(cv.mucDo);
                        lvThongKeHetHan.Items.Add(item);

                        ListViewItem itemHetHan = new ListViewItem(cv.ten);
                        itemHetHan.SubItems.Add(trangthaiCV);
                        itemHetHan.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                        itemHetHan.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                        itemHetHan.ForeColor = MyColor.ColorLevel(cv.mucDo);
                        lvThongKeTongCong.Items.Add(itemHetHan);

                        //tongCongViec++;
                        //hethan++;
                    }
                    else if(cv.thoiGianKT < dtpTu.Value && cv.trangThai == 4)
						  {
                        ListViewItem item = new ListViewItem(cv.ten);
                        item.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(cv.ngayHoanThanh.Value.ToShortDateString());
                        item.ForeColor = MyColor.ColorLevel(cv.mucDo);
                        lvThongKeHoanThanhTre.Items.Add(item);

                        trangthaiCV = "Hoàn thành trễ";
                        ListViewItem itemHoanThanhTre = new ListViewItem(cv.ten);
                        itemHoanThanhTre.SubItems.Add(trangthaiCV);
                        itemHoanThanhTre.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                        itemHoanThanhTre.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                        itemHoanThanhTre.ForeColor = MyColor.ColorLevel(cv.mucDo);
                        lvThongKeTongCong.Items.Add(itemHoanThanhTre);
                    }
                    else
                    {
                        if (cv.thoiGianBD <= dtpTu.Value && dtpDen.Value <= cv.thoiGianKT)
                        {
                            ListViewItem item = new ListViewItem(cv.ten);
                            if (cv.trangThai == 2)
                                trangthaiCV = "Hoàn thành";
                            else if (cv.trangThai == 1)
                                trangthaiCV = "Chưa hoàn thành";

                            if (trangthaiCV == "Hoàn thành")
                            {
                                //hoanthanh++;
                                ListViewItem itemHoanThanh = new ListViewItem(cv.ten);
                                itemHoanThanh.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                                itemHoanThanh.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                                itemHoanThanh.ForeColor = MyColor.ColorLevel(cv.mucDo);
                                lvThongKeHoanThanh.Items.Add(itemHoanThanh);
                            }
                            else
                            {
                                //chuahoanthanh++;
                                ListViewItem itemChuaHoanThanh = new ListViewItem(cv.ten);
                                TimeSpan time = cv.thoiGianKT - DateTime.Now;
                                if (time.Days == 0)
                                {
                                    itemChuaHoanThanh.SubItems.Add(time.Hours.ToString() + " giờ " + time.Minutes.ToString() + " giờ ");
                                }
                                else
                                {
                                    itemChuaHoanThanh.SubItems.Add(time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ ");
                                }
                                itemChuaHoanThanh.ForeColor = MyColor.ColorLevel(cv.mucDo);
                                lvThongKeChuaHoanThanh.Items.Add(itemChuaHoanThanh);
                            }
                            item.SubItems.Add(trangthaiCV);
                            item.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                            item.ForeColor = MyColor.ColorLevel(cv.mucDo);
                            lvThongKeTongCong.Items.Add(item);

                            //tongCongViec++;
                        }
                    }
                }
            }
				else
				{
                foreach(int mucdo in ListCheckBoxMucDo())
					 {
                    foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd))
                    {
                        if (cv.thoiGianKT < dtpTu.Value && cv.trangThai == 3 && cv.mucDo == mucdo)
                        {
                            ListViewItem item = new ListViewItem(cv.ten);
                            TimeSpan time = dtpTu.Value - cv.thoiGianKT;
                            item.SubItems.Add(time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ ");
                            trangthaiCV = "Quá hạn";
                            item.ForeColor = MyColor.ColorLevel(cv.mucDo);
                            lvThongKeHetHan.Items.Add(item);

                            ListViewItem itemHetHan = new ListViewItem(cv.ten);
                            itemHetHan.SubItems.Add(trangthaiCV);
                            itemHetHan.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                            itemHetHan.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                            itemHetHan.ForeColor = MyColor.ColorLevel(cv.mucDo);
                            lvThongKeTongCong.Items.Add(itemHetHan);

                            //tongCongViec++;
                            //hethan++;
                        }
                        else if (cv.thoiGianKT < dtpTu.Value && cv.trangThai == 4 && cv.mucDo == mucdo)
                        {
                            ListViewItem item = new ListViewItem(cv.ten);
                            item.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(cv.ngayHoanThanh.Value.ToShortDateString());
                            item.ForeColor = MyColor.ColorLevel(cv.mucDo);
                            lvThongKeHoanThanhTre.Items.Add(item);

                            trangthaiCV = "Hoàn thành trễ";
                            ListViewItem itemHoanThanhTre = new ListViewItem(cv.ten);
                            itemHoanThanhTre.SubItems.Add(trangthaiCV);
                            itemHoanThanhTre.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                            itemHoanThanhTre.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                            itemHoanThanhTre.ForeColor = MyColor.ColorLevel(cv.mucDo);
                            lvThongKeTongCong.Items.Add(itemHoanThanhTre);
                        }
                        else
                        {
                            if (cv.thoiGianBD <= dtpTu.Value && dtpDen.Value <= cv.thoiGianKT && cv.mucDo == mucdo)
                            {
                                ListViewItem item = new ListViewItem(cv.ten);
                                if (cv.trangThai == 2)
                                    trangthaiCV = "Hoàn thành";
                                else if (cv.trangThai == 1)
                                    trangthaiCV = "Chưa hoàn thành";

                                if (trangthaiCV == "Hoàn thành")
                                {
                                    //hoanthanh++;
                                    ListViewItem itemHoanThanh = new ListViewItem(cv.ten);
                                    itemHoanThanh.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                                    itemHoanThanh.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                                    itemHoanThanh.ForeColor = MyColor.ColorLevel(cv.mucDo);
                                    lvThongKeHoanThanh.Items.Add(itemHoanThanh);
                                }
                                else
                                {
                                    //chuahoanthanh++;
                                    ListViewItem itemChuaHoanThanh = new ListViewItem(cv.ten);
                                    TimeSpan time = cv.thoiGianKT - DateTime.Now;
                                    if (time.Days == 0)
                                    {
                                        itemChuaHoanThanh.SubItems.Add(time.Hours.ToString() + " giờ " + time.Minutes.ToString() + " giờ ");
                                    }
                                    else
                                    {
                                        itemChuaHoanThanh.SubItems.Add(time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ ");
                                    }
                                    itemChuaHoanThanh.ForeColor = MyColor.ColorLevel(cv.mucDo);
                                    lvThongKeChuaHoanThanh.Items.Add(itemChuaHoanThanh);
                                }
                                item.SubItems.Add(trangthaiCV);
                                item.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
                                item.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
                                item.ForeColor = MyColor.ColorLevel(cv.mucDo);
                                lvThongKeTongCong.Items.Add(item);

                                //tongCongViec++;
                            }
                        }
                    }
                }
				}
            hoanthanh = lvThongKeHoanThanh.Items.Count;
            chuahoanthanh = lvThongKeChuaHoanThanh.Items.Count;
            hethan = lvThongKeHetHan.Items.Count;
            hoanthanhtre = lvThongKeHoanThanhTre.Items.Count;
            tongCongViec = hoanthanh + chuahoanthanh + hethan+hoanthanhtre;
            lbTongCong.Text = tongCongViec.ToString();
            lbHoanThanh.Text = hoanthanh.ToString();
            lbChuaXong.Text = chuahoanthanh.ToString();
            lbHetHan.Text = hethan.ToString();
            lbHoanThanhTre.Text = hoanthanhtre.ToString();
            lbTiLeHoanThanh.Text = Math.Round(((hoanthanh / tongCongViec) * 100), 2).ToString() + "%";
            lbTiLeChuaXong.Text = Math.Round(((chuahoanthanh / tongCongViec) * 100), 2).ToString() + "%";
            lbTiLeHetHan.Text = Math.Round(((hethan / tongCongViec) * 100), 2).ToString() + "%";
            lbTiLeHoanThanhTre.Text = Math.Round(((hoanthanhtre / tongCongViec) * 100), 2).ToString() + "%";
        }

        private void rdTuyChon_CheckedChanged(object sender, EventArgs e)
		  {
            if (rdTuyChon.Checked == true)
                ckbMucDo.Enabled = true;
            else
                ckbMucDo.Enabled = false;
		  }
	 }
}
