using DAO.Infastructure;
using DAO.Model;

namespace DAO.Repositories
{

    public interface INguoiDungRepository : IRepository<NguoiDung>
    {

    }

    public class NguoiDungRepository : RepositoryBase<NguoiDung>, INguoiDungRepository
    {
        public NguoiDungRepository() { }
    }
}
