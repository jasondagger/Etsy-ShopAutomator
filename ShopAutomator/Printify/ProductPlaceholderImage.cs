
namespace ShopAutomator.Printify
{
    public struct ProductPlaceholderImage
    {
        public string id = string.Empty;
        public string name = string.Empty;
        public string type = string.Empty;
        public int height = 0;
        public int width = 0;
        public float x = 0f;
        public float y = 0f;
        public float scale = 1f;
        public float angle = 0f;

        public ProductPlaceholderImage(
            string id,
            string name,
            string type,
            int height,
            int width,
            float x,
            float y,
            float scale,
            int angle
        )
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.height = height;
            this.width = width;
            this.x = x;
            this.y = y;
            this.scale = scale;
            this.angle = angle;
        }
    }
}
