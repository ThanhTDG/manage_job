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
        ChuDeBUS chuDeBUS;
        CongViecBUS congViecBUS;
        List<CongViec> cvs;
        ChuDe chuDeHienTai = null;

        public frmMain()
        {
            InitializeComponent();
        }
        #region Ham Bo Tro
        private void getAll()
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
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Mặc định 1", IDChuDe = 1, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Mặc định 2", IDChuDe = 1, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Cưới ai", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Ăn cưới ", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Ăn cưới ai ", IDChuDe = 2, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Thể thao", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "làm tí mine", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Liên quân xíu", IDChuDe = 4, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "code đê", IDChuDe = 5, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Học lập trình nà", IDChuDe = 5, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0 });

            // chi tiet cong viec
            ChiTietCVBUS chiTietCVBUS = new ChiTietCVBUS();
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Học ", iDCongviec = 1, trangThai = 0, mucDo = 0 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Chơi ", iDCongviec = 1, trangThai = 0, mucDo = 4, iDChiTietCV = 0 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "chuẩn bị", iDCongviec = 2, trangThai = 0, mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tiền", iDCongviec = 3, trangThai = 0, mucDo = 4 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Cưới", iDCongviec = 3, trangThai = 0, mucDo = 3 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "100 kim cương ", iDCongviec = 7, trangThai = 0, mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "1000 sắt ", iDCongviec = 7, trangThai = 0, mucDo = 2, iDChiTietCV = 6 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Thách đâu thoaiii", iDCongviec = 8, trangThai = 0, mucDo = 1 });
        }

        private void LoadData()
        {
        //    getAll();
            nd = Extension.LoadSetting(Properties.Settings.Default.email, Properties.Settings.Default.emailDefault);
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            cvs = new List<CongViec>();
            LoadChuDe();
            SetUPSearchInputText();
            lbChucNang.LostFocus += XoaChonChucNang;
        }

        private void XoaChonChucNang(object sender, EventArgs e)
        {
            lbChucNang.SelectedIndex = -1;
        }

        private void LoadChuDe()
        {
            chuDeBUS.GetChuDe(ref tvwChuDe, nd);
        }

        private void SetUPSearchInputText()
        {
            txtTimKiemTenCV.Text = ThongBao.PlaceHolderText;
            txtTimKiemTenCV.GotFocus += RemovePlaceHolder;
            txtTimKiemTenCV.LostFocus += ShowPlaceHolder;
        }

        private void ShowPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemTenCV.Text))
                txtTimKiemTenCV.Text = ThongBao.PlaceHolderText;
        }

        private void RemovePlaceHolder(object sender, EventArgs e)
        {
            if (txtTimKiemTenCV.Text == ThongBao.PlaceHolderText)
                txtTimKiemTenCV.Text = "";
        }
        #endregion

        #region Su Kien
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tvwChuDe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            congViecBUS = new CongViecBUS();
            chuDeHienTai = e.Node.Tag as ChuDe;
            if (chuDeHienTai.iD == 0)
                cvs = congViecBUS.GetCongViecByNguoiDung(nd).ToList();
            else
            {
                cvs = congViecBUS.GetCongViecByChuDe(chuDeHienTai);
            }
            congViecBUS.GetCongViec(ref tvwDSCongViec, cvs);
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            frmCongViec frm = new frmCongViec();
            frm.LoadChuDe(nd);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                chuDeHienTai = chuDeBUS.GetChuDeByID(frm._congviec.IDChuDe);
                congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
            }
        }

        private void btnThemChuDe_Click(object sender, EventArgs e)
        {
            frmThemChuDe frm = new frmThemChuDe();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadChuDe();
            }
        }

        private void SuaChuDeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var chuDe = tvwChuDe.SelectedNode.Tag as ChuDe;
            if (chuDe.iD == 0)
                return;
            frmThemChuDe frm = new frmThemChuDe(chuDe);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadChuDe();
            }
        }

        private void XoaChuDeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var node = tvwChuDe.SelectedNode.Tag as ChuDe;

            if (node.iD == 0)
                return;

            ChuDe chuDeDelete = chuDeBUS.GetChuDeByID(node.iD);                           
            if (ThongBao.CauHoi("xóa, mọi công việc liên quan đến chủ đề đều bị xóa!") == DialogResult.Yes)
            {
                chuDeBUS.Delete(chuDeDelete);
                LoadChuDe();
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvwDSCongViec.SelectedNode.Level == 0)
            {
                var cv = tvwDSCongViec.SelectedNode.Tag as CongViec;
                frmCongViec frm = new frmCongViec(cv);
                frm.LoadChuDe(nd);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    chuDeHienTai = chuDeBUS.GetChuDeByID(frm._congviec.IDChuDe);
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
            }
            else if (tvwDSCongViec.SelectedNode.Level == 1)
            {
                var chiTietCV = tvwDSCongViec.SelectedNode.Tag as ChiTietCV;
                frmChiTietCV frm = new frmChiTietCV(chiTietCV);
                frm.LoadCV(cvs);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvwDSCongViec.SelectedNode.Level == 0)
            {
                var cv = tvwDSCongViec.SelectedNode.Tag as CongViec;
                if (ThongBao.CauHoi($"xóa {cv.ten} chưa?") == DialogResult.Yes)
                {
                    congViecBUS.Delete(cv);
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
            }
            else if (tvwDSCongViec.SelectedNode.Level == 1)
            {
                var cv = tvwDSCongViec.SelectedNode.Tag as ChiTietCV;
                if (ThongBao.CauHoi($"xoá {cv.ten} chưa?") == DialogResult.Yes)
                {
                    congViecBUS.chiTietCVBus.Delete(cv);
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
            }
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietCV frm = new frmChiTietCV();
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            frm.LoadCV(cvs);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
            }
        }
        #endregion

        private void txtTimKiemTenCV_TextChanged(object sender, EventArgs e)
        {            
            IEnumerable<CongViec> kq = congViecBUS.GetCongViecByTenCV(txtTimKiemTenCV.Text, chuDeHienTai, nd);
            congViecBUS.GetCongViec(ref tvwDSCongViec, kq.ToList());
        }

        private void lbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chucNang = lbChucNang.SelectedIndex;
            switch (chucNang)
            {
                case 0:
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByDay(DateTime.Now, chuDeHienTai, nd).ToList());
                    break;
                case 1:
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByDay(DateTime.Now.AddDays(1), chuDeHienTai, nd).ToList());
                    break;
                case 2:
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByImportant(DateTime.Now, chuDeHienTai, nd).ToList());
                    break;
            }
        }

        private void GhiChutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGhiChu frm = new frmGhiChu();
            frm.Show();
        }

        private void ctmSetting_Click(object sender, EventArgs e)
        {
            frmThietLap frmThietLap = new frmThietLap();
            frmThietLap.ShowDialog();
        }
    }
}
