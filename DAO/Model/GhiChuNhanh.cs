using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class GhiChuNhanh
    {
        public int id { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public string Email { get; set; }

        [ForeignKey("Email")]
        public virtual NguoiDung nguoiDung { get; set; }

        public GhiChuNhanh() { }
    }
}
