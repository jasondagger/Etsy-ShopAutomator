
using PrintifyManager = ShopAutomator.Printify.Manager;

namespace ShopAutomator.Printify
{
    public sealed class TaskHandler
    {
        public async Task DownloadMockUps()
        {
            var shops = await m_printifyManager.GetShops();

            foreach (var shop in shops)
            {
                var products = await m_printifyManager.GetShopProducts(
                    shop.id
                );

                if (products == null)
                {
                    Console.WriteLine(
                        $"No products found for {shop.title}."    
                    );
                    continue;
                }

                foreach (var product in products)
                {
                    var images = product.images;

                    if (images == null)
                    {
                        Console.WriteLine(
                            $"No images found for {product.title}."    
                        );
                        continue;
                    }

                    const string rootPath = "D:/Portfolio/Etsy/Product/";
                    string outputPath = $"{rootPath}{product.title}";
                    string fileName = $"{outputPath.Substring(outputPath.Length - 1)}.jpg";
                    outputPath = outputPath[..^1];

                    bool directoryExists = Directory.Exists(
                        outputPath
                    );
                    if (!directoryExists)
                    {
                        Console.WriteLine(
                            $"*** WARNING - Product Directory not found. ***" +
                            $"\n\tPath:  {outputPath}" +
                            $"\n\tImage: {fileName}"
                        );
                        continue;
                    }

                    HttpClient httpClient = new();
                    foreach (var image in images)
                    {
                        string src = image.src;

                        var mockUpType = MockUpData.GetMockUpType(
                            src
                        );
                        string outputFileName = string.Empty;
                        switch (mockUpType)
                        {
                            case MockUpType.AppleIPhone13ProMax:
                                outputFileName = $"iphone13promax_{fileName}";
                                break;
                            case MockUpType.AppleIPhone14ProMax:
                                outputFileName = $"iphone14promax_{fileName}";
                                break;
                            case MockUpType.AppleIPhone15ProMax:
                                outputFileName = $"iphone15promax_{fileName}";
                                break;
                            case MockUpType.GooglePixel7:
                                outputFileName = $"pixel7_{fileName}";
                                break;
                            case MockUpType.GooglePixel8Pro:
                                outputFileName = $"pixel8pro_{fileName}";
                                break;
                            case MockUpType.SamsungGalaxyS23Ultra:
                                outputFileName = $"galaxys23ultra_{fileName}";
                                break;
                            case MockUpType.SamsungGalaxyS24Ultra:
                                outputFileName = $"galaxys24ultra_{fileName}";
                                break;

                            case MockUpType.Unknown:
                            default:
                                continue;
                        }

                        Console.WriteLine(
                            $"Downloading {product.title[..^1]}{outputFileName}"
                        );
                        var response = await httpClient.GetAsync(
                            src
                        );
                        var responseData = await response.Content.ReadAsByteArrayAsync();
                        await File.WriteAllBytesAsync(
                            $"{outputPath}{outputFileName}",
                            responseData
                        );
                    }
                }

                Console.WriteLine(
                    $"Download Complete: {products.Count} products downloaded from {shop.title}."    
                );
            }
        }

        private PrintifyManager m_printifyManager = new();
    }
}