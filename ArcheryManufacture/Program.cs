namespace ArcheryManufacture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> warehouseItems = new();

            List<string> workshopItems = new();

            Console.WriteLine("Welcome To The Achery Workshop");
            Console.WriteLine("==============================");
            Console.WriteLine();

            bool CloseApp = false;

            while (!CloseApp)
            {
                Console.WriteLine("Where do You want to go: \r\n 1. Warehouse \r\n 2. Workshop \r\n 3. Exit");

                Console.WriteLine("= = = = = = = = ");
                var chooseFromFirstMenu = Console.ReadLine();
                Console.WriteLine("= = = = = = = = ");

                switch (chooseFromFirstMenu)
                {
                    case "1":
                        Console.WriteLine("Welcome to Warehouse.");
                        Console.WriteLine("- - - - - - - - - - ");
                        break;
                    case "2":
                        Console.WriteLine("Welcome to Workshop.");
                        Console.WriteLine("- - - - - - - - - - ");
                        break;
                    case "3":
                        CloseApp = true;
                        break;
                    default:
                        Console.WriteLine("Check what You have chosen.");
                        Console.WriteLine("- - - - - - - - - - - - - - ");
                        break;
                }

                if (chooseFromFirstMenu == "1")
                {
                    Console.WriteLine("What Do You Want To Do? : ");
                    Console.WriteLine("1. Add Item To Warehouse.");
                    Console.WriteLine("2. Remove Item From Warehouse.");
                    Console.WriteLine("3. To See List Of Items In Warehouse");

                    Console.WriteLine("= = = = = = = = ");
                    var chooseFromSecondMenu = Console.ReadLine();
                    Console.WriteLine("= = = = = = = = ");

                    if (chooseFromSecondMenu == "1")
                    {
                        Console.WriteLine("Please Type The Name Of Item,\r\n ... Or Type END To Finish.");
                        Console.WriteLine("= = = = = = = = ");
                        while (true)
                        {
                            string input = Console.ReadLine().ToUpper();
                            if (input == "END")
                            {
                                break;
                            }
                            warehouseItems.Add(input);
                        }
                    }
                    else if (chooseFromSecondMenu == "2")
                    {
                        Console.WriteLine("This Is The List Of Items In Warehouse... ");
                        if (warehouseItems.Count == 0)
                        {
                            Console.WriteLine("Warehouse Is Empty");
                            Console.WriteLine("");
                        }
                        else
                        {
                            foreach (string items in warehouseItems)
                            {
                                Console.WriteLine(items);
                            }
                        }

                        Console.WriteLine("\n Whitch Item Do You Want To Remove? Type Its Name.");
                        string itemToRemove = Console.ReadLine().ToUpper();

                        if (warehouseItems.Contains(itemToRemove))
                        {
                            warehouseItems.Remove(itemToRemove);
                            Console.WriteLine($"Item {itemToRemove} Has Been Removed");
                        }
                        else
                        {
                            Console.WriteLine($"{itemToRemove} Is Not In Warehouse");
                        }
                        Console.WriteLine("This Is The List In Warehous After Your Upgrade");

                        foreach (string items in warehouseItems)
                        {
                            Console.WriteLine(items);
                        }
                    }
                    else if (chooseFromSecondMenu == "3")
                    {
                        Console.WriteLine("So... What We Have Hire:");
                        if (warehouseItems.Count == 0)
                        {
                            Console.WriteLine("Warehouse Is Empty");
                            Console.WriteLine("");
                        }
                        else
                        {
                            foreach (string items in warehouseItems)
                            {
                                Console.WriteLine(items);
                            }
                        }
                    }
                }
                else if (chooseFromFirstMenu == "2")
                {

                    Console.WriteLine("What Do You Want To Create? : ");
                    Console.WriteLine("1. Bow.");
                    Console.WriteLine("2. Dozen Arrows.");
                    Console.WriteLine("3. Archery Target.");

                    Console.WriteLine("= = = = = = = = ");
                    var chooseFromThirdMenu = Console.ReadLine();
                    Console.WriteLine("= = = = = = = = ");

                    if (chooseFromThirdMenu == "1")
                    {
                        Console.WriteLine("If You Want To Create The Bow - You Need Below Mentioned Materials: \r\n WOOD, THREAD, OIL, ANIMAL HORN.");
                        Console.WriteLine("= = = = = = = = ");
                        Console.WriteLine("Do You Want To Try To Create A Bow ? ");
                        Console.Write("Type YES or NO : ");
                        var yesOrNoType = Console.ReadLine().ToUpper();

                        if (yesOrNoType == "YES")
                        {
                            bool itemsForBow = warehouseItems.Contains("WOOD") && warehouseItems.Contains("THREAD") &&
                            warehouseItems.Contains("OIL") && warehouseItems.Contains("ANIMAL HORN");

                            if (itemsForBow)
                            {
                                Console.WriteLine("You Have All Needed Materials, so You Created The Bow. \r\n CONGRATULATION :-) ");
                                Console.WriteLine("The BOW Has Been Added to Warehouse");
                                warehouseItems.Add("BOW");
                                warehouseItems.Remove("WOOD");
                                warehouseItems.Remove("THREAD");
                                warehouseItems.Remove("OIL");
                                warehouseItems.Remove("ANIMAL HORN");
                            }
                            else
                            {
                                Console.WriteLine("So Sorry, But You Do Not Have All Needed Materials.");
                                Console.WriteLine("You Can Not Create A Bow :-/ ");
                            }
                        }
                    }

                    if (chooseFromThirdMenu == "2")
                    {
                        Console.WriteLine("If You Want To Create Dozen Arrows - You Need Below Mentioned Materials: \r\n WOOD, METAL, FEATHER.");
                        Console.WriteLine("= = = = = = = = ");
                        Console.WriteLine("Do You Want To Try To Create A Dozen Arrows ? ");
                        Console.Write("Type YES or NO : ");
                        var yesOrNoType = Console.ReadLine().ToUpper();

                        if (yesOrNoType == "YES")
                        {
                            bool itemsForBow = warehouseItems.Contains("WOOD") && warehouseItems.Contains("METAL") &&
                            warehouseItems.Contains("FEATHER");

                            if (itemsForBow)
                            {
                                Console.WriteLine("You Have All Needed Materials, so You Created Dozen Arrows. \r\n CONGRATULATION :-) ");
                                Console.WriteLine("The DOZEN ARROWS Has Been Added to Warehouse");
                                warehouseItems.Add("DOZEN ARROWS");
                                warehouseItems.Remove("WOOD");
                                warehouseItems.Remove("METAL");
                                warehouseItems.Remove("FEATHER");
                            }
                            else
                            {
                                Console.WriteLine("So Sorry, But You Do Not Have All Needed Materials.");
                                Console.WriteLine("You Can Not Create A Dozen Arrows :-/ ");
                            }
                        }
                    }

                    if (chooseFromThirdMenu == "3")
                    {
                        Console.WriteLine("If You Want To Create The Archery Target - You Need Below Mentioned Material: \r\n WOOD.");
                        Console.WriteLine("= = = = = = = = ");
                        Console.WriteLine("Do You Want To Try To Create The Archery Target ? ");
                        Console.Write("Type YES or NO : ");
                        var yesOrNoType = Console.ReadLine().ToUpper();

                        if (yesOrNoType == "YES")
                        {
                            bool itemsForBow = warehouseItems.Contains("WOOD");

                            if (itemsForBow)
                            {
                                Console.WriteLine("You Have All Needed Materials, so You Created The Archery Target. \r\n CONGRATULATION :-) ");
                                Console.WriteLine("The ARCHERY TARGET Has Been Added to Warehouse");
                                warehouseItems.Add("ARCHERY TARGET");
                                warehouseItems.Remove("WOOD");
                            }
                            else
                            {
                                Console.WriteLine("So Sorry, But You Do Not Have All Needed Materials.");
                                Console.WriteLine("You Can Not Create A Bow :-/ ");
                            }
                        }
                    }
                }
                else if (chooseFromFirstMenu == "3")
                {
                    Console.WriteLine("Press any key to live.");
                    CloseApp = true;
                    Console.ReadLine();
                }
            }
        }
    }
}