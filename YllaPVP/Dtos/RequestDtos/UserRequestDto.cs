namespace YllaPVP.Dtos.RequestDtos;

public class UserRequestDto
{
    public required Guid UserGuid { get; set; }
    public required string Username { get; set; }
}