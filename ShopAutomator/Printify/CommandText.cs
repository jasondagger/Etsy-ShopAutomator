
namespace ShopAutomator.Printify
{
    public sealed class CommandText
    {
        public const string Printify = "--p";
        public const string DownloadMockUps = "--download_mockups";

        public static readonly Dictionary<Command, string> c_commandTexts = new()
        {
            {
                Command.DownloadMockUps, $"{Printify} {DownloadMockUps}"
            }
        };
    }
}
