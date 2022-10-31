namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Wel-Come to Inventory_Management");
            InventoryManager inventoryManager = new InventoryManager();
            inventoryManager.CalculateInventoryValue();
        }
    }
}