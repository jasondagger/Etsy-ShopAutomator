
namespace ShopAutomator.Printify
{
    public struct ProductsPage
    {
        public int current_page = 0;
        public Product[]? data = null;
        public string first_page_url = string.Empty;
        public int? from = 0;
        public int last_page = 0;
        public string? last_page_url = string.Empty;
        public string? next_page_url = string.Empty;
        public string path = string.Empty;
        public int per_page = 0;
        public string? prev_page_url = string.Empty;
        public int? to = 0;
        public int total = 0;

        public ProductsPage(
            int current_page,
            Product[]? data,
            string first_page_url,
            int from,
            int last_page,
            string last_page_url,
            string next_page_url,
            string path,
            int per_page,
            string prev_page_url,
            int to,
            int total
        )
        {
            this.current_page = current_page;
            this.data = data;
            this.first_page_url = first_page_url;
            this.from = from;
            this.last_page = last_page;
            this.last_page_url = last_page_url;
            this.next_page_url = next_page_url;
            this.path = path;
            this.per_page = per_page;
            this.prev_page_url = prev_page_url;
            this.to = to;
            this.total = total;
        }
    }
}