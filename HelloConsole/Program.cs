using System;

namespace Comprehend
{
    class Program
    {
        static async Task Main(string[] args)
        {

            // Display title
            Console.WriteLine("Hello" + Environment.NewLine);

            // Ask for phrase
            Console.WriteLine("Type in phrase for analysis" + Environment.NewLine);
            var phrase = Console.ReadLine();
            Console.WriteLine("You typed: " + phrase + Environment.NewLine);
            Console.WriteLine("Done");
        }
    }
}
