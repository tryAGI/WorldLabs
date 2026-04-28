
#nullable enable

namespace WorldLabs
{
    public sealed partial class WorldLabsClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "WLT-Api-Key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::WorldLabs.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyWltApiKey",
                Location = "Header",
                Name = "WLT-Api-Key",
                Value = apiKey,
            });
        }
    }
}