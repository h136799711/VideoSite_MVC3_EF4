using VideoSite.EF.Infrastructure;
using VideoSite.EF.IRepository;
using VideoSite.EF.Model;
using VideoSite.EF.DBContexts;
namespace VideoSite.EF.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork)
        {
            Context = unitOfWork as BaseContext;
        }

        public User GetUserById(int id)
        {
            return  GetEntities().Find(id);
        }
    }
}
