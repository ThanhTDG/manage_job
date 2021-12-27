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
        private string TrangThaiCongViec(int trangthai)
		  {
            string trangthaiCV="";
				switch (trangthai)
				{
                case 0:
                    trangthaiCV = "Chưa bắt đầu";
                    break;
                case 1:
                    trangthaiCV = "Chưa hoàn thành";
                    break;
                case 2:
                    trangthaiCV = "Hoàn thành";
                    break;
                case 3:
                    trangthaiCV = "Quá hạn";
                    break;
                case 4:
                    trangthaiCV = "Hoàn thành trễ";
                    break;
            }
            return trangthaiCV;
		  }

        private void AddCongViecHoanThanh(CongViec cv)
		  {
            ListViewItem itemHoanThanh = new ListViewItem(cv.ten);
            itemHoanThanh.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
            itemHoanThanh.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
            itemHoanThanh.ForeColor = MyColor.ColorLevel(cv.mucDo);
            lvThongKeHoanThanh.Items.Add(itemHoanThanh);
        }
        private void AddCongViecHetHan(CongViec cv)
		  {
            ListViewItem item = new ListViewItem(cv.ten);
            TimeSpan time = DateTime.Now - cv.thoiGianKT;
            if(time.Days == 0)
				{
                item.SubItems.Add(time.Hours.ToString() + " giờ " + time.Minutes.ToString() + " phút ");
            }
				else
				{
                item.SubItems.Add(time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ ");
            }
            item.ForeColor = MyColor.ColorLevel(cv.mucDo);
            lvThongKeHetHan.Items.Add(item);
        }
        private void AddCongViecChuaHoanThanh(CongViec cv)
		  {
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
        private void AddCongViecHoanThanhTre(CongViec cv)
		  {
            ListViewItem item = new ListViewItem(cv.ten);
            item.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
            item.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
            item.SubItems.Add(cv.ngayHoanThanh.Value.ToShortDateString());
            item.ForeColor = MyColor.ColorLevel(cv.mucDo);
            lvThongKeHoanThanhTre.Items.Add(item);
        }
        private void AddCongViecTatCa(CongViec cv)
		  {
            ListViewItem item = new ListViewItem(cv.ten);
            string trangthai = TrangThaiCongViec(cv.trangThai);
            item.SubItems.Add(trangthai);
            item.SubItems.Add(cv.thoiGianBD.ToString("dd/MM/yyyy"));
            item.SubItems.Add(cv.thoiGianKT.ToString("dd/MM/yyyy"));
            item.ForeColor = MyColor.ColorLevel(cv.mucDo);
            lvThongKeTongCong.Items.Add(item);
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
        private void btnThongKe_Click(object sender, EventArgs e)
		  {
            ListCongViecQuaHanHomNay();
            dtpTu.Value = Convert.ToDateTime(dtpTu.Value.ToShortDateString() + " 00:00:00");
            dtpDen.Value = Convert.ToDateTime(dtpDen.Value.ToShortDateString() + " 23:59:59");

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
            if(rdTatCa.Checked == false && rdTuyChon.Checked == false)
				{
                MessageBox.Show("Hãy chọn các mức độ");
                return;
            }
            double tongCongViec = 0;
            double chuahoanthanh = 0, hoanthanh = 0, hethan = 0,hoanthanhtre=0;
            if (rdTatCa.Checked == true)
            {
                foreach (CongViec cv in congViecBUS.GetCongViecByNguoiDung(nd))
                {
                    if (cv.thoiGianKT < dtpTu.Value && cv.trangThai == 3)
                    {
                        AddCongViecHetHan(cv);
                        AddCongViecTatCa(cv);
                    }
                    else if(cv.thoiGianKT < dtpTu.Value && cv.trangThai == 4)
						  {
                        AddCongViecHoanThanhTre(cv);
                        AddCongViecTatCa(cv);
                    }
                    else
                    {
                        if ((cv.thoiGianBD <= dtpTu.Value && dtpTu.Value <= cv.thoiGianKT) || 
                            (cv.thoiGianBD <= dtpDen.Value && dtpDen.Value <= cv.thoiGianKT) ||
                            (dtpTu.Value <= cv.thoiGianBD && cv.thoiGianKT <= dtpDen.Value) ||
                            (cv.thoiGianBD <= dtpTu.Value && dtpDen.Value <= cv.thoiGianKT))
                        {
                            if (cv.trangThai == 2)
                                AddCongViecHoanThanh(cv);
                            else if (cv.trangThai == 1)
                                AddCongViecChuaHoanThanh(cv);
                            else if (cv.trangThai == 3)
                                AddCongViecHetHan(cv);
                            else if (cv.trangThai == 4)
                                AddCongViecHoanThanhTre(cv);
                            AddCongViecTatCa(cv);
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
                            AddCongViecHetHan(cv);
                            AddCongViecTatCa(cv);
                        }
                        else if (cv.thoiGianKT < dtpTu.Value && cv.trangThai == 4 && cv.mucDo == mucdo)
                        {
                            AddCongViecHoanThanhTre(cv);
                            AddCongViecTatCa(cv);
                        }
                        else if(cv.mucDo == mucdo)
                        {
                            if ((cv.thoiGianBD <= dtpTu.Value && dtpTu.Value <= cv.thoiGianKT) ||
                                (cv.thoiGianBD <= dtpDen.Value && dtpDen.Value <= cv.thoiGianKT) ||
                                (dtpTu.Value <= cv.thoiGianBD && cv.thoiGianKT <= dtpDen.Value) ||
                                (cv.thoiGianBD <= dtpTu.Value && dtpDen.Value <= cv.thoiGianKT))
                            {
                                if (cv.trangThai == 2)
                                    AddCongViecHoanThanh(cv);
                                else if (cv.trangThai == 1)
                                    AddCongViecChuaHoanThanh(cv);
                                else if (cv.trangThai == 3)
                                    AddCongViecHetHan(cv);
                                else if (cv.trangThai == 4)
                                    AddCongViecHoanThanhTre(cv);
                                AddCongViecTatCa(cv);
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
            if(tongCongViec != 0)
				{
                lbTiLeHoanThanh.Text = Math.Round(((hoanthanh / tongCongViec) * 100), 2).ToString() + "%";
                lbTiLeChuaXong.Text = Math.Round(((chuahoanthanh / tongCongViec) * 100), 2).ToString() + "%";
                lbTiLeHetHan.Text = Math.Round(((hethan / tongCongViec) * 100), 2).ToString() + "%";
                lbTiLeHoanThanhTre.Text = Math.Round(((hoanthanhtre / tongCongViec) * 100), 2).ToString() + "%";
				}
				else
				{
                lbTiLeHoanThanh.Text = "0%";
                lbTiLeChuaXong.Text = "0%";
                lbTiLeHetHan.Text = "0%";
                lbTiLeHoanThanhTre.Text = "0%";
            }

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
