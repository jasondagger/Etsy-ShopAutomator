
namespace ShopAutomator.Printify
{
    public struct Product
    {
        public string id = string.Empty;
        public string title = string.Empty;
        public string description = string.Empty;
        public string[]? tags = null;
        public ProductOption[]? options = null;
        public ProductVariant[]? variants = null;
        public ProductImage[]? images = null;
        public string created_at = string.Empty;
        public string updated_at = string.Empty;
        public bool visible = false;
        public bool is_locked = false;
        public bool is_printify_express_eligible = false;
        public bool is_printify_express_enabled = false;
        public int blueprint_id = 0;
        public int user_id = 0;
        public int shop_id = 0;
        public int print_provider_id = 0;
        public ProductPrintArea[]? print_areas = null;
        public string[]? sales_channel_properties = null;

        public Product(
            string id,
            string title,
            string description,
            string[]? tags,
            ProductOption[]? options,
            ProductVariant[]? variants,
            ProductImage[]? images,
            string created_at,
            string updated_at,
            bool visible,
            bool is_locked,
            bool is_printify_express_eligible,
            bool is_printify_express_enabled,
            int blueprint_id,
            int user_id,
            int shop_id,
            int print_provider_id,
            ProductPrintArea[]? print_areas,
            string[]? sales_channel_properties
        )
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.tags = tags;
            this.options = options;
            this.variants = variants;
            this.images = images;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.visible = visible;
            this.is_locked = is_locked;
            this.is_printify_express_eligible = is_printify_express_eligible;
            this.is_printify_express_enabled = is_printify_express_enabled;
            this.blueprint_id = blueprint_id;
            this.user_id = user_id;
            this.shop_id = shop_id;
            this.print_provider_id = print_provider_id;
            this.print_areas = print_areas;
            this.sales_channel_properties = sales_channel_properties;
        }
    }
}