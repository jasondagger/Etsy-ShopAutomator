
namespace ShopAutomator.Printify
{
    public sealed class MockUpData
    {
        public static MockUpType GetMockUpType(
            string imageAddress    
        )
        {
            bool isAppleIPhone13ProMax = imageAddress.Contains(
                ProductAppleIPhone13ProMax
            );
            if (isAppleIPhone13ProMax)
            {
                bool isFrontMockUp = imageAddress.Contains(
                    ProductAppleIPhone13ProMaxFrontMockUp
                );
                if (isFrontMockUp)
                {
                    return MockUpType.AppleIPhone13ProMax;
                }
            }

            bool isAppleIPhone14ProMax = imageAddress.Contains(
                ProductAppleIPhone14ProMax
            );
            if (isAppleIPhone14ProMax)
            {
                bool isFrontMockUp = imageAddress.Contains(
                    ProductAppleIPhone14ProMaxFrontMockUp
                );
                if (isFrontMockUp)
                {
                    return MockUpType.AppleIPhone14ProMax;
                }
            }

            bool isAppleIPhone15ProMax = imageAddress.Contains(
                ProductAppleIPhone15ProMax
            );
            if (isAppleIPhone15ProMax)
            {
                bool isFrontMockUp = imageAddress.Contains(
                    ProductAppleIPhone15ProMaxFrontMockUp
                );
                if (isFrontMockUp)
                {
                    return MockUpType.AppleIPhone15ProMax;
                }
            }

            bool isGooglePixel7 = imageAddress.Contains(
                ProductGooglePixel7
            );
            if (isGooglePixel7)
            {
                bool isFrontMockUp = imageAddress.Contains(
                    ProductGooglePixel7FrontMockUp
                );
                if (isFrontMockUp)
                {
                    return MockUpType.GooglePixel7;
                }
            }

            bool isGooglePixel8Pro = imageAddress.Contains(
                ProductGooglePixel8Pro
            );
            if (isGooglePixel8Pro)
            {
                bool isFrontMockUp = imageAddress.Contains(
                    ProductGooglePixel8ProFrontMockUp
                );
                if (isFrontMockUp)
                {
                    return MockUpType.GooglePixel8Pro;
                }
            }

            bool isSamsungGalaxyS23Ultra = imageAddress.Contains(
                ProductSamsungGalaxyS23Ultra
            );
            if (isSamsungGalaxyS23Ultra)
            {
                bool isFrontMockUp = imageAddress.Contains(
                    ProductSamsungGalaxyS23UltraFrontMockUp
                );
                if (isFrontMockUp)
                {
                    return MockUpType.SamsungGalaxyS23Ultra;
                }
            }

            bool isSamsungGalaxyS24Ultra = imageAddress.Contains(
                ProductSamsungGalaxyS24Ultra
            );
            if (isSamsungGalaxyS24Ultra)
            {
                bool isFrontMockUp = imageAddress.Contains(
                    ProductSamsungGalaxyS24UltraFrontMockUp
                );
                if (isFrontMockUp)
                {
                    return MockUpType.SamsungGalaxyS24Ultra;
                }
            }

            return MockUpType.Unknown;
        }

        private const string ProductAppleIPhone13ProMax = "75390";
        private const string ProductAppleIPhone13ProMaxFrontMockUp = "22096";

        private const string ProductAppleIPhone14ProMax = "96404";
        private const string ProductAppleIPhone14ProMaxFrontMockUp = "88002";

        private const string ProductAppleIPhone15ProMax = "102554";
        private const string ProductAppleIPhone15ProMaxFrontMockUp = "99496";

        private const string ProductGooglePixel7 = "98739";
        private const string ProductGooglePixel7FrontMockUp = "89270";

        private const string ProductGooglePixel8Pro = "105155";
        private const string ProductGooglePixel8ProFrontMockUp = "102010";

        private const string ProductSamsungGalaxyS23Ultra = "96743";
        private const string ProductSamsungGalaxyS23UltraFrontMockUp = "86597";

        private const string ProductSamsungGalaxyS24Ultra = "105153";
        private const string ProductSamsungGalaxyS24UltraFrontMockUp = "102065";
    }
}