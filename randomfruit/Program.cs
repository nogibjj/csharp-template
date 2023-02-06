// Build a RandomFruit Command Line Application that uses System.CommandLine

using System.CommandLine;

namespace randomFruit;

class Program
{

    //Create public immutable list of fruits
    public static readonly List<string> fruits = new List<string>()
    {
        "Apple",
        "Banana",
        "Orange",
        "Pear",
        "Pineapple",
        "Strawberry",
        "Watermelon"
    };

    //option handling
    static async Task<int> Main(string[] args)
    {
        var countOption = new Option<int>(
            name: "--count",
            description: "How many fruits to generate");

        var rootCommand = new RootCommand("Random Fruit");
        rootCommand.AddOption(countOption);
        rootCommand.SetHandler((name) => { RandomFruit(name!); }, countOption);
        return await rootCommand.InvokeAsync(args);
    }

    //generates a random fruit and accepts a count
    static void RandomFruit(int count)
    {
       //use RandomNumber method to generate a random number
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(fruits.Count);
            Console.WriteLine(fruits[index]);
        }
    }



}
