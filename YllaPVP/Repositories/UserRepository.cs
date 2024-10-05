using Microsoft.EntityFrameworkCore;
using YllaPVP.Data;
using YllaPVP.Repositories.Contracts;

namespace YllaPVP.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
        Context = context;
    }

    public IEnumerable<User> GetUsersWithClass()
    {
        return Context.Users.Include(p => p.Classes).ToList();
    }
}