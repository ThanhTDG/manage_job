using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Define
{
    public class DataCheck
    {
        #region 1911205 - Nguyễn hữu Đức Thanh
        private static DataCheck instance;
        public List<int> mucdo;
        public List<int> trangthai;
        public List<DateTime> time;
        public static DataCheck Instance
        {
            get { if (instance == null)
                    return instance = new DataCheck();
                return instance; }
            private set { instance = value; }
        }
        private DataCheck()
        {
        
        }
        public void resetData()
        {
            mucdo = new List<int>();
            trangthai = new List<int>();
            time = new List<DateTime>();
        }
        #endregion
    }
}
