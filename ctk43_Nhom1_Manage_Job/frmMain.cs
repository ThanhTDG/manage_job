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
    public partial class frmMain : Form
    {
        NguoiDung nd;
        ChuDeBUS chuDeBUS;
        CongViecBUS congViecBUS;
        GhiChuNhanhBUS ghiChuNhanhBUS;
        List<CongViec> cvs;
        ChuDe chuDeHienTai = null;
        int TabHienTai = 0;
        ChiTietCVBUS chiTietCVBUS;

        public frmMain()
        {
            InitializeComponent();
            getAll();
        }
        #region Ham Bo Tro
        private void getAll()
        {
            NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "default@gmail.com", tenND = "default" });
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "thanh@gmail.com", tenND = "Thanh" });
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "ly@gmail.com", tenND = "Lý" });
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "long@gmail.com", tenND = "Long" });
            nguoiDungBUS.Insert(new DAO.Model.NguoiDung() { email = "khoa@gmail.com", tenND = "Khoa" });

            ChuDeBUS chuDeBUS = new ChuDeBUS();
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "thanh@gmail.com", ten = "Mặc định 1" });//1
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "ly@gmail.com", ten = "Thể thao" });//2
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", ten = "Học tập" });//3
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "thanh@gmail.com", ten = "Esport" });//4
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "long@gmail.com", ten = "Nấu ăn" });//5
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "long@gmail.com", ten = "Du lịch" });//6

            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", ten = "Thể thao" });//7
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", ten = "Du lịch" });//8
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", ten = "Săn bắt" });//9
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", ten = "Hóng chuyện" });//10
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", ten = "Giải trí" });//11

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

            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đá bóng", IDChuDe = 7, thoiGianBD = DateTime.Now.AddDays(-2), thoiGianKT = DateTime.Now.AddDays(3), trangThai = 0, tienDo = 0, mucDo = 2 });//10
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Bóng rổ", IDChuDe = 7, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now.AddDays(5), trangThai = 0, tienDo = 0, mucDo = 1 });//11
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Cầu lông", IDChuDe = 7, thoiGianBD = DateTime.Now.AddDays(-1), thoiGianKT = DateTime.Now.AddDays(3), trangThai = 0, tienDo = 0, mucDo = 3 });//12
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Bóng chuyển", IDChuDe = 7, thoiGianBD = DateTime.Now.AddDays(-1), thoiGianKT = DateTime.Now.AddDays(2), trangThai = 0, tienDo = 0, mucDo = 0 });//13

            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Sapa", IDChuDe = 8, thoiGianBD = DateTime.Now.AddDays(-40), thoiGianKT = DateTime.Now.AddDays(-20), trangThai = 0, tienDo = 0, mucDo = 2 });//14
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Alaska", IDChuDe = 8, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now.AddDays(10), trangThai = 0, tienDo = 0, mucDo = 0 });//15
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Vũng Tàu", IDChuDe = 8, thoiGianBD = DateTime.Now.AddDays(50), thoiGianKT = DateTime.Now.AddDays(60), trangThai = 0, tienDo = 0, mucDo = 1 });//16
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Vịnh Hạ Long", IDChuDe = 8, thoiGianBD = DateTime.Now.AddDays(30), thoiGianKT = DateTime.Now.AddDays(50), trangThai = 0, tienDo = 0, mucDo = 4 });//17


            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Chơi game", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-25), thoiGianKT = DateTime.Now, trangThai = 0, tienDo = 0, mucDo = 0 });//18
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Xem tivi", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-30), thoiGianKT = DateTime.Now.AddDays(-5), trangThai = 0, tienDo = 0, mucDo = 0 });//19
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đọc truyện", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-20), thoiGianKT = DateTime.Now.AddDays(10), trangThai = 0, tienDo = 0, mucDo = 0 });//20
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đọc truyện tập 2", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-10), thoiGianKT = DateTime.Now.AddDays(10), trangThai = 0, tienDo = 0 });//21

            // chi tiet cong viec
            ChiTietCVBUS chiTietCVBUS = new ChiTietCVBUS();
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Học ", iDCongviec = 1, trangThai = 0, mucDo = 0 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Chơi ", iDCongviec = 1, trangThai = 0, mucDo = 4, iDChiTietCV = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "chuẩn bị", iDCongviec = 2, trangThai = 0, mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tiền", iDCongviec = 3, trangThai = 0, mucDo = 4 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Cưới", iDCongviec = 3, trangThai = 0, mucDo = 3 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "100 kim cương ", iDCongviec = 7, trangThai = 0, mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "1000 sắt ", iDCongviec = 7, trangThai = 0, mucDo = 2, iDChiTietCV = 6 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Thách đâu thoaiii", iDCongviec = 8, trangThai = 0, mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Bơm bóng", iDCongviec = 10, trangThai = 0, mucDo = 2 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Mua bóng cũ ", iDCongviec = 10, trangThai = 0, mucDo = 1, iDChiTietCV = 9 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Mua đồ đá bóng ", iDCongviec = 10, trangThai = 0, mucDo = 3, iDChiTietCV = 9 });

            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Đọc 10 trang đầu", iDCongviec = 21, trangThai = 0, mucDo = 1 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Đọc 10 trang giữa", iDCongviec = 21, trangThai = 0, mucDo = 0, iDChiTietCV = 12 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Đọc 10 trang cuối", iDCongviec = 21, trangThai = 0, mucDo = 0, iDChiTietCV = 12 });

            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Mua đồ dùng cá nhân", iDCongviec = 17, trangThai = 0, mucDo = 2 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Chuẩn bị quần áo", iDCongviec = 17, trangThai = 0, mucDo = 2 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Xếp đồ vào vali", iDCongviec = 17, trangThai = 0, mucDo = 2 });
        }

        private void CapNhatTienDo(TreeNode treeNode)
        {
            var cv = treeNode.Parent.Tag as CongViec;
            cv = congViecBUS.GetCongViecByID(cv.iD);
            cv.tienDo = chiTietCVBUS.Process(cv);
            cv.trangThai = cv.tienDo == 100 ? 1 : 0;
            congViecBUS.Update(cv);
        }


        private void CapNhatTienDo(int iD)
        {
            var cv = congViecBUS.GetCongViecByID(iD);
            cv.tienDo = chiTietCVBUS.Process(cv);
            cv.trangThai = cv.tienDo == 100 ? 1 : 0;
            congViecBUS.Update(cv);
        }
        private void UpdateStateJob(CongViec x, int s)
        {
            x.trangThai = s;
            foreach (var ctcv in chiTietCVBUS.GetChiTietByCongViec(x).ToList())
            {
                ctcv.trangThai = s;
                chiTietCVBUS.Update(ctcv);
            }
        }

        private void CheckCTCV(TreeNode treeNode)
        {
            bool check = false;
            if (treeNode.Level == 0)
            {
                var cv = treeNode.Tag as CongViec;
                if (cv == null) return;
                if (treeNode.Checked)
                {
                    UpdateStateJob(cv, 1);
                    check = true;
                }
                else
                {
                    UpdateStateJob(cv, 0);
                    check = true;
                }
                if (check)
                {
                    CapNhatTienDo(cv.iD);
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
            }
            if (treeNode.Level == 1)
            {
                var x = treeNode.Tag as ChiTietCV;
                if (x == null) return;
                x = chiTietCVBUS.GetChiTietCongViecByID(x.iD);
                if (treeNode.Checked)
                {
                    x.trangThai = 1;
                    chiTietCVBUS.Update(x);
                    check = true;
                }
                else
                {
                    x.trangThai = 0;
                    chiTietCVBUS.Update(x);
                    check = true;
                }
                if (check == true)
                {
                    CapNhatTienDo(treeNode);
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
            }
        }


        private void LoadData()
        {
            //    getAll();
            nd = Extension.LoadSetting(Properties.Settings.Default.email, Properties.Settings.Default.emailDefault);
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            ghiChuNhanhBUS = new GhiChuNhanhBUS();
            chiTietCVBUS = new ChiTietCVBUS();
            cvs = new List<CongViec>();
            LoadChuDe();
            SetUPSearchInputText();
            lbChucNang.LostFocus += XoaChonChucNang;
            LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
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
            LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
        }

        private void RemovePlaceHolder(object sender, EventArgs e)
        {
            if (txtTimKiemTenCV.Text == ThongBao.PlaceHolderText)
                txtTimKiemTenCV.Text = "";
        }

        private void LoadGhiChuNhanh(List<GhiChuNhanh> dsGhiChu)
        {
            lvDSGhiChu.Items.Clear();
            foreach (var gc in dsGhiChu)
            {
                ListViewItem item = new ListViewItem(gc.TieuDe);
                item.Tag = gc;
                lvDSGhiChu.Items.Add(item);
            }
        }
        #endregion

        #region Su Kien
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadData();
            frmThongBao frm = new frmThongBao();
            frm.ShowDialog();
        }

        private void tvwChuDe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            congViecBUS = new CongViecBUS();
            chuDeHienTai = e.Node.Tag as ChuDe;
            grbDSCongViec.Text = "Danh sách công việc theo " + chuDeHienTai.ten;
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
            chuDeBUS = new ChuDeBUS();
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
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            TreeNode treeNode = tvwDSCongViec.SelectedNode;
            if (treeNode == null) return;
            if (treeNode.Level == 0)
            {
                var cv = treeNode.Tag as CongViec;
                frmCongViec frm = new frmCongViec(cv);
                frm.LoadChuDe(nd);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    chuDeHienTai = chuDeBUS.GetChuDeByID(frm._congviec.IDChuDe);
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
            }
            else if (treeNode.Level == 1)
            {
                var chiTietCV = tvwDSCongViec.SelectedNode.Tag as ChiTietCV;
                frmChiTietCV frm = new frmChiTietCV(chiTietCV);
                frm.LoadCV(cvs);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CapNhatTienDo(treeNode);
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
            if (tvwDSCongViec.SelectedNode == null) return;
            if (tvwDSCongViec.SelectedNode.Checked == true)
                tvwDSCongViec.SelectedNode.Checked = false;
            else
                tvwDSCongViec.SelectedNode.Checked = true;
            var select = tvwDSCongViec.SelectedNode;
            if (select == null) return;
            CheckCTCV(tvwDSCongViec.SelectedNode);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietCV frm = new frmChiTietCV();
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            frm.LoadCV(cvs);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CapNhatTienDo(frm._chiTietCV.iDCongviec);
                congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
            }
        }


        private void txtTimKiemTenCV_TextChanged(object sender, EventArgs e)
        {
            if (TabHienTai == 0)
            {
                IEnumerable<CongViec> kq = congViecBUS.GetCongViecByTenCV(txtTimKiemTenCV.Text, chuDeHienTai, nd);
                congViecBUS.GetCongViec(ref tvwDSCongViec, kq.ToList());
            }
            else
            {
                IEnumerable<GhiChuNhanh> kq = ghiChuNhanhBUS.GetGhiChuNhanhByTen(txtTimKiemTenCV.Text, nd);
                LoadGhiChuNhanh(kq.ToList());
            }
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
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
                rtxtNoiDungGhiChu.Text = "";
            }
        }

        private void ctmSetting_Click(object sender, EventArgs e)
        {
            frmThietLap frmThietLap = new frmThietLap();
            frmThietLap.ShowDialog();
        }


        private void tvwDSCongViec_DoubleClick(object sender, EventArgs e)
        {
            if (tvwDSCongViec.SelectedNode.Level == 0)
            {
                var cv = tvwDSCongViec.SelectedNode.Tag as CongViec;
                frmDSChiTiet frm = new frmDSChiTiet(cv);
                frm.ShowDialog();
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            frmLoc frmLoc = new frmLoc();
            frmLoc.ShowDialog();
            congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetByLoc(nd).ToList());
        }

        private void lvDSGhiChu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvDSGhiChu.SelectedItems.Count;

            if (count == 1)
            {
                var gc = lvDSGhiChu.SelectedItems[0].Tag as GhiChuNhanh;
                rtxtNoiDungGhiChu.Text = gc.NoiDung;
            }
            else
                rtxtNoiDungGhiChu.Text = "";
        }

        private void lvDSGhiChu_DoubleClick(object sender, EventArgs e)
        {
            int count = lvDSGhiChu.SelectedItems.Count;

            if (count > 0)
            {
                var gc = lvDSGhiChu.SelectedItems[0].Tag as GhiChuNhanh;
                frmGhiChu frm = new frmGhiChu(gc.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ghiChuNhanhBUS = new GhiChuNhanhBUS();
                    LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
                    rtxtNoiDungGhiChu.Text = "";
                }
            }
        }

        private void XoaGhiChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvDSGhiChu.SelectedItems.Count;

            if (count > 0)
            {
                if (ThongBao.CauHoi("Xóa ghi chú nhanh không?") == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lvDSGhiChu.SelectedItems)
                    {
                        ghiChuNhanhBUS.DeleteByID((item.Tag as GhiChuNhanh).id);
                    }
                    LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
                    rtxtNoiDungGhiChu.Text = "";
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabHienTai = tabControl.SelectedIndex;
        }

        private void ReloadDSGhiChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
        }
        private void tsmiThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmThongBao frm = new frmThongBao();
            frm.Show();
        }

        #endregion

    }
}