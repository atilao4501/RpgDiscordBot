using Microsoft.EntityFrameworkCore;

namespace DotnetBot;

public class UserService
{
    private static DbContext _DbContext = new DbContextClass();
    public static bool Register(User user)
    {
        _DbContext.Add<User>(user);
        _DbContext.SaveChanges();
        return false;
    }
}
