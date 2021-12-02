using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Modules
{
    public class GhiChuNhanh
    {
        public int id;
        public string tieuDe;
        public string noiDung;
        public DateTime thoiGianBD;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string TieuDe
        {
            get
            {
                return tieuDe;
            }
            set
            {
                tieuDe = value;
            }
        }
        public string NoiDung
        {
            get
            {
                return noiDung;
            }
            set
            {
                noiDung = value;
            }
        }
        public DateTime ThoiGianBD
        {
            get
            {
                return thoiGianBD;
            }
            set
            {
                thoiGianBD = value;
            }
        }

        public GhiChuNhanh() { }
        public GhiChuNhanh(int id, string tieuDe, string noiDung, DateTime thoiGianDB)
        {
            this.id = id;
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.thoiGianBD = thoiGianDB;
        }
    }
}
