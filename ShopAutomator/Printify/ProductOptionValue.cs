
namespace ShopAutomator.Printify
{
    public struct ProductOptionValue
    {
        public int id = 0;
        public string title = string.Empty;
        public string[]? colors = null;

        public ProductOptionValue(
            int id,
            string title,
            string[] colors
        )
        {
            this.id = id;
            this.title = title;
            this.colors = colors;
        }
    }
}
