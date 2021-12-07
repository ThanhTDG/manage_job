using DAO.Infastructure;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
   
    public interface IChuDeRepository : IRepository<ChuDe>
    {

    }

    public class ChuDeRepository : RepositoryBase<ChuDe>, IChuDeRepository
    {
        public ChuDeRepository() { }
    }
}
