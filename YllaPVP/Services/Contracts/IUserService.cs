using YllaPVP.Dtos.RequestDtos;
using YllaPVP.Dtos.ResponseDtos;

namespace YllaPVP.Services;

public interface IUserService
{
    Task<IEnumerable<UserResponseDto>?> GetAllUsers();
    Task<User?> GetUserByGuid(Guid id);
    Task AddUser(UserRequestDto user);
    Task UpdateUser(User user);
    Task DeleteUser(Guid id);

}