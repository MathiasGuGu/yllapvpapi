using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using YllaPVP.Data;
using YllaPVP.Dtos.RequestDtos;
using YllaPVP.Dtos.ResponseDtos;
using YllaPVP.Repositories;
using YllaPVP.Repositories.Contracts;
namespace YllaPVP.Services;

public class UserService : IUserService
{

    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository, DataContext context)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserResponseDto>?> GetAllUsers()
    {
        var results = await _userRepository.GetAll();
        var classes = results.Select(u => new UserResponseDto
        {
            Id = u.Id,
            UserGuid = u.UserGuid,
            Username = u.Username,
            Classes = u.Classes,
            Deaths = u.Deaths,
            Kills = u.Kills,
        });
        return classes;
    }

    public Task<User?> GetUserByGuid(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task AddUser(UserRequestDto u)
    {
        var user = new User
        {
            UserGuid = u.UserGuid,
            Username = u.Username,
            Classes = null
        };
                
        _userRepository.Create(user);
        await _userRepository.SaveChangesAsync();
    }

    public Task UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }
}