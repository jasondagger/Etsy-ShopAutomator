
namespace ShopAutomator.Printify
{
    public struct ProductVariant
    {
        public int id = 0;
        public string sku = string.Empty;
        public int cost = 0;
        public int price = 0;
        public string title = string.Empty;
        public int grams = 0;
        public bool is_enabled = false;
        public bool is_default = false;
        public bool is_available = false;
        public bool is_printify_express_eligible = false;
        public int[]? options = null;

        public ProductVariant(
            int id,
            string sku,
            int cost,
            int price,
            string title,
            int grams,
            bool is_enabled,
            bool is_default,
            bool is_available,
            bool is_printify_express_eligible,
            int[]? options
        )
        {
            this.id = id;
            this.sku = sku;
            this.cost = cost;
            this.price = price;
            this.title = title;
            this.grams = grams;
            this.is_enabled = is_enabled;
            this.is_default = is_default;
            this.is_available = is_available;
            this.is_printify_express_eligible = is_printify_express_eligible;
            this.options = options;
        }
    }
}
