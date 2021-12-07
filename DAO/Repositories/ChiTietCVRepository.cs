using DAO.Infastructure;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
   
    public interface IChiTietRepository : IRepository<ChiTietCV>
    {

    }

    public class ChiTietCVRepository : RepositoryBase<ChiTietCV>, IChiTietRepository
    {
       public ChiTietCVRepository() { }
    }
}
