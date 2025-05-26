using System.Collections.Concurrent;

namespace LibraryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine("Введите название книги:");
                            string newbook = Console.ReadLine();
                            if (library.AddBook(newbook))
                            {
                                Console.WriteLine(newbook + " добавлена.");
                            }
                            else
                            {
                                Console.WriteLine(newbook + " такая книга уже есть.");
                            }
                        }
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        {
                            (string name, int percent)[] books = library.GetAllBooks();
                            if (books is null)
                            {
                                Console.WriteLine("Нет ни одной книги.");
                            }
                            else
                            {
                                foreach (var book in books)
                                {
                                    Console.WriteLine($"{book.name} - {book.percent}%");
                                }
                            }
                        }
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
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
