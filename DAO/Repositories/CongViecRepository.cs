using DAO.Infastructure;
using DAO.Model;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAO.Repositories
{
    public interface ICongViecRepository : IRepository<CongViec>
    {
        IEnumerable<CongViec> GetCongViecByNguoiDung(string email);
    }
    public class CongViecRepository : RepositoryBase<CongViec>, ICongViecRepository
    {
        #region Properties
        private ManageJobContext dataContext;
        private readonly IDbSet<CongViec> dbSet;


        protected ManageJobContext DbContext
        {
            get { return dataContext ?? (dataContext = new ManageJobContext()); }
        }
        #endregion

        public CongViecRepository()
        {
            dbSet = DbContext.Set<CongViec>();
        }

        public IEnumerable<CongViec> GetCongViecByNguoiDung(string email)
        {
            var query = from s in DbContext.congViec
                        join r in DbContext.chuDe
                        on s.IDChuDe equals r.iD
                        where r.Email == email
                        select s;

            return query;
        }
    }
}
