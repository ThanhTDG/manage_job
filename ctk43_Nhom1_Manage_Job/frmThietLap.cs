using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows;
using System.Media;
using BUS;

namespace ctk43_Nhom1_Manage_Job
{
    public partial class frmThietLap : Form
    {
        WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
        public frmThietLap()
        {
            InitializeComponent();
        }
        public void defaltInfor()
        {
            Properties.Settings.Default.Sound = Properties.DefaulSetting.Default.Sound;
            Properties.Settings.Default.timeStart = Properties.DefaulSetting.Default.timeStart;
            Properties.Settings.Default.timeEnd = Properties.DefaulSetting.Default.timeEnd;
            Properties.Settings.Default.runHide = Properties.DefaulSetting.Default.runHide;
            Properties.Settings.Default.RunWithWin = Properties.Settings.Default.RunWithWin;
            Properties.Settings.Default.Volume = Properties.Settings.Default.Volume;
        }
        public void LoadInfor()
        {
            Binding bindings = new Binding("Value", nudVolume, "Value",true,DataSourceUpdateMode.Never);
            nudVolume.Value = Properties.Settings.Default.Volume;
            prbVolum.DataBindings.Add(bindings);
            txtByTeam.Text = Properties.Settings.Default.doByTeam;
            txtSound.Text = Properties.Settings.Default.Sound;
            txtContact.Text = Properties.Settings.Default.contact;
            txtVersion.Text = Properties.Settings.Default.version;
            txtNameProject.Text = Properties.Settings.Default.namePoject;
            int[] start = Extension.MinuteToTime(Properties.Settings.Default.timeStart);
            int[] end = Extension.MinuteToTime(Properties.Settings.Default.timeEnd);
            nudDayStart.Value = start[0];
            nudHourStart.Value = start[1];
            nudMinuteStart.Value = start[2];
            nudDayEnd.Value = end[0];
            nudHourEnd.Value = end[1];
            nudMinuteEnd.Value = end[2];
            chkRunHide.Checked = Properties.Settings.Default.runHide;
            chkRunWithWindown.Checked = Properties.Settings.Default.RunWithWin;
        }

        private void chkRunWithWindown_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void frmThietLap_Load(object sender, EventArgs e)
        {
            defaltInfor();
            LoadInfor();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            
            LoadInfor();
         }
        private void btnSave_Click(object sender, EventArgs e)
        {
           /* if (chkRunHide.Checked == true)
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Micorsoft\\Windowns\\CurrentVersion\\Run", true);
                reg.SetValue(Properties.Settings.Default.namePoject, Application.ExecutablePath.ToString());
            }*/


        }

        private void btnTestSound_Click(object sender, EventArgs e)
        {

            mediaPlayer.URL = txtSound.Text;
          
            if (btnTestSound.Text == "")
            {
                mediaPlayer.controls.stop();
                btnTestSound.Text = "Nghe thử";
            }
            else
            {
                mediaPlayer.controls.play();
                btnTestSound.Text = "";
            }
        
         }
    }
}
