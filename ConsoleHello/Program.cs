namespace HelloWorld
{
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        
        // write a method that I can call from the main method
        static void SayHello()
        {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        // Ask for numbers
        Console.WriteLine("Number 1?");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number 2?");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Add(num1, num2);
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
        }
        
        static void Main(string[] args)
        {
            SayHello();
        }
    }
}