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
    public partial class frmThongBaoCV : Form
    {
        List<CongViec> congViecs;
        public frmThongBaoCV(List<CongViec> congViecs)
        {
            this.congViecs = congViecs;
            InitializeComponent();
        }
        #region Hàm bổ trợ 
   /*     void GetListCV()
        {
            int countCV = congViecs.Count;
            if (countCV == 0)
                this.Close();
            UscThongBao[] thongbaos = new UscThongBao[countCV];
            for(int i = 0;i< countCV; i++)
            {
                thongbaos[i].lb
            }
        }*/

        #endregion

        #region event
        private void frmThongBaoCV_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
