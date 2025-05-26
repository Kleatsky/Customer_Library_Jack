using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole
{
    internal class Customer
    {

        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            var shop = sender is ObservableCollection<Item>;

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        foreach (Item item in e.NewItems)
                        {
                            Console.WriteLine("Item added " + item.Id + " " + item.Name);
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    {
                        foreach (Item item in e.OldItems)
                        {
                            Console.WriteLine("Item remove " + item.Id + " " + item.Name);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
