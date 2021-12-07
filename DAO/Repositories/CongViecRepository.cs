using DAO.Infastructure;
using DAO.Model;

namespace DAO.Repositories
{
    public interface ICongViecRepository : IRepository<CongViec>
    {

    }
    public class CongViecRepository : RepositoryBase<CongViec>, ICongViecRepository
    {
        public CongViecRepository() { }
    }
}
