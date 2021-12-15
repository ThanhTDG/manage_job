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
        Binding binding;
        public UscThongBao()
        {
            binding = new Binding("txt", lbTienDo, "Value", false, DataSourceUpdateMode.Never);
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
            set { congViec = value;
                
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
                case 0:
                    txtName.Text = congViec.thoiGianBD.ToLongTimeString();
                    title = "Sắp bắt đầu";
                    break;
            //    case 1:

                        
            }
            lbpercent.Text = congViec.ten;
            txtMota.Text = congViec.MoTa;
            lbTienDo.DataBindings.Add(binding);
        }
        #endregion
    }
}
