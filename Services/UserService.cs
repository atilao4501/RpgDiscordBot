using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DotnetBot;

public class UserService
{
    private readonly DbContextClass _dbContext = new DbContextClass();
    public bool Register(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return false;
    }

    public bool AddCampaingByUserId(int id, Campaign campaign)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
    }
}
