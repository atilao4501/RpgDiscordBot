namespace DotnetBot;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }

    public List<Campaign> Campaigns { get; set; } = new List<Campaign>();
}
