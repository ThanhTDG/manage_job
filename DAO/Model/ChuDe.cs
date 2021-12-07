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
    }
}
