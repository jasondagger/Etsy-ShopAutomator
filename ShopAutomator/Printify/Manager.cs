using Newtonsoft.Json;

namespace ShopAutomator.Printify
{
    public sealed class Manager
    {
        public async Task<
            List<Shop>
        > GetShops()
        {
            var httpClient = CreateHttpRequest();
            var response = await httpClient.GetAsync(
                $"{c_urlShops}.json"
            );

            string responseBody = await response.Content.ReadAsStringAsync();
            var shops = JsonConvert.DeserializeObject<List<Shop>>(
                responseBody
            );

            return shops ?? new();
        }

        public async Task<
            List<Product>
        > GetShopProducts(
            int shopId
        )
        {
            var httpClient = CreateHttpRequest();

            int pageIndex = 1;
            List<Product> products = new();
            while (true)
            {
                var response = await httpClient.GetAsync(
                    $"{c_urlShops}/{shopId}/products.json?page={pageIndex}"
                );

                string responseBody = await response.Content.ReadAsStringAsync();
                var productsPage = JsonConvert.DeserializeObject<ProductsPage>(
                    responseBody
                );

                if (productsPage.data != null)
                {
                    foreach (var product in  productsPage.data)
                    {
                        products.Add(
                            product
                        );
                        Console.WriteLine(
                            $"{product.id}: {product.title}"
                        );
                    }

                    if (productsPage.last_page_url == $"/?page={pageIndex++}")
                    {
                        Console.WriteLine($"{products.Count}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(
                        $"{nameof(ShopAutomator)}.{nameof(Printify)}.{nameof(Manager)}.{nameof(GetShopProducts)} - Products on page {pageIndex} is {null}"
                    );
                    break;
                }
            }

            return products;
        }

        private const string c_url = "https://api.printify.com/v1";
        private const string c_urlShops = $"{c_url}/shops";

        private HttpClient CreateHttpRequest()
        {
            HttpClient httpClient = new();

            httpClient.DefaultRequestHeaders.Add(
                $"Authorization",
                $"Bearer {Data.c_accessToken}"
            );

            return httpClient;
        }
    }
}