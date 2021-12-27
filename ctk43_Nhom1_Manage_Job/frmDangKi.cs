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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

		  private void button6_Click(object sender, EventArgs e)
		  {
				string keySetting = Properties.Settings.Default.key;
				string key = mstbKey.Text;
				if(key == keySetting)
				{
					 MessageBox.Show("Kích hoạt bản quyền thành công\nTắt ứng dụng và khởi động lại");
					 Properties.Settings.Default.kichhoat = true;
					 Properties.Settings.Default.Save();
					 this.DialogResult = DialogResult.OK;
					 Application.Exit();
				}
				else
				{
					 MessageBox.Show("Kích hoạt bản quyền thất bại, vui lòng nhập lại key!");
				}
		  }

		  private void button1_Click(object sender, EventArgs e)
		  {
				this.Close();
		  }
	 }
}
