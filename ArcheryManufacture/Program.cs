using System;
using System.Collections.Generic;

namespace ArcheryManufacture
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Workshop workshop = new Workshop();

            bool closeApp = false;

            while (!closeApp)
            {
                Console.WriteLine("Where do You want to go: \r\n 1. Warehouse \r\n 2. Workshop \r\n 3. Exit");

                Console.WriteLine("= = = = = = = = ");
                var chooseFromMainMenu = Console.ReadLine();
                Console.WriteLine("= = = = = = = = ");

                switch (chooseFromMainMenu)
                {
                    case "1":
                        Console.WriteLine("Welcome To Warehouse.");
                        MenuSets.ShowWarehouseMenu(warehouse);
                        break;
                    case "2":
                        Console.WriteLine("Welcome To Workshop.");
                        MenuSets.ShowWorkshopMenu(workshop, warehouse);
                        break;
                    case "3":
                        closeApp = true;
                        break;
                    default:
                        Console.WriteLine("Check What You Have Chosen.");
                        Console.WriteLine("- - - - - - - - - - - - - - ");
                        break;
                }
            }
        }
    }
}

