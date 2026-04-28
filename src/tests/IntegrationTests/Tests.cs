namespace WorldLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WorldLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WORLDLABS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("WORLDLABS_API_KEY environment variable is not found.");

        var client = new WorldLabsClient(apiKey);
        
        return client;
    }
}
