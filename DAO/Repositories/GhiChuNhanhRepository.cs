using DAO.Infastructure;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public interface IGhiChuRepository : IRepository<GhiChuNhanh>
    {
    }
    public class GhiChuNhanhRepository : RepositoryBase<GhiChuNhanh>, IGhiChuRepository
    {
        public GhiChuNhanhRepository() { }
    }

  
}
