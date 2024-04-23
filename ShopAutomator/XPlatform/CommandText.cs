
namespace ShopAutomator.XPlatform
{
    public sealed class CommandText
    {
        public const string XPlatform = "--x";
        public const string CopySKUs = "--copy_skus";

        public static readonly Dictionary<Command, string> c_commandTexts = new()
        {
            {
                Command.CopySKUs, $"{XPlatform} {CopySKUs}"
            }
        };
    }
}
