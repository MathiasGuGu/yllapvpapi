using YllaPVP.Data;
using YllaPVP.Repositories.Contracts;

namespace YllaPVP.Repositories;

public class UserClassRepository : BaseRepository<UserClass>, IUserClassRepository
{
    public UserClassRepository(DataContext context) : base(context)
    {
        Context = context;
    }
}