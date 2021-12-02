using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Modules
{
    public class NguoiDung
    {
        [Key]
        public string email { get; set; }
        public string banQuyen { get; set; }
        public string tenND { get; set; }



        public NguoiDung() { }

        public NguoiDung(string email, string banQuyen, string tenND)
        {
            this.email = email;
            this.banQuyen = banQuyen;
            this.tenND = tenND;
        }
    }
}
