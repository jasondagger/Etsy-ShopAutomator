
using EtsyManager = ShopAutomator.Etsy.Manager;
using PrintifyManager = ShopAutomator.Printify.Manager;

namespace ShopAutomator.XPlatform
{
    public sealed class TaskHandler
    {
        public async Task CopyPrintifySKUsToEtsy()
        {
            var shops = await m_printifyManager.GetShops();

            foreach (var shop in shops)
            {
                var products = await m_printifyManager.GetShopProducts(
                    shop.id
                );
                
                // todo
                
                foreach (var product in products)
                {
                    var images = product.images;

                    if (images != null)
                    {
                        foreach (var image in images)
                        {
                            string src = image.src;
                            int i = 0;
                            i++;
                        }
                    }
                }
            }
        }

        private EtsyManager m_etsyManager = new();
        private PrintifyManager m_printifyManager = new();
    }
}
