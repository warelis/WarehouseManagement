namespace Warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] item = [new Item("chemistry", 50), new Item("chemistry", 100)];
            foreach (Item i in item)
            {
                i.ShowChemistry();
            }
            

            
        }
    }
}
