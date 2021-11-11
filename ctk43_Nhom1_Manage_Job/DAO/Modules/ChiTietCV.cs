using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctk43_Nhom1_Manage_Job.DAO.Modules
{
    public class ChiTietCV
    {
        private int iD;
        private int iDCongViec;
        private string ten;
        private int trangThai;
        private DateTime thoiGian;
        private int mucDo;
        private int tienDo;
        private int iDChiTietCV;

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

        public int IDCongViec
        {
            get
            {
                return iDCongViec;
            }

            set
            {
                iDCongViec = value;
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



        public DateTime ThoiGian
        {
            get
            {
                return thoiGian;
            }

            set
            {
                thoiGian = value;
            }
        }

        public int MucDo
        {
            get
            {
                return mucDo;
            }

            set
            {
                mucDo = value;
            }
        }

        public int TienDo
        {
            get
            {
                return tienDo;
            }

            set
            {
                tienDo = value;
            }
        }

        public int IDChiTietCV
        {
            get
            {
                return iDChiTietCV;
            }

            set
            {
                iDChiTietCV = value;
            }
        }

        public int TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public ChiTietCV()
        {
        }

        public ChiTietCV(int ID, int IDCongViec, string Ten, int TrangThai, DateTime ThoiGian, int MucDo, int TienDo, int IDChiTietCongViec)
        {
            this.iD = ID;
            this.iDCongViec = IDCongViec;
            this.ten = Ten;
            this.trangThai = TrangThai;
            this.thoiGian = ThoiGian;
            this.mucDo = MucDo;
            this.tienDo = TienDo;
            this.iDChiTietCV = IDChiTietCongViec;
        }
    }
}
