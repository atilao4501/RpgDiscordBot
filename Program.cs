using System;
using System.IO;
using System.Linq;
using DotnetBot;


public class Program
{
    static void Main(string[] args)
    {
        //DiscordBot bot = new DiscordBot();
        //bot.StartBotAsync().GetAwaiter().GetResult();
        //new DiscordBot().StartBotAsync().GetAwaiter().GetResult();

        User user = new User()
        {
            Username = "cleyton",

        };

        UserService.Register(user);
    }
}