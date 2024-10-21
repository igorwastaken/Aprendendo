// Vamo criar um bot simples pra Discord (ver se é fácil)
using Discord;
using Discord.WebSocket;
public class Program {
    private static DiscordSocketClient _client = new DiscordSocketClient();

    public static async Task Main() {
        _client = new DiscordSocketClient();
        _client.Log += Log;

        var token = "Nem fodendo que vou revelar";

        await _client.LoginAsync(TokenType.Bot, /* Não entendi essa parte*/ token);
        await _client.StartAsync();

        await Task.Delay(-1); // Isso inicia uma tarefa, mas como vai funcionar?
    }
    private static Task Log(LogMessage msg) {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;

    }
}