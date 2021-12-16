using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctk43_Nhom1_Manage_Job.myUserControl
{
    public class Music
    {

        private static Music instance;
        private WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
        private bool isPlaying = false;
        public static Music Instance
        {
            get
            {
                if (instance == null)
                    return instance = new Music();
                return instance;
            }
            private set { instance = value; }
        }
        private Music()
        {
            mediaPlayer.URL = Properties.Settings.Default.Sound;
            mediaPlayer.settings.volume = Properties.Settings.Default.Volume;
        }
        public void PlayMusic()
        {
            if (isPlaying == false)
            {
                mediaPlayer.controls.play();
                isPlaying = true;
            }
        } 
        public void stopMusic()
        {
            if (isPlaying)
            {
                mediaPlayer.controls.stop();
                isPlaying = false;
            }
        }
         

    }
}
