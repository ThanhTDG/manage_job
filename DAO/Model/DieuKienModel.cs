using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class DieuKienModel
    {

        public int IDCon {  get; set; }
        public int IDCha { get; set; }

        public DieuKienModel(int iDCon, int iDCha)
        {
            IDCon = iDCon;
            IDCha = iDCha;
        }

        public DieuKienModel()
        {
        }
    }
}
