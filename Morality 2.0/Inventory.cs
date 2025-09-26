using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morality_2._0
{
    using System;
    using System.Collections.Generic;

    class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine($"\nYou have acquired: {item}");
        }

        public bool HasItem(string item)
        {
            return items.Contains(item);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n--- Inventory ---");
            if (items.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
            }
            else
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        } //display inventory en accquire item
    }
}

