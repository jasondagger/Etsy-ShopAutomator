using Newtonsoft.Json;
using System.Net.Http;

namespace ShopAutomator.Etsy
{
    public sealed class Manager
    {
        public async Task OAuth()
        {
            var httpClient = CreateHttpRequest();
            var tokenRequest = new HttpRequestMessage(
                HttpMethod.Post, 
                "https://api.etsy.com/v3/public/oauth/token"
            );
            tokenRequest.Content = new FormUrlEncodedContent(
                new Dictionary<string, string>
                {
                    { "grant_type", "authorization_code" },
                    { "client_id", Data.c_keyString },
                    { "client_secret", Data.c_sharedSecret },
                    { "redirect_uri", "https://localhost:3000" },
                }
            );

            var response = await httpClient.GetAsync("https://api.etsy.com/v3/application/openapi-ping");
            var tokenResponse = await response.Content.ReadAsStringAsync();
            //var response = await httpClient.GetAsync(
            //    $"{c_urlShops}.json"
            //);
            //
            //string responseBody = await response.Content.ReadAsStringAsync();
            //var shops = JsonConvert.DeserializeObject<List<Shop>>(
            //    responseBody
            //);
            //
            //return shops ?? new();
        }

        private const string c_url = "https://api.printify.com/v1";
        private const string c_urlShops = $"{c_url}/shops";

        private HttpClient CreateHttpRequest()
        {
            HttpClient httpClient = new();

            httpClient.DefaultRequestHeaders.Add(
                $"x-api-key",
                $"{Data.c_keyString}"
            );

            //httpClient.DefaultRequestHeaders.Add(
            //    $"Authorization",
            //    $"Bearer {}"
            //);

            return httpClient;
        }
    }
}