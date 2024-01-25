namespace ArcheryManufacture
{
    public class Workshop
    {
        public void CreateBow(Warehouse warehouse)
        {
            Console.WriteLine("If You Want To Create The Bow - You Need Below Mentioned Materials: \r\n WOOD, THREAD, OIL, ANIMAL HORN.");
            Console.WriteLine("= = = = = = = = ");
            Console.WriteLine("Do You Want To Try To Create A Bow ? ");
            Console.Write("Type YES or NO : ");
            var yesOrNoType = Console.ReadLine().ToUpper();

            if (yesOrNoType == "YES")
            {
                bool itemsForBow = warehouse.ContainsItems(new List<string> { "WOOD", "THREAD", "OIL", "ANIMAL HORN" });

                if (itemsForBow)
                {
                    Console.WriteLine("You Have All Needed Materials, so You Created The Bow. \r\n CONGRATULATION :-) ");
                    Console.WriteLine("The BOW Has Been Added to Warehouse");
                    warehouse.AddItem("BOW");
                    warehouse.RemoveItems(new List<string> { "WOOD", "THREAD", "OIL", "ANIMAL HORN" });
                }
                else
                {
                    Console.WriteLine("So Sorry, But You Do Not Have All Needed Materials.");
                    Console.WriteLine("You Can Not Create A Bow :-/ ");
                }
            }
        }

        public void CreateDozenOfArrows(Warehouse warehouse)
        {
            Console.WriteLine("If You Want To Create Dozen Of Arrows - You Need Below Mentioned Materials: \r\n WOOD, METAL, FEATHER");
            Console.WriteLine("= = = = = = = = ");
            Console.WriteLine("Do You Want To Try To Create Dozen Of Arrows ? ");
            Console.Write("Type YES or NO : ");
            var yesOrNoType = Console.ReadLine().ToUpper();

            if(yesOrNoType == "YES")
            {
                Console.WriteLine("You Have All Needed Materials, so You Created Dozen Of Arrows. \r\n CONGRATULATION :-) ");
                Console.WriteLine("Dozen Of Arrows Has Been Added to Warehouse");
                warehouse.AddItem("DOZEN OF ARROWS");
                warehouse.RemoveItems(new List<string> { "WOOD", "METAL HEAD", "FEATHER" });
            }
            else
            {
                Console.WriteLine("Sorry, You Do Not Have All Needed Materials.");
                Console.WriteLine("You Can Not Create Dozen Of Arrows :-/ ");
            }
        }

        public void CreateArcheryTarget(Warehouse warehouse)
        {
            Console.WriteLine("If You Want To Create Archery Target - You Need Below Mentioned Materials: \r\n WOOD ");
            Console.WriteLine("= = = = = = = = ");
            Console.WriteLine("Do You Want To Try To Create Archery Target ? ");
            Console.WriteLine("Type YES or NO : ");
            var yesOrNoType = Console.ReadLine();

            if (yesOrNoType == "YES")
            {
                Console.WriteLine("You Have All Needed Materials, so You Created Archery Target. \r\n CONGRATULATION :-) ");
                Console.WriteLine("Archery Target Has Been Created and Added To Warehouse");
                warehouse.AddItem("ARCHERY TARGET");
                warehouse.RemoveItem("WOOD");
            }
        }
    }
}
