using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctk43_Nhom1_Manage_Job.DAO.Modules
{
    public class ChuDe
    {
        private int iD;
        private string ten;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public ChuDe()
        {
            this.iD = 0;
            this.ten = null;
        }

        public ChuDe(int ID, string Ten)
        {
            this.iD = ID;
            this.ten = Ten;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Ten: {1}", this.iD, this.ten);
        }
    }
}
