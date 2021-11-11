using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctk43_Nhom1_Manage_Job.DAO.Modules
{
    public class NguoiDung
    {
        private string email;
        private string banQuyen;
        private string tenND;


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string BanQuyen { get { return banQuyen; }  set{ banQuyen = value; } }
        public string TenND { get
            {
                return tenND;
            }
            set
            {
                tenND = value;
            } }

        public NguoiDung() { }

        public NguoiDung(string email, string banQuyen, string tenND)
        {
            this.email = email;
            this.banQuyen = banQuyen;
            this.tenND = tenND;
        }
    }
}
