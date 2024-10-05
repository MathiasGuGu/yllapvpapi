namespace YllaPVP.Entities;

public class User
{
    public int Id { get; set; }
    public required Guid UserGuid { get; set; }
    public required string Username { get; set; }
    public int Deaths { get; set; } = 0;
    public int Kills { get; set; } = 0;
    public List<UserClass?>? Classes { get; set; }
}