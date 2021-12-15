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
<<<<<<< HEAD
        public ChuDe(int iD,int loaiChude, string ten)
=======
        public ChuDe(int iD, int loaiChude, string ten)
>>>>>>> 3360a246b194cdde6465cd0faa917776bb5f8ecc
        {
            this.loaiChuDe = loaiChude;
            this.iD = iD;
            this.ten = ten;
        }

        public ChuDe()
        {

        }
    }
}
