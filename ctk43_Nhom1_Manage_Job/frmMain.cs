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
using System.Threading;
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

        sort SortCV = sort.GiamTheoMucDo;
        sort SortGC = sort.GiamTheoTG;

        public frmMain()
        {
            InitializeComponent();
            // getAll();
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
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "thanh@gmail.com", loaiChuDe = 0, ten = "Mặc định 1" });//1
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "ly@gmail.com", loaiChuDe = 0, ten = "Thể thao" });//2
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", loaiChuDe = 0, ten = "Học tập" });//3
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "thanh@gmail.com", loaiChuDe = 0, ten = "Esport" });//4
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "long@gmail.com", loaiChuDe = 0, ten = "Nấu ăn" });//5
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "long@gmail.com", loaiChuDe = 0, ten = "Du lịch" });//6

            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", loaiChuDe = 0, ten = "Thể thao" });//7
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", loaiChuDe = 0, ten = "Du lịch" });//8
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", loaiChuDe = 0, ten = "Săn bắt" });//9
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", loaiChuDe = 0, ten = "Hóng chuyện" });//10
            chuDeBUS.Insert(new DAO.Model.ChuDe { Email = "khoa@gmail.com", loaiChuDe = 0, ten = "Giải trí" });//11

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

            //Ghi chu nhanh
            GhiChuNhanhBUS ghiChuNhanhBUS = new GhiChuNhanhBUS();
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 1", NoiDung = "Đây là nội dung của ghi chú nhanh 1", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 2", NoiDung = "Đây là nội dung của ghi chú nhanh 2", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 3", NoiDung = "Đây là nội dung của ghi chú nhanh 3", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 4", NoiDung = "Đây là nội dung của ghi chú nhanh 4", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
        }


        private void LoadSYCN()
        {
            while (true)
            {
                CongViecBUS congViecBUS = new CongViecBUS();
                List<CongViec> congViecAlmostOver;
                List<CongViec> congViecComingSoon;
                congViecComingSoon = congViecBUS.GetCongViecsCommingSoon(nd.email);
                congViecAlmostOver = congViecBUS.GetCongViecsAlmostOver(nd.email);
                if (congViecAlmostOver.Count() == 0 || congViecComingSoon.Count() == 0)
                {
                    break;
                }
                CongViec CVCommingsoon = Extension.GetcongViec(congViecComingSoon[0]);
                CongViec CVAlmostOver = Extension.GetcongViec(congViecAlmostOver[0]);
                if (DateTime.Now > CVAlmostOver.thoiGianKT || DateTime.Now < CVCommingsoon.thoiGianBD)
                {
                    if (DateTime.Now > CVAlmostOver.thoiGianKT)
                    {
                        CVAlmostOver.trangThai = 3;
                        congViecBUS.Update(CVAlmostOver);
                        continue;
                    }
                    CVCommingsoon.trangThai = 1;
                    congViecBUS.Update(CVCommingsoon);
                    continue;
                }
                TimeSpan Time_Comming = DateTime.Now - CVCommingsoon.thoiGianBD;
                TimeSpan Time_Over = CVAlmostOver.thoiGianKT - DateTime.Now;
                int commingSecond = Extension.TimeToSecond(Time_Comming.Days, Time_Comming.Hours, Time_Comming.Minutes, Time_Comming.Seconds);
                int overSecond = Extension.TimeToSecond(Time_Over.Days, Time_Over.Hours, Time_Over.Minutes, Time_Over.Seconds);
                List<CongViec> congViecsUpdate = new List<CongViec>();
                if (commingSecond == overSecond)
                {
                    if(commingSecond < 0)
                    {
                        continue;
                    }
                    CVAlmostOver = Extension.UpdateOver(CVAlmostOver, congViecBUS);
                    congViecsUpdate.Add(CVAlmostOver);
                    CVCommingsoon = Extension.UpdateComing(CVCommingsoon, congViecBUS);
                    congViecsUpdate.Add(CVCommingsoon);
                }
               if(commingSecond < overSecond)
                {
                    Extension.UpdateOver(CVAlmostOver, congViecBUS);
                    congViecsUpdate.Add(CVAlmostOver);
                }
                else
                {
                    Extension.UpdateComing(CVCommingsoon, congViecBUS);
                    congViecsUpdate.Add(CVCommingsoon);
                }
                if (congViecsUpdate.Count == 0)
                    continue;

            }
        }

        

        private void CapNhatHoanThanhOrNot(ref CongViec cv)
        {
            cv.tienDo = chiTietCVBUS.Process(cv);
            if (cv.tienDo == 100)
            {
                cv.ngayHoanThanh = DateTime.Now;
                cv.trangThai = Extension.typeStatusOfTheJob(cv.thoiGianBD, cv.thoiGianKT, 2);
            }
            else
            {
                cv.ngayHoanThanh = null;
                cv.trangThai = Extension.typeStatusOfTheJob(cv.thoiGianBD, cv.thoiGianKT);
            }
        }

        private void CapNhatTienDo(TreeNode treeNode)
        {
            var cv = treeNode.Parent.Tag as CongViec;
            cv = congViecBUS.GetCongViecByID(cv.iD);
            CapNhatHoanThanhOrNot(ref cv);
            congViecBUS.Update(cv);
        }

        private void CapNhatTienDo(int iD)
        {
            var cv = congViecBUS.GetCongViecByID(iD);
            CapNhatHoanThanhOrNot(ref cv);
            congViecBUS.Update(cv);
        }

        private void UpdateStateJob(CongViec x, int s)
        {
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
                cv = congViecBUS.GetCongViecByID(cv.iD);
                if (cv == null) return;
                if (treeNode.Checked)
                {
                    cv.ngayHoanThanh = DateTime.Now;
                    cv.tienDo = 100;
                    cv.trangThai = Extension.typeStatusOfTheJob(cv.thoiGianBD,cv.thoiGianKT,2);
                    UpdateStateJob(cv, 1);
                    check = true;
                }
                else
                {
                    cv.ngayHoanThanh = null;
                    cv.tienDo = 0;
                    cv.trangThai = Extension.typeStatusOfTheJob(cv.thoiGianBD, cv.thoiGianKT);
                    UpdateStateJob(cv, 0);
                    check = true;
                }
                if (check)
                {
                    congViecBUS.Update(cv);
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
            tvwChuDe.SelectedNode = tvwChuDe.Nodes[0];
            toolStripCbbCheDoSapXep.SelectedIndex = 0;           
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
                item.SubItems.Add(gc.ThoiGianBD.ToShortDateString());
                item.Tag = gc;
                lvDSGhiChu.Items.Add(item);
            }
        }

        private void SortGhiChuNhanh()
        {
            List<GhiChuNhanh> gcs = ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList();
            gcs = ghiChuNhanhBUS.SortGhiChu(gcs, SortGC);
            LoadGhiChuNhanh(gcs);
        }

        private void LoadListCVHienTai()
        {
            cvs = (chuDeHienTai.iD == 0) ? congViecBUS.GetCongViecByNguoiDung(nd).ToList() : congViecBUS.GetCongViecByChuDe(chuDeHienTai).ToList();
            cvs = congViecBUS.SortCongViec(cvs, SortCV);
            congViecBUS.GetCongViec(ref tvwDSCongViec, cvs);
        }
        #endregion

        #region Su Kien
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadData();
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đá bóng", IDChuDe = 7, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now.AddMinutes(1), trangThai = 1, tienDo = 0, mucDo = 1 });//10
            Thread th = new Thread(new ThreadStart(LoadSYCN));
            th.IsBackground = true;
            th.Start();
            frmThongBao frm = new frmThongBao();
            frm.ShowDialog();

        }

        private void tvwChuDe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            congViecBUS = new CongViecBUS();
            chuDeHienTai = e.Node.Tag as ChuDe;
            grbDSCongViec.Text = "Danh sách công việc theo " + chuDeHienTai.ten;
            LoadListCVHienTai();            
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            frmCongViec frm = new frmCongViec();
            frm.LoadChuDe(nd);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //chuDeHienTai = chuDeBUS.GetChuDeByID(frm._congviec.IDChuDe);
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
                if (kq.Count() == 0)
                    return;
                congViecBUS.GetCongViec(ref tvwDSCongViec, kq.ToList());
            }
            else
            {
                IEnumerable<GhiChuNhanh> kq = ghiChuNhanhBUS.GetGhiChuNhanhByTen(txtTimKiemTenCV.Text, nd, ckbTimNgayGhiChu.Checked);                
                LoadGhiChuNhanh(kq.ToList());
            }
        }

        private void lbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chucNang = lbChucNang.SelectedIndex;
            switch (chucNang)
            {
                case 0:
                    cvs = congViecBUS.GetCongViecByDay(DateTime.Now, chuDeHienTai, nd).ToList();
                    break;
                case 1:
                    cvs = congViecBUS.GetCongViecByDay(DateTime.Now.AddDays(1), chuDeHienTai, nd).ToList();
                    break;
                case 2:
                    cvs = congViecBUS.GetCongViecByImportant(DateTime.Now, chuDeHienTai, nd).ToList();
                    break;
                case 3:
                    cvs = congViecBUS.GetCongViecByLoaiChuDe(DefineLoaiChuDe.getInt("Hàng ngày"), nd).ToList();
                    break;
                case 4:
                    cvs = congViecBUS.GetCongViecByLoaiChuDe(DefineLoaiChuDe.getInt("Hàng tuần"), nd).ToList();
                    break;
                case 5:
                    cvs = congViecBUS.GetCongViecByLoaiChuDe(DefineLoaiChuDe.getInt("Hàng tháng"), nd).ToList();
                    break;
                case 6:
                    cvs = congViecBUS.GetCongViecByLoaiChuDe(DefineLoaiChuDe.getInt("Hàng năm"), nd).ToList();
                    break;
            }
            cvs = congViecBUS.SortCongViec(cvs, SortCV);
            congViecBUS.GetCongViec(ref tvwDSCongViec, cvs);
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
            if (tvwDSCongViec.SelectedNode == null) return;
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
            if (tabControl.SelectedIndex == 0)
            {
                ckbTimNgayGhiChu.Visible = false;
                GCMenuParentToolStripMenuItem.Enabled = false;
                CVMenuParentToolStripMenuItem.Enabled = true;
                lbChucNang.Enabled = true;
                tvwChuDe.Enabled = true;
            }                
            else
            {
                ckbTimNgayGhiChu.Visible = true;
                CVMenuParentToolStripMenuItem.Enabled = false;
                GCMenuParentToolStripMenuItem.Enabled = true;
                lbChucNang.Enabled = false;
                tvwChuDe.Enabled = false;
            }                

            TabHienTai = tabControl.SelectedIndex;
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

        private void tvwDSCongViec_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (tvwDSCongViec.SelectedNode == null) return;
            //if (tvwDSCongViec.SelectedNode.Checked == true)
            //    tvwDSCongViec.SelectedNode.Checked = false;
            //else
            //    tvwDSCongViec.SelectedNode.Checked = true;
            //var select = tvwDSCongViec.SelectedNode;
            //if (select == null) return;
            //CheckCTCV(tvwDSCongViec.SelectedNode);
        }

        #endregion

        private void tvwDSCongViec_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                //CheckCTCV(e.Node);
                var x = e.Node.Tag as CongViec;
                MessageBox.Show(x.ten);
            }
        }

        private void tvwDSCongViec_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                //CheckCTCV(e.Node);
                var x = e.Node.Tag as CongViec;
                MessageBox.Show(x.ten);
            }
        }

        private void OpenGhiChuDSGhiChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.RestoreDirectory = true;
            dlg.Title = "Chọn ghi chú có sẵn";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                frmGhiChu frm = new frmGhiChu();
                frm.MoGhiChuCoSan(dlg.FileName);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
                    rtxtNoiDungGhiChu.Text = "";
                }; 
            }
        }

        private void SortByDateCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SortByMucDoCVToolStripMenuItem.Checked)
                SortByMucDoCVToolStripMenuItem.Checked = false;

            if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                SortCV = sort.TangTheoTG;
            else
                SortCV = sort.GiamTheoTG;

            SortByDateCVToolStripMenuItem.Checked = true;

            LoadListCVHienTai();
        }

        private void SortByMucDoCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SortByDateCVToolStripMenuItem.Checked)
                SortByDateCVToolStripMenuItem.Checked = false;

            if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                SortCV = sort.TangTheoMucDo;
            else
                SortCV = sort.GiamTheoMucDo;

            SortByMucDoCVToolStripMenuItem.Checked = true;

            LoadListCVHienTai();
        }

        private void SapXeptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabHienTai == 0)
            {
                if (SortCV == sort.TangTheoMucDo || SortCV == sort.TangTheoTG)
                    toolStripCbbCheDoSapXep.SelectedIndex = 0;
                else
                    toolStripCbbCheDoSapXep.SelectedIndex = 1;
            }
            else
            {
                if (SortGC == sort.TangTheoTen || SortGC == sort.TangTheoTG)
                    toolStripCbbCheDoSapXep.SelectedIndex = 0;
                else
                    toolStripCbbCheDoSapXep.SelectedIndex = 1;
            }            
        }

        private void SortByTenGCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SortByDateGCToolStripMenuItem.Checked)
                SortByDateGCToolStripMenuItem.Checked = false;

            if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                SortGC = sort.TangTheoTen;
            else
                SortGC = sort.GiamTheoTen;

            SortByTenGCToolStripMenuItem.Checked = true;

            SortGhiChuNhanh();
        }

        private void SortByDateGCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SortByTenGCToolStripMenuItem.Checked)
                SortByTenGCToolStripMenuItem.Checked = false;

            if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                SortGC = sort.TangTheoTG;
            else
                SortGC = sort.GiamTheoTG;

            SortByDateGCToolStripMenuItem.Checked = true;

            SortGhiChuNhanh();
        }

        private void toolStripCbbCheDoSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabHienTai == 0)
            {               
                if (SortByDateCVToolStripMenuItem.Checked)
                {
                    if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                        SortCV = sort.TangTheoTG;
                    else
                        SortCV = sort.GiamTheoTG;
                }
                if (SortByMucDoCVToolStripMenuItem.Checked)
                {
                    if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                        SortCV = sort.TangTheoMucDo;
                    else
                        SortCV = sort.GiamTheoMucDo;
                }
                LoadListCVHienTai();
            }
            else
            {
                if (SortByDateGCToolStripMenuItem.Checked)
                {
                    if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                        SortGC = sort.TangTheoTG;
                    else
                        SortGC = sort.GiamTheoTG;
                }
                if (SortByTenGCToolStripMenuItem.Checked)
                {
                    if (toolStripCbbCheDoSapXep.SelectedIndex == 0)
                        SortGC = sort.TangTheoTen;
                    else
                        SortGC = sort.GiamTheoTen;
                }
                SortGhiChuNhanh();
            }
        }
    }
}