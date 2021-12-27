using BUS;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctk43_Nhom1_Manage_Job
{
    public partial class frmGhiChu : Form
    {
        NguoiDung _nd = Extension.LoadSetting(Properties.Settings.Default.email);
        private int _ghiChuId;        
        public frmGhiChu(int ghiChuid = 0)
        {
            InitializeComponent();
            _ghiChuId = ghiChuid;
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(rtxtContent.Text))
            {
                ThongBao.CanhBao("Nội dung hoặc tiêu đề");
                return;
            }

            GhiChuNhanhBUS ghiChuNhanhBUS = new GhiChuNhanhBUS();
            if (_ghiChuId == 0)
            {
                GhiChuNhanh ghiChu = new GhiChuNhanh()
                {
                    Email = _nd.email,
                    TieuDe = txtTitle.Text,
                    NoiDung = rtxtContent.Text,
                    ThoiGianBD = DateTime.Now
                };

                int kq = ghiChuNhanhBUS.Insert(ghiChu);
                if (kq > 0)
                    ThongBao.ThanhCong("Thêm ghi chú nhanh");
            }
            else
            {
                GhiChuNhanh gc = ghiChuNhanhBUS.GetGhiChuByID(_ghiChuId);
                gc.TieuDe = txtTitle.Text;
                gc.NoiDung = rtxtContent.Text;
                ghiChuNhanhBUS.Update(gc);
                ThongBao.ThanhCong("Lưu");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void frmGhiChu_Load(object sender, EventArgs e)
        {
            if (_ghiChuId != 0)
            {
                GhiChuNhanhBUS ghiChuNhanhBUS = new GhiChuNhanhBUS();
                GhiChuNhanh gc = ghiChuNhanhBUS.GetGhiChuByID(_ghiChuId);
                txtTitle.Text = gc.TieuDe;
                rtxtContent.Text = gc.NoiDung;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(rtxtContent.Text))
            {
                ThongBao.CanhBao("Tiêu đề và nội dung");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.RestoreDirectory = true;
            dlg.FileName = txtTitle.Text;
            dlg.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LuuFileText(dlg.FileName);
                ThongBao.ThanhCong("Lưu tập tin");
            }
        }

        private void LuuFileText(string FileName)
        {
            using (var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine(rtxtContent.Text);
                }
            }
        }

        public void MoGhiChuCoSan(string FileName)
        {
            int index = FileName.LastIndexOf('\\');
            txtTitle.Text = FileName.Substring(index + 1, FileName.Length - index - 1).Trim();
            try
            {
                using (var stream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            rtxtContent.Text = reader.ReadToEnd();
                        }
                    }
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true; 
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
    }
}
