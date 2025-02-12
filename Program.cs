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
            Console.WriteLine((numBugs + 1) + " little bugs in the code.");
        }
        public static void DrawBear()
        {
            Console.Write("  ___\r\n{~._.~}\r\n ( Y )\r\n()~*~()\r\n(_)-(_)");
        }
        public static void DrawCrown()
        {
            Console.Write("  _.+._\r\n     (^\\/^\\/^)\r\n      \\@*@*@/\r\n      {_____}");
        }
        public static void DrawBee()
        {
            Console.Write("    _  _\r\n   | )/ )\r\n\\\\ |//,' __\r\n(\")(_)-\"()))=-\r\n   (\\\\");
        }
        public static void KnockKnock()
        {

        }
        static void Main(string[] args)
        {
            int userNum;
            
            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();
            Joke();

            Console.WriteLine();
            Console.WriteLine("For another joke, please enter a random number of your liking:");
            Int32.TryParse(Console.ReadLine(), out userNum);
            Console.WriteLine();
            Joke(userNum);
        }
    }
}
