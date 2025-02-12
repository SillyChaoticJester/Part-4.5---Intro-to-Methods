namespace Part_4._5___Intro_to_Methods
{
    internal class Program
    {
        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");
        }
        public static void Joke(int numBugs)
        {
            Console.WriteLine($"{numBugs} little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine($"{numBugs} little bugs.");
            Thread.Sleep(500);
            Console.WriteLine($"Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine($"{numBugs++} little bugs in the code.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();
            Joke();

            Console.WriteLine("Press ENTER for another joke:");
            Console.ReadLine();
            Joke(50);
        }
    }
}
