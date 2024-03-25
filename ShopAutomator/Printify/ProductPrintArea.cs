
namespace ShopAutomator.Printify
{
    public struct ProductPrintArea
    {
        public int[]? variant_ids = null;
        public ProductPlaceholder[]? placeholders = null;
        public string background = string.Empty;

        public ProductPrintArea(
            int[]? variant_ids,
            ProductPlaceholder[]? placeholders,
            string background
        )
        {
            this.variant_ids = variant_ids;
            this.placeholders = placeholders;
            this.background = background;
        }
    }
}
