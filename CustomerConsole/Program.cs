using System.Xml.Linq;

namespace CustomerConsole
{
    internal class Program
    {
        private static void RemoveConsole(Shop shop)
        {
            string[] itemSringList = shop.GetItemsList();
            if (itemSringList is null) return;

            foreach (var item in itemSringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press id of item to remove it.");
            var removeId = Console.ReadLine();
            int removeIdInt;
            bool complite = int.TryParse(removeId, out removeIdInt);
            if (!complite) return;

            if (shop.Remove(removeIdInt))
            {
                Console.WriteLine($"{removeId} удалён.");
            }
            else
            {
                Console.WriteLine($"{removeId} ошибка удалёнения.");
            }
        }
        private static void AddConsole(Shop shop)
        {
            Console.WriteLine("Please enter id of item:");
            string id = Console.ReadLine();
            int idInt;
            bool complite = int.TryParse(id, out idInt);
            if (!complite) return;

            Console.WriteLine("Please enter name of item:");
            string name = Console.ReadLine();

            if (shop.Add(new Item(idInt, name + " " + DateTime.Now.ToString())))
            {
                Console.WriteLine($"{idInt} {name} {DateTime.Now} добавлена.");
            }
            else
            {
                Console.WriteLine($"{idInt} {name} {DateTime.Now} ошибка добавления.");
            }
        }
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Customer customer = new Customer();
            shop.items.CollectionChanged += customer.OnItemChanged;
            while (true)
            {
                Console.WriteLine("Press 'A' to add item, 'D' to delete item, 'X' to exit program");
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        {
                            AddConsole(shop);
                        }
                        break;
                    case ConsoleKey.D:
                        {
                            RemoveConsole(shop);
                        }
                        break;
                    case ConsoleKey.X:
                        {
                            Console.WriteLine("Program close success.");
                            shop.items.CollectionChanged -= customer.OnItemChanged;
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
