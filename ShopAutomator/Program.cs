
using EtsyTaskHandler = ShopAutomator.Etsy.TaskHandler;
using PrintifyTaskHandler = ShopAutomator.Printify.TaskHandler;
using XPlatformTaskHandler = ShopAutomator.XPlatform.TaskHandler;

using CommandEtsy = ShopAutomator.Etsy.Command;
using CommandPrintify = ShopAutomator.Printify.Command;
using CommandXPlatform = ShopAutomator.XPlatform.Command;

using CommandTextXPlatform = ShopAutomator.XPlatform.CommandText;

public static partial class Program
{
    public static void Main()
    {
        DisplayCommands();
        Run();
        while (m_isRunning);
    }

    private const float c_versionNumber = 0.1f;

    private static bool m_isRunning = true;
    private static EtsyTaskHandler m_etsyTaskHandler = new();
    private static PrintifyTaskHandler m_printifyTaskHandler = new();
    private static XPlatformTaskHandler m_xPlatformTaskHandler = new();

    private static void DisplayCommands()
    {
        Console.WriteLine(
            $"Shop Automator v{c_versionNumber}"
        );
        Console.WriteLine(
            "\tFor help: --help"
        );
    }

    private static async void Run()
    {
        while (m_isRunning)
        {
            Console.Write(
                "\tEnter Command: "
            );
            List<string>? commands = Console.ReadLine()?.Split(' ').ToList();
            Console.WriteLine();
            if (commands != null)
            {
                string command = commands[0].ToLower();

                switch (command)
                {
                    case "--help":
                        ProcessCommandHelp();
                        break;

                    case "--stop":
                        await ProcessCommandStop();
                        break;

                    default:
                        await Task.Run(
                            async () =>
                            {
                                commands.RemoveAt(0);
                                await HandleShopCommands(
                                    command,
                                    commands
                                );
                            }
                        );
                        break;
                }
            }
        }
    }

    private static async Task HandleShopCommands(
        string store,
        List<string> commands
    )
    {
        switch (store)
        {
            case "--e":
                await HandleEtsyCommands(
                    commands
                );
                break;

            case "--p":
                await HandlePrintifyCommands(
                    commands
                );
                break;

            case "--x":
                await HandleXPlatformCommands(
                    commands
                );
                break;

            default:
                Console.WriteLine("Invalid Store Parameters");
                break;
        }
    }

    private static async Task HandleEtsyCommands(
        List<string> commands
    )
    {
        string command = commands[0].ToLower();
        commands.RemoveAt(0);

        switch (command)
        {
            case "--oauth":
                await m_etsyTaskHandler.OAuth();
                break;

            default:
                Console.WriteLine("Invalid Etsy Task.");
                break;
        }
    }

    private static async Task HandlePrintifyCommands(
        List<string> commands
    )
    {
        string command = commands[0].ToLower();
        commands.RemoveAt(0);

        switch (command)
        {


            default:
                Console.WriteLine("Invalid Printify Task.");
                break;
        }
    }

    private static async Task HandleXPlatformCommands(
        List<string> commands
    )
    {
        string command = commands[0].ToLower();
        commands.RemoveAt(0);

        switch (command)
        {
            case "--copy_skus":
                await m_xPlatformTaskHandler.CopyPrintifySKUsToEtsy();
                break;

            default:
                Console.WriteLine("Invalid X Platform Task.");
                break;
        }
    }

    private static void ProcessCommandHelp()
    {
        Console.WriteLine("\tCommand Format:");
        Console.WriteLine("\t\t--parameter1 --p2 ... --pN");

        Console.WriteLine("\tApplication:");
        Console.WriteLine("\t\t--help");
        Console.WriteLine("\t\t--stop");
        Console.WriteLine();

        Console.WriteLine(
            "\tEtsy:"
        );
        var etsyCommands = Enum.GetValues<CommandEtsy>();
        foreach (var command in etsyCommands)
        {
            //Console.WriteLine(
            //    $"\t\t{command}:" +
            //    $"\t\t\t{Command}"                
            //);
        }
        Console.WriteLine();

        Console.WriteLine(
            "\tPrintify:"
        );
        var printifyCommands = Enum.GetValues<CommandPrintify>();
        foreach (var command in etsyCommands)
        {
            //Console.WriteLine(
            //    $"\t\t--{command}"
            //);
        }
        Console.WriteLine();

        Console.WriteLine(
            "\tXPlatform:"
        );
        var xPlatformCommands = Enum.GetValues<CommandXPlatform>();
        foreach (var command in xPlatformCommands)
        {
            string commandText = CommandTextXPlatform.c_commandTexts[command];
            Console.WriteLine(
                $"\t\t{command}:" +
                $"\n\t\t\t{commandText}"                
            );
        }
        Console.WriteLine();
    }

    private static async Task ProcessCommandStop()
    {
        Console.WriteLine(
            "Closing Application in 3s..."
        );
        await Task.Delay(
            3000
        );
        m_isRunning = false;
    }
}