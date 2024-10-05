using YllaPVP.Dtos.RequestDtos;
using YllaPVP.Dtos.ResponseDtos;

namespace YllaPVP.Services;

public interface IUserClassService
{
    Task<IEnumerable<UserClassResponseDto>> GetAllClasses();
    Task CreateClass(UserClassRequestDto userClass);
}