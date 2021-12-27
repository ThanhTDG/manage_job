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
        private Thread th;
        string TrangThaiHT = null;


        sort SortCV = sort.GiamTheoMucDo;
        sort SortGC = sort.GiamTheoTG;
        public frmMain()
        {
            InitializeComponent();
            //getAll();
        }

        #region 1911205 - Nguyễn hữu Đức Thanh
        /// <summary>
        /// frmLoc
        /// frmThiepLap
        /// frmThongBaoCV
        /// </summary>
        public void nofiction()
        {
            while (true)
            {
                CongViecBUS CongViecBUS = new CongViecBUS();
                List<CongViec> congViecComingSoon;
                List<CongViec> congViecAlmostOver;

                congViecAlmostOver = CongViecBUS.GetCongViecsAlmostOver(nd.email);
                int i = 0, j = 0;
                congViecComingSoon = CongViecBUS.GetCongViecsCommingSoon(nd.email);
                if (congViecComingSoon.Count() == 0 && congViecAlmostOver.Count() == 0)
                {
                    break;
                }
                if (congViecAlmostOver.Count != 0)
                    while (DateTime.Now > congViecAlmostOver[i].thoiGianKT && congViecAlmostOver.Count - 1 > i)
                    {
                        CongViec congViec = Extension.GetcongViec(congViecAlmostOver[i]);
                        Extension.Update(congViec, CongViecBUS);
                        i++;
                    }
                if (congViecComingSoon.Count != 0)
                    while (DateTime.Now > congViecComingSoon[j].thoiGianBD && congViecComingSoon.Count - 1 > j)
                    {
                        CongViec congViec = Extension.GetcongViec(congViecComingSoon[j]);
                        Extension.Update(congViec, CongViecBUS);
                        j++;
                    }
                if (i != 0 && j != 0)
                    continue;
                List<CongViec> temp = new List<CongViec>();
                congViecAlmostOver = getListOver(congViecAlmostOver);
                congViecComingSoon = getListComming(congViecComingSoon);
                int Second ;
              
                if (congViecAlmostOver.Count != 0 && congViecComingSoon.Count != 0)
                {
                    TimeSpan Comming = congViecComingSoon[0].thoiGianBD - DateTime.Now;
                    TimeSpan Over = congViecAlmostOver[0].thoiGianKT - DateTime.Now;
                    if (Comming.Days > 7 && Over.Days > 7)
                        break;
                    if (Over > Comming)
                    {
                        if (Comming >= TimeSpan.Zero)
                        {
                            Second = Extension.TimeToSecond(Comming.Days, Comming.Hours, Comming.Minutes, Comming.Seconds);
                            temp = congViecComingSoon;
                        }
                        else
                        {

                            Second = Extension.TimeToSecond(Over.Days, Over.Hours, Over.Minutes, Over.Seconds);
                            temp = congViecAlmostOver;
                        }
                    }
                    else if (Over < Comming)
                    {
                        if (Over >= TimeSpan.Zero)
                        {
                            Second = Extension.TimeToSecond(Over.Days, Over.Hours, Over.Minutes, Over.Seconds);
                            temp = congViecAlmostOver;
                        }
                        else
                        {
                            Second = Extension.TimeToSecond(Comming.Days, Comming.Hours, Comming.Minutes, Comming.Seconds);
                            temp = congViecComingSoon;
                        }
                    }
                    else
                    {
                        Second = Extension.TimeToSecond(Over.Days, Over.Hours, Over.Minutes, Over.Seconds);
                        temp = (List<CongViec>)temp.Concat(congViecAlmostOver).Concat(congViecComingSoon);
                    }
                }
                else
                {
                    if (congViecAlmostOver.Count != 0)
                    {
                        TimeSpan Over = congViecAlmostOver[0].thoiGianKT - DateTime.Now;
                        if (Over.Days > 7)
                            break;
                        Second = Extension.TimeToSecond(Over.Days, Over.Hours, Over.Minutes, Over.Seconds);
                        temp = congViecAlmostOver;
                    }
                    else
                    {
                        TimeSpan Comming = congViecComingSoon[0].thoiGianBD - DateTime.Now;
                        if (Comming.Days > 7)
                            break;
                        Second = Extension.TimeToSecond(Comming.Days, Comming.Hours, Comming.Minutes, Comming.Seconds);
                        temp = congViecComingSoon;
                    }
                }
                if (Second < 0)
                    continue;
                Thread.Sleep(Second * 1000 + 1000);
                for (i = 0; i < temp.Count; i++)
                    temp[i] = Extension.Update(temp[i], CongViecBUS);
                this.Invoke(new Action(() =>
                {
                    frmThongBaoCV frmThongBaoCV = new frmThongBaoCV(temp);
                    frmThongBaoCV.Show();
                }));
            }
        }

        private List<CongViec> getListOver(List<CongViec> congViecAlmostOver)
        {
            List<CongViec> temp = new List<CongViec>();
            congViecAlmostOver = congViecAlmostOver.FindAll(x => x.thoiGianKT == congViecAlmostOver[0].thoiGianKT).ToList();
            if (congViecAlmostOver.Count != 0)
            {
                foreach (var congviec in congViecAlmostOver)
                {
                    CongViec CVAlmostOver = new CongViec();
                    CVAlmostOver = Extension.GetcongViec(congviec);
                    temp.Add(CVAlmostOver);
                }
            }
            return temp;
        }

        private List<CongViec> getListComming(List<CongViec> congViecComingSoon)
        {
            List<CongViec> temp = new List<CongViec>();
            congViecComingSoon = congViecComingSoon.FindAll(x => x.thoiGianBD == congViecComingSoon[0].thoiGianBD).ToList();
            if (congViecComingSoon.Count != 0)
            {
                foreach (var congviec in congViecComingSoon)
                {
                    CongViec congViecComming = new CongViec();
                    congViecComming = Extension.GetcongViec(congviec);
                    temp.Add(congViecComming);
                }
            }
            return temp;
        }

        private void ctmSetting_Click(object sender, EventArgs e)
        {
            frmThietLap frmThietLap = new frmThietLap();
            frmThietLap.ShowDialog();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            frmLoc frmLoc = new frmLoc();
            if (frmLoc.ShowDialog() == DialogResult.OK)
            {
                cvs = congViecBUS.GetByLoc(nd).ToList();
                congViecBUS.GetCongViec(ref tvwDSCongViec, cvs);
            }

        }

        private void listenNotification()
        {
            if (th == null)
            {
                th = new Thread(nofiction);
                th.IsBackground = true;
                th.Start();
            }
            else if (th != null || th.ThreadState == ThreadState.Running)
            {
                th.Abort();
                th = null;
                th = new Thread(nofiction);
                th.IsBackground = true;
                th.Start();
            }

        }
        #endregion

        #region 1911164 Võ Đình Hoàng Long
        /// <summary>
        /// frmCongViec
        /// FrmChiTiet
        /// FrmDSChitiet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            frmCongViec frm = new frmCongViec();
            frm.LoadChuDe(nd);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm._congviec == null)
                {
                    LoadListCVHienTai();
                }
                else
                {
                    chuDeHienTai = chuDeBUS.GetChuDeByID(frm._congviec.IDChuDe);
                    congViecBUS.GetCongViec(ref tvwDSCongViec, congViecBUS.GetCongViecByChuDe(chuDeHienTai));
                }
                listenNotification();
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
            congViecBUS = new CongViecBUS();
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
                    cv.trangThai = Extension.typeStatusOfTheJob(cv.thoiGianBD, cv.thoiGianKT, 2);
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
                    listenNotification();
                    LoadListCVHienTai();
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
                    if (x.ThoiGianThucTe == null)
                        x.ThoiGianThucTe = 0;
                    chiTietCVBUS.Update(x);
                    check = true;
                }
                else
                {
                    x.ThoiGianThucTe = null;
                    x.trangThai = 0;
                    chiTietCVBUS.Update(x);
                    check = true;
                }
                if (check == true)
                {
                    CapNhatTienDo(treeNode);
                    listenNotification();
                    LoadListCVHienTai();
                }
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvwDSCongViec.SelectedNode == null) return;
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            TreeNode treeNode = tvwDSCongViec.SelectedNode;
            if (treeNode.Level == 0)
            {
                var cv = treeNode.Tag as CongViec;
                frmCongViec frm = new frmCongViec(cv);
                frm.LoadChuDe(nd);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    listenNotification();
                    LoadListCVHienTai();
                }
            }
            else if (treeNode.Level == 1)
            {
                var chiTietCV = tvwDSCongViec.SelectedNode.Tag as ChiTietCV;
                frmChiTietCV frm = new frmChiTietCV(chiTietCV);
                frm.LoadCV(treeNode.Parent.Tag as CongViec);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    listenNotification();
                    CapNhatTienDo(treeNode);
                    LoadListCVHienTai();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvwDSCongViec.SelectedNode == null) return;
            chuDeBUS = new ChuDeBUS();
            if (tvwDSCongViec.SelectedNode.Level == 0)
            {
                var cv = tvwDSCongViec.SelectedNode.Tag as CongViec;
                if (ThongBao.CauHoi($"xóa {cv.ten} chưa?") == DialogResult.Yes)
                {
                    int id = chuDeBUS.GetIDByNameChuDe(cv.ten);
                    if (id != -1)
                    {
                        chuDeBUS.Delete(id);
                        listenNotification();
                        LoadListCVHienTai();
                    }
                    else
                    {
                        congViecBUS.Delete(cv);
                        listenNotification();
                        LoadListCVHienTai();
                    }
                }
            }
            else if (tvwDSCongViec.SelectedNode.Level == 1)
            {
                var cv = tvwDSCongViec.SelectedNode.Tag as ChiTietCV;
                if (ThongBao.CauHoi($"xoá {cv.ten} chưa?") == DialogResult.Yes)
                {
                    congViecBUS.chiTietCVBus.Delete(cv);
                    LoadListCVHienTai();
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
            if (tvwDSCongViec.SelectedNode == null) return;
            CongViec cv = new CongViec();
            if (tvwDSCongViec.SelectedNode.Level == 0)
            {
                cv = tvwDSCongViec.SelectedNode.Tag as CongViec;
            }
            else
            {
                cv = tvwDSCongViec.SelectedNode.Parent.Tag as CongViec;
            }
            frmChiTietCV frm = new frmChiTietCV();
            congViecBUS = new CongViecBUS();
            chuDeBUS = new ChuDeBUS();
            frm.LoadCV(cv);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CapNhatTienDo(frm._chiTietCV.iDCongviec);
                LoadListCVHienTai();
            }
        }

        private void tvwDSCongViec_DoubleClick(object sender, EventArgs e)
        {
            if (tvwDSCongViec.SelectedNode == null) return;
            chiTietCVBUS = new ChiTietCVBUS();
            congViecBUS = new CongViecBUS();
            if (tvwDSCongViec.SelectedNode.Level == 0)
            {
                var cv = tvwDSCongViec.SelectedNode.Tag as CongViec;
                frmDSChiTiet frm = new frmDSChiTiet(cv);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CapNhatTienDo(cv.iD);
                    listenNotification();
                    LoadListCVHienTai();
                }
            }
        }

        private void ctxMenuDSCongViec_Opening(object sender, CancelEventArgs e)
        {
            if (tvwDSCongViec.SelectedNode == null) return;
            if (tvwDSCongViec.SelectedNode.Level == 0)
            {
                CongViec cv = tvwDSCongViec.SelectedNode.Tag as CongViec;
                if (cv.trangThai == 2 || cv.trangThai == 4)
                    markToolStripMenuItem.Text = "Bỏ đánh đấu hoàn thành";
                else
                    markToolStripMenuItem.Text = "Đánh đấu hoàn thành";
            }
            if (tvwDSCongViec.SelectedNode.Level == 1)
            {
                ChiTietCV ctcv = tvwDSCongViec.SelectedNode.Tag as ChiTietCV;
                if (ctcv.trangThai == 1)
                    markToolStripMenuItem.Text = "Bỏ đánh đấu hoàn thành";
                else
                    markToolStripMenuItem.Text = "Đánh đấu hoàn thành";
            }
        }

        #endregion

        #region 1911158- Nguyễn Hoàng Đăng Khoa
        /// <summary>
        /// frmGhiChu
        /// frmMain(Gần hết) 
        /// frmChuDe
        /// </summary>
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
            LoadListCVHienTai();
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

            if (lbChucNang.SelectedIndex == -1)
            {
                cvs = (chuDeHienTai.iD == 0) ? congViecBUS.GetCongViecByNguoiDung(nd).ToList() : congViecBUS.GetCongViecByChuDe(chuDeHienTai).ToList();
                if (TrangThaiHT != "Tất cả")
                    congViecBUS.GetCongViecByTrangThai(ref cvs, TrangThaiHT);
                cvs = congViecBUS.SortCongViec(cvs, SortCV);
                congViecBUS.GetCongViec(ref tvwDSCongViec, cvs);
            }
            else
                SetChucNang(lbChucNang.SelectedIndex);                       
        }

        private void SetChucNang(int ChucNang)
        {
            switch (ChucNang)
            {
                case 0:                     
                    cvs = congViecBUS.GetCongViecByDay(DateTime.Now, nd).ToList();
                    break;
                case 1:
                    cvs = congViecBUS.GetCongViecByDay(DateTime.Now.AddDays(1), nd).ToList();
                    break;
                case 2:
                    cvs = congViecBUS.GetCongViecByImportant(DateTime.Now, nd).ToList();
                    break;
                case 3:
                    cvs = congViecBUS.GetCongViecByLoai(DefineLoaiChuDe.getInt("Hàng ngày"), nd).ToList();
                    break;
                case 4:
                    cvs = congViecBUS.GetCongViecByLoai(DefineLoaiChuDe.getInt("Hàng tuần"), nd).ToList();
                    break;
                case 5:
                    cvs = congViecBUS.GetCongViecByLoai(DefineLoaiChuDe.getInt("Hàng tháng"), nd).ToList();
                    break;
                case 6:
                    cvs = congViecBUS.GetCongViecByLoai(DefineLoaiChuDe.getInt("Hàng năm"), nd).ToList();
                    break;
            }
            if (TrangThaiHT != "Tất cả")
                congViecBUS.GetCongViecByTrangThai(ref cvs, TrangThaiHT);
            cvs = congViecBUS.SortCongViec(cvs, SortCV);
            congViecBUS.GetCongViec(ref tvwDSCongViec, cvs);
        }

        private void SetUpCbbTrangThaiCV()
        {
            cbbTrangThaiCV.DataSource = DefineTrangThai.getListTrangThai();
            cbbTrangThaiCV.SelectedIndex = 1;
        }

        private void SetControlEnDis(bool status)
        {
            lbChucNang.Enabled = status;
            tvwChuDe.Enabled = status;
            btnThemChuDe.Enabled = status;
            btnThemCongViec.Enabled = status;
            cbbTrangThaiCV.Enabled = status;
        }

        private void tvwChuDe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbChucNang.SelectedIndex = -1;
            congViecBUS = new CongViecBUS();
            chuDeHienTai = e.Node.Tag as ChuDe;
            grbDSCongViec.Text = ThongBao.SetGroupBoxName(chuDeHienTai.ten);
            LoadListCVHienTai();
        }

        private void btnThemChuDe_Click(object sender, EventArgs e)
        {
            frmThemChuDe frm = new frmThemChuDe();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadChuDe();
                tvwChuDe.SelectedNode = tvwChuDe.Nodes[0];
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
                tvwChuDe.SelectedNode = tvwChuDe.Nodes[0];
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
                tvwChuDe.SelectedNode = tvwChuDe.Nodes[0];
            }
        }

        private void txtTimKiemTenCV_TextChanged(object sender, EventArgs e)
        {
            if (TabHienTai == 0)
            {
                IEnumerable<CongViec> kq = congViecBUS.GetCongViecByTenCV(txtTimKiemTenCV.Text, cvs);
                if (kq == null)
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
            SetChucNang(lbChucNang.SelectedIndex);
            if (lbChucNang.SelectedIndex != -1)
                grbDSCongViec.Text = ThongBao.SetGroupBoxName("Tất cả", lbChucNang.SelectedItem.ToString());
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
                SetControlEnDis(true);
            }
            else
            {
                ckbTimNgayGhiChu.Visible = true;
                CVMenuParentToolStripMenuItem.Enabled = false;
                GCMenuParentToolStripMenuItem.Enabled = true;
                SetControlEnDis(false);
            }

            TabHienTai = tabControl.SelectedIndex;
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

        private void cbbTrangThaiCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrangThaiHT = DefineTrangThai.GetString(cbbTrangThaiCV.SelectedIndex);
            LoadListCVHienTai();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.Alt == true && e.KeyCode == Keys.K)
            {
                btnThemCongViec.PerformClick();
            }

            if (e.Control == true && e.Alt == true && e.KeyCode == Keys.N)
            {
                GhiChutoolStripMenuItem.PerformClick();
            }

            if (e.Control == true && e.Alt == true && e.KeyCode == Keys.L)
            {
                btnThemChuDe.PerformClick();
            }
        }

        #endregion

        #region 1911166 - Võ Công Lý
        /// <summary>
        /// frmThongKe
        /// frmThongBao
        /// frmDangKy
        /// </summary>

        private void tsmiThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmThongBao frm = new frmThongBao();
            frm.ShowDialog();
        }

        #endregion

        #region Chung
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
            LoadGhiChuNhanh(ghiChuNhanhBUS.GetGhiChuByNguoiDung(nd).ToList());
            tvwChuDe.SelectedNode = tvwChuDe.Nodes[0];
            SetUpCbbTrangThaiCV();
            this.KeyPreview = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadData();
            frmThongBao frm = new frmThongBao();
            frm.ShowDialog();
            listenNotification();
        }

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

            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đá bóng", IDChuDe = 7, thoiGianBD = DateTime.Now.AddDays(-2), thoiGianKT = DateTime.Now.AddDays(3), trangThai = 1, tienDo = 0, mucDo = 2 });//11
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Bóng rổ", IDChuDe = 7, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now.AddDays(5), trangThai = 1, tienDo = 0, mucDo = 1 });//12
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Cầu lông", IDChuDe = 7, thoiGianBD = DateTime.Now.AddDays(-1), thoiGianKT = DateTime.Now.AddDays(3), trangThai = 1, tienDo = 0, mucDo = 3 });//13
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Bóng chuyển", IDChuDe = 7, thoiGianBD = DateTime.Now.AddDays(-1), thoiGianKT = DateTime.Now.AddDays(2), trangThai = 1, tienDo = 0, mucDo = 0 });//14

            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Sapa", IDChuDe = 8, thoiGianBD = DateTime.Now.AddDays(-40), thoiGianKT = DateTime.Now.AddDays(-20), trangThai = 3, tienDo = 0, mucDo = 2 });//15
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Alaska", IDChuDe = 8, thoiGianBD = DateTime.Now, thoiGianKT = DateTime.Now.AddDays(10), trangThai = 0, tienDo = 1, mucDo = 0 });//16
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Vũng Tàu", IDChuDe = 8, thoiGianBD = DateTime.Now.AddDays(50), thoiGianKT = DateTime.Now.AddDays(60), trangThai = 0, tienDo = 0, mucDo = 1 });//17
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đi Vịnh Hạ Long", IDChuDe = 8, thoiGianBD = DateTime.Now.AddDays(30), thoiGianKT = DateTime.Now.AddDays(50), trangThai = 0, tienDo = 0, mucDo = 4 });//18

            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Chơi game", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-25), thoiGianKT = DateTime.Now, trangThai = 3, tienDo = 0, mucDo = 0 });//19
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Xem tivi", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-30), thoiGianKT = DateTime.Now.AddDays(-5), trangThai = 3, tienDo = 0, mucDo = 0 });//20
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đọc truyện", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-20), thoiGianKT = DateTime.Now.AddDays(10), trangThai = 1, tienDo = 0, mucDo = 0 });//21
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Đọc truyện tập 2", IDChuDe = 11, thoiGianBD = DateTime.Now.AddDays(-10), thoiGianKT = DateTime.Now.AddDays(10), trangThai = 1, tienDo = 0 });//22

            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Làm bài tập lab 1 csdl", IDChuDe = 3, thoiGianBD = DateTime.Now.AddDays(-20), thoiGianKT = DateTime.Now.AddDays(-10), trangThai = 3, tienDo = 0, mucDo = 2 });//23
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Tạo một trang web bán hàng", IDChuDe = 3, thoiGianBD = DateTime.Now.AddDays(-10), thoiGianKT = DateTime.Now.AddDays(5), trangThai = 1, tienDo = 0, mucDo = 3 });//24
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Bài tập nhóm thi học kỳ csdl", IDChuDe = 3, thoiGianBD = DateTime.Now.AddDays(-7), thoiGianKT = DateTime.Now.AddDays(2), trangThai = 1, tienDo = 0, mucDo = 0 });//25
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Thi học kỳ môn công nghệ phần mềm", IDChuDe = 3, thoiGianBD = DateTime.Now.AddDays(7), thoiGianKT = DateTime.Now.AddDays(10), trangThai = 0, tienDo = 0, mucDo = 1 });//26
            congViecBUS.Insert(new DAO.Model.CongViec() { ten = "Nghiên cứu công nghệ mới", IDChuDe = 3, thoiGianBD = DateTime.Now.AddDays(10), thoiGianKT = DateTime.Now.AddDays(20), trangThai = 0, tienDo = 0, mucDo = 4 });//27

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

            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tìm hiểu công nghệ MERN", iDCongviec = 27, trangThai = 0, mucDo = 2 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tìm hiểu về ReactJS", iDCongviec = 27, trangThai = 0, mucDo = 2 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tìm hiểu về phát triển ứng dụng web", iDCongviec = 27, trangThai = 0, mucDo = 2 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tìm hiểu về phát triển ứng dụng di động", iDCongviec = 27, trangThai = 0, mucDo = 2 });
            chiTietCVBUS.Insert(new DAO.Model.ChiTietCV() { ten = "Tìm hiểu về các thuật toán mới", iDCongviec = 27, trangThai = 0, mucDo = 2 });

            //Ghi chu nhanh
            GhiChuNhanhBUS ghiChuNhanhBUS = new GhiChuNhanhBUS();
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 1", NoiDung = "Đây là nội dung của ghi chú nhanh 1", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 2", NoiDung = "Đây là nội dung của ghi chú nhanh 2", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 3", NoiDung = "Đây là nội dung của ghi chú nhanh 3", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
            ghiChuNhanhBUS.Insert(new DAO.Model.GhiChuNhanh() { TieuDe = "Ghi chú nhanh 4", NoiDung = "Đây là nội dung của ghi chú nhanh 4", ThoiGianBD = DateTime.Now, Email = "khoa@gmail.com" });
        }
        #endregion
    }
}