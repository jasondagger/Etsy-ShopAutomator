
namespace ShopAutomator.XPlatform
{
    public sealed class CommandText
    {
        public static readonly Dictionary<Command, string> c_commandTexts = new()
        {
            {
                Command.CopySKUs, "--x --copy_skus"
            }
        };
    }
}
