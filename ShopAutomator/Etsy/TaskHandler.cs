
namespace ShopAutomator.Etsy
{
    public sealed class TaskHandler
    {
        public async Task OAuth()
        {
            await m_etsyManager.OAuth();
        }

        private Manager m_etsyManager = new();
    }
}
