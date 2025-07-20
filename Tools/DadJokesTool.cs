namespace Simple_Mcp.Tools;

public record DadJoke(string Id, string Joke, int Status);

[McpServerToolType]
public class DadJokesTool(IHttpClientFactory httpClientFactory)
{
    [McpServerTool(UseStructuredContent = true), Description("Gets a dad joke with structured content")]
    public async Task<DadJoke> GetDadJokeAsync()
    {
        var client = httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Add("accept", "application/json");
        client.BaseAddress = new Uri("https://icanhazdadjoke.com");

        var response = await client.GetAsync("/");

        var joke = await response.Content.ReadFromJsonAsync<DadJoke>();

        return joke;
    }
}