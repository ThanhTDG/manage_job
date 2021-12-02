using DAO.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class DieuKien
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iDCon { get; set; }
        [Key,Column(Order =1)]
        public int iDCha { get; set; }
        [ForeignKey("iDCon")]
        public ChiTietCV CVCon;
        [ForeignKey("iDCha")]
        public ChiTietCV CVCha;

        
    }
}
