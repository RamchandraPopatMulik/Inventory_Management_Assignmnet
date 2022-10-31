namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory_Management");
            InventoryManager inventoryManager = new InventoryManager();
            inventoryManager.CalculateInventoryValue();
        }
    }
}