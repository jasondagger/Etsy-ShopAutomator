
namespace ShopAutomator.Printify
{
    public struct ProductPlaceholder
    {
        public string position = string.Empty;
        public ProductPlaceholderImage[]? images = null;

        public ProductPlaceholder(
            string position,
            ProductPlaceholderImage[]? images
        )
        {
            this.position = position;
            this.images = images;
        }
    }
}
