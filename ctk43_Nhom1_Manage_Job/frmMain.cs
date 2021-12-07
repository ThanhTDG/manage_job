using BUS;
using DAO;
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
    public partial class frmMain : Form
    {
        NguoiDung nd;
        public frmMain()
        {
            InitializeComponent();
            //var context = new ManageJobContext();
            //getAll(context);
        }
        #region Ham Bo Tro
        private void getAll(ManageJobContext context)
        {            
            NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "thanh@gmail.com", tenND = "Thanh nè" });
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "ly@gmail.com", tenND = "Lý lanh lợi" });
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "long@gmail.com", tenND = "Rồng nhưng xoay" });
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "khoa@gmail.com", tenND = "Mine C à mà thôi" });

            ChuDeBUS chuDeBUS = new ChuDeBUS();
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "thanh@gmail.com", ten = "mặc định" });//1
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "ly@gmail.com", ten = "Thể thao" });//2
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", ten = "E sờ pọt" });//3
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "thanh@gmail.com", ten = "Học tập" });//4
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "long@gmail.com", ten = "Cho nhiều lần 1" });//5
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "long@gmail.com", ten = "Cho nhiều lần 2" });//6

            CongViecBUS congViecBUS = new CongViecBUS();
            congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Mặc định 1", IDChuDe = 1, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0  });
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Mặc định 2", IDChuDe = 1, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0});
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Cưới ai", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0});
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Ăn cưới ", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0});
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Ăn cưới ai ", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0});
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Thể thao", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0});
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "làm tí mine", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0});
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Liên quân xíu", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0 });
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "code đê", IDChuDe = 5, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0, mucDo = 0 });
             congViecBUS.Insert( new DAO.Model.CongViec() { ten = "Học lập trình nà", IDChuDe = 5, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.MaxValue, trangThai = 0, tienDo = 0 });

            // chi tiet cong viec
            ChiTietCVBUS chiTietCVBUS = new ChiTietCVBUS();
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Học ", iDCongviec = 1, trangThai = 0,  mucDo = 0 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Chơi ", iDCongviec = 1, trangThai = 0,  mucDo = 4, iDChiTietCV = 0 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "chuẩn bị", iDCongviec = 2, trangThai = 0,  mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tiền", iDCongviec = 3, trangThai = 0,  mucDo = 4 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Cưới", iDCongviec = 3, trangThai = 0,  mucDo = 3 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "100 kim cương ", iDCongviec = 7, trangThai = 0,  mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "1000 sắt ", iDCongviec = 7, trangThai = 0,  mucDo = 2, iDChiTietCV = 6 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Thách đâu thoaiii", iDCongviec = 8, trangThai = 0, mucDo = 1 });
        }

        private void LoadData()
        {
            nd = Extension.LoadSetting(Properties.Settings.Default.email, Properties.Settings.Default.emailDefault);

            ChuDeBUS chuDeBUS = new ChuDeBUS();
            chuDeBUS.GetChuDe(ref tvwChuDe, nd);
        }
        #endregion

        #region Su Kien
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadData();          
        }        

        private void tvwChuDe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CongViecBUS congViecBus = new CongViecBUS();          
            if((e.Node.Tag as ChuDe).iD == 0)
                congViecBus.GetCongViec(ref tvwDSCongViec, congViecBus.GetCongViecByNguoiDung(nd));
            else
                congViecBus.GetCongViec(ref tvwDSCongViec, congViecBus.GetCongViecByChuDe(e.Node.Tag as ChuDe));
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            frmThemCVCT frm = new frmThemCVCT();
            frm.ShowDialog();
        }

        private void btnThemChuDe_Click(object sender, EventArgs e)
        {
            frmThemChuDe frm = new frmThemChuDe();
            frm.ShowDialog();
        }
        #endregion
    }
}
