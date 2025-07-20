using Simple_Mcp.Services;

namespace Simple_Mcp.Tools;

[McpServerToolType]
public class JsonPlaceholderTool(JsonPlaceholderClient jsonPlaceholderClient)
{
    [McpServerTool, Description("Gets the posts data as a json string from JsonPlaceholder.")]
    public async Task<string> GetJsonPlaceholderPostsAsync() => await jsonPlaceholderClient.GetJsonPlaceholderPostsAsync();
}