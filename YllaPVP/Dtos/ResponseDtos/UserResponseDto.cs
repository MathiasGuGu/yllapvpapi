namespace YllaPVP.Dtos.ResponseDtos;

public class UserResponseDto
{
    public int Id { get; set; }
    public Guid UserGuid { get; set; }
    public string Username { get; set; }
    public int Deaths { get; set; } = 0;
    public int Kills { get; set; } = 0;
    public List<UserClass?>? Classes { get; set; }
}