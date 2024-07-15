using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;

namespace DotnetBot;

public class DiscordBot
{
    private IConfiguration _configuration;

    private readonly DiscordSocketClient _client;

    public DiscordBot()
    {
        _configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .Build();

        _client = new DiscordSocketClient();
        _client.MessageReceived += MessageHandler;
    }

    private async Task MessageHandler(SocketMessage message)
    {
        if (message.Author.IsBot) return;

        await ReplyAsync(message, $"Hello {message.Author.GlobalName}");
    }

    private async Task ReplyAsync(SocketMessage message, string response)
    {
        await message.Channel.SendMessageAsync(response);
    }

    public async Task StartBotAsync()
    {
        _client.Log += LogFuncAsync;
        await _client.LoginAsync(Discord.TokenType.Bot, _configuration["TokenDiscord"]);
        await _client.StartAsync();
        await Task.Delay(-1);

        async Task LogFuncAsync(LogMessage message) =>
        Console.WriteLine(message.ToString());


    }
}
