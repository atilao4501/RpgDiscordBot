namespace DotnetBot;

public class Campaign
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime HourReserved { get; set; }

    public DayOfWeek WeekDay { get; set; }

    public List<User> Users = new List<User>();

}
