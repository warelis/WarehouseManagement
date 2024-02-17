using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Item
    {
        public static int id;
        public string name;
        public static int countChemistryEntry;
        public static int countPaperEntry;
        public static int countSoapEntry;
        public static int quantityChemistry;
        public static int quantityPaper;
        public static int quantitySoap;
        public static int countUnknown;

        public Item() { }
        public Item(string name, int quantity)
        {
            this.name = name;
            if (name == "chemistry")
            {
                countChemistryEntry++;
                quantityChemistry += quantity;
            }
            else if(name == "paper")
            {
                countPaperEntry++;
                quantityPaper += quantity;
            }
            else if (name == "soap")
            {
                countSoapEntry++;
                quantitySoap += quantity;
            }
            else
            {
                countUnknown++;
            }
        }
        public void ShowChemistry()
        {
            Console.WriteLine("Chemistry quantity: {0}, chemistry entries: {1}", quantityChemistry, countChemistryEntry);
        }
        public void ShowPaper()
        {
            Console.WriteLine("Paper quantity: {0}, paper entries: {1}", quantityPaper, countPaperEntry);
        }
        public void ShowSoap()
        {
            Console.WriteLine("Soap quantity: {0}, soap entries: {1}", quantitySoap, countSoapEntry);
        }



    }
}
