using YllaPVP.Dtos.RequestDtos;
using YllaPVP.Dtos.ResponseDtos;
using YllaPVP.Repositories.Contracts;

namespace YllaPVP.Services;

public class UserClassService : IUserClassService
{
    private readonly IUserClassRepository _userClassRepository;

    public UserClassService(IUserClassRepository userClassRepository)
    {
        _userClassRepository = userClassRepository;
    }
    
    
    public async Task<IEnumerable<UserClassResponseDto>> GetAllClasses()
    {
        var c = await _userClassRepository.GetAll();
        var classes = c.Select(c => new UserClassResponseDto
        {
            Id = c.Id,
            Name = c.Name,
            Description = c.Description,
            Level = c.Level
        });
        return classes;
    }

    public async Task CreateClass(UserClassRequestDto uc)
    {
        var userClass = new UserClass
        {
            Name = uc.Name,
            Description = uc.Description,
            Level = 0,
            User = null
        };
        _userClassRepository.Create(userClass);
        await _userClassRepository.SaveChangesAsync();
    }
}