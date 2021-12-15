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

namespace ctk43_Nhom1_Manage_Job.myUserControl
{
    public partial class UscThongBao : UserControl
    {
        public UscThongBao()
        {
            InitializeComponent();
        }
        #region Properties
        private string title;
        private CongViec congViec;
        
        public string Title
        {
            get {  return title; }
            set {  title = value; }
        }
        public CongViec _CongViec
        {
            get {  return congViec; }
            set { congViec =value;
                
            }
        }
        #endregion
        #region Bổ trợ
        public void setdata()
        {
            pcbTienDo.Value = congViec.tienDo;
            txtName.Text = congViec.ten;
            switch (congViec.trangThai)
            {
                case 1:
                    lbTime.Text = congViec.thoiGianBD.ToString();
                    label1.Text = "Đã bắt đầu";
                    break;
                case 3:
                    txtTime.Text = congViec.thoiGianBD.ToString();
                    label1.Text = "Đã hết hạn";
                    break;
            }
            title = DefineTrangThai.GetString(congViec.trangThai);
            txtMota.Text = congViec.MoTa;
            lbpercent.Text = congViec.tienDo.ToString() + "%";
        }
        #endregion
    }
}
