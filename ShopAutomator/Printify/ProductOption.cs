
namespace ShopAutomator.Printify
{
    public struct ProductOption
    {
        public string name = string.Empty;
        public string type = string.Empty;
        public ProductOptionValue[]? values = null;

        public ProductOption(
            string name,
            string type,
            ProductOptionValue[]? values
        )
        {
            this.name = name;
            this.type = type;
            this.values = values;
        }
    }
}