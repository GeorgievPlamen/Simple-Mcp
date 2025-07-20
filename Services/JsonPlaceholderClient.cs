namespace Simple_Mcp.Services;

public class JsonPlaceholderClient(IHttpClientFactory httpClientFactory)
{
    public async Task<string> GetJsonPlaceholderPostsAsync()
    {
        var client = httpClientFactory.CreateClient();
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

        var postsResponse = await client.GetAsync("/posts");

        return await postsResponse.Content.ReadAsStringAsync();
    }
}