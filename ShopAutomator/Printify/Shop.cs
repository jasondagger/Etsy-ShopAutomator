
namespace ShopAutomator.Printify
{
    public struct Shop
    {
        public int id = 0;
        public string title = string.Empty;
        public string sales_channel = string.Empty;

        public Shop(
            int id,
            string title,
            string sales_channel
        )
        {
            this.id = id;
            this.title = title;
            this.sales_channel = sales_channel;
        }
    }
}
