using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole
{
    internal class Shop
    {
        public ObservableCollection<Item> items;
        public Shop()
        {
            items = new ObservableCollection<Item>();
        }
        public bool Add(Item newItem)
        {
            try
            {
                foreach (Item item in items)
                {
                    if (item.Id == newItem.Id) return false;
                }
                items.Add(newItem);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Add(int id, string name)
        {
            try
            {
                foreach (Item item in items)
                {
                    if (item.Id == id) return false;
                }
                items.Add(new Item(id, name + DateTime.Now.ToString()));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string[] GetItemsList()
        {
            string[] returnStrings = new String[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                returnStrings[i] = items[i].Id.ToString() + " " + items[i].Name;//id + name: "13 Table"
            }
            return returnStrings;
        }
        public bool Remove(int id)
        {
            foreach (Item item in items)
            {
                if (item.Id == id)
                {
                    items.Remove(item);
                    return true;
                }
            }
            return false;
        }
    }
}
