namespace CustomerConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 'A' to add item, 'D' to delete item, 'X' to exit program");
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        {

                        }
                        break;
                        case ConsoleKey.D:
                        {

                        }
                        break;
                        case ConsoleKey.X:
                        {
                            Console.WriteLine("Program close success.");
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
