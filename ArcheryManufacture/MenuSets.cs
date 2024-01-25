using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryManufacture
{
    public class MenuSets
    {
        public static void ShowWarehouseMenu(Warehouse warehouse)
        {
            Console.WriteLine("What Do You Want To Do? : ");
            Console.WriteLine("1. Add Item To Warehouse.");
            Console.WriteLine("2. Remove Item From Warehouse.");
            Console.WriteLine("3. To See List Of Items In Warehouse");

            Console.WriteLine("= = = = = = = = ");
            var chooseFromWarehouseMenu = Console.ReadLine();
            Console.WriteLine("= = = = = = = = ");

            if (chooseFromWarehouseMenu == "1")
            {
                Console.WriteLine("Please Type The Name Of Item, \r\n ... Or Type END To Finish.");
                Console.WriteLine("= = = = = = = = ");
                while (true)
                {
                    string input = Console.ReadLine().ToUpper();
                    if (input == "END")
                    {
                        break;
                    }
                    warehouse.AddItem(input);
                }
            }
            else if (chooseFromWarehouseMenu == "2")
            {
                Console.WriteLine("This Is The List Of Items In Warehouse... ");
                warehouse.DisplayItems();

                Console.WriteLine("\n Which Item Do You Want To Remove? Type Its Name.");
                string itemToRemove = Console.ReadLine().ToUpper();

                warehouse.RemoveItem(itemToRemove);
                Console.WriteLine("This Is The List Of Items In Warehouse After Your Update");
                warehouse.DisplayItems();
            }
            else if (chooseFromWarehouseMenu == "3")
            {
                warehouse.DisplayItems();
            }
        }

        public static void ShowWorkshopMenu(Workshop workshop, Warehouse warehouse)
        {
            Console.WriteLine("What Do You Want To Create? : ");
            Console.WriteLine("1. Bow.");
            Console.WriteLine("2. Dozen Arrows.");
            Console.WriteLine("3. Archery Target.");

            Console.WriteLine("= = = = = = = = ");
            var chooseFromWorkshopMenu = Console.ReadLine();
            Console.WriteLine("= = = = = = = = ");

            if (chooseFromWorkshopMenu == "1")
            {
                workshop.CreateBow(warehouse);
            }
            else if (chooseFromWorkshopMenu == "2")
            {
                workshop.CreateDozenOfArrows(warehouse);
            }
            else if (chooseFromWorkshopMenu == "3")
            {
                workshop.CreateDozenOfArrows(warehouse);
            }
            else Console.WriteLine("Check Your Decision, Please.");

            
        }
    }
}
