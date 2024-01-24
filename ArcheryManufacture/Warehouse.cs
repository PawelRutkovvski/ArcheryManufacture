using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryManufacture
{
    public class Warehouse
    {
        private List<string> items = new List<string>();

        public void DisplayItems()
        {
            Console.WriteLine("So... What We Have Here:");
            if (items.Count == 0)
            {
                Console.WriteLine("Warehouse Is Empty\n");
            }
            else
            {
                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void AddItem(string itemName)
        {
            items.Add(itemName);
        }

        public void RemoveItem(string itemName)
        {
            if (items.Contains(itemName))
            {
                items.Remove(itemName);
                Console.WriteLine($"Item {itemName} Has Been Removed");
            }
            else
            {
                Console.WriteLine($"{itemName} Is Not In Warehouse");
            }
        }

        public bool ContainsItems(List<string> requiredItems)
        {
            foreach (var item in requiredItems)
            {
                if (!items.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }

        public void RemoveItems(List<string> itemsToRemove)
        {
            foreach (var item in itemsToRemove)
            {
                items.Remove(item);
            }
        }
    }
}