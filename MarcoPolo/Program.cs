// Build a Marco Polo Command Line Application that uses System.CommandLine

using System.CommandLine;

namespace marcoPolo;

// Build a Marco Polo Command Line Application that uses System.CommandLine
class Program
{
    static async Task<int> Main(string[] args)
    {
        var nameOption = new Option<string?>(
            name: "--name",
            description: "The name to input");

        var rootCommand = new RootCommand("Marco Polo");
        rootCommand.AddOption(nameOption);
        rootCommand.SetHandler((name) => { MarcoPolo(name!); }, nameOption);
        return await rootCommand.InvokeAsync(args);
    }
    static void MarcoPolo(string name)
    {
        if (name == "Marco")
        {
            Console.WriteLine("Polo!");
        }
        else
        {
            Console.WriteLine("I don't know you.");
        }


    }
}
