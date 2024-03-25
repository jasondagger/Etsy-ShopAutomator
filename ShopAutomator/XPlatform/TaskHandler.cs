
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
                int i = 0;
                i++;
            }
        }

        private EtsyManager m_etsyManager = new();
        private PrintifyManager m_printifyManager = new();
    }
}
