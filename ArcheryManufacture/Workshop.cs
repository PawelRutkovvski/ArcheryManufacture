using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Metody dla innych przedmiotów warsztatu można dodać podobnie
        // ...

        // Inne metody związane z funkcjonalnością warsztatu można dodać tutaj
    }
}
