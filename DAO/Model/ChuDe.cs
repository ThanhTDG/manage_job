using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class ChuDe
    {
        [Key]
        public int iD {  get; set; }
        public int loaiChuDe { get; set; }
        public string ten { get; set; }
        public string Email {  get; set; }

        [ForeignKey("Email")]
        public virtual NguoiDung nguoiDung { get; set; }

        public ChuDe(int iD, string ten)
        {
            this.iD = iD;
            this.ten = ten;
        }

        public ChuDe()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="loaiChude">
        /// 0 common 
        /// 1 everyday
        /// 2 everyweek
        /// 3 everymonth
        /// 4 everyyear
        /// </param>
        /// <param name="ten"></param>
        public ChuDe(int iD, int loaiChude, string ten)
        {
            this.loaiChuDe = loaiChude;
            this.iD = iD;
            this.ten = ten;
        }
    }
}
