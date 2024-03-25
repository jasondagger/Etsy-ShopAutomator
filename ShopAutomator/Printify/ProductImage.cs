
namespace ShopAutomator.Printify
{
    public struct ProductImage
    {
        public string src = string.Empty;
        public int[]? variant_ids = null;
        public string position = string.Empty;
        public bool is_default = false;

        public ProductImage(
            string src,
            int[] variant_ids,
            string position,
            bool is_default
        )
        {
            this.src = src;
            this.variant_ids = variant_ids;
            this.position = position;
            this.is_default = is_default;
        }
    }
}