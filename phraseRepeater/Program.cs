// Build a Phrase Repeater that repeats a phrase a number of times
using System.CommandLine;

namespace phraseRepeater;

class Program
{
    static async Task<int> Main(string[] args)
    {
        var phraseOption = new Option<string?>(
            name: "--phrase",
            description: "The phrase to repeat.");
        var repeatOption = new Option<int>(
            name: "--repeat",
            description: "The number of times to repeat the phrase.");

        var rootCommand = new RootCommand("Phrase Repeater");
        rootCommand.AddOption(phraseOption);
        rootCommand.AddOption(repeatOption);

        rootCommand.SetHandler((phrase, repeat) => 
            { 
                RepeatPhrase(phrase!, repeat!); 
            },
            phraseOption,
            repeatOption);

        return await rootCommand.InvokeAsync(args);
    }

    static void RepeatPhrase(string phrase, int repeat)
    {
        Enumerable.Range(1, repeat).ToList()
            .ForEach(line => Console.WriteLine(phrase));
    }
    
}