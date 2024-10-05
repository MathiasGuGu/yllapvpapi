namespace YllaPVP.Repositories.Contracts;

public interface IUserRepository : IBaseRepository<User>
{
    IEnumerable<User> GetUsersWithClass();
}