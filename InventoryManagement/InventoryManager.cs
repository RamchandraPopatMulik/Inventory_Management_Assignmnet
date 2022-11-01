using InventoryManagement.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InventoryManagement
{
    internal class InventoryManager
    {
        public string filepath = @"E:\Basic Core Program\InventoryManagement\Inventory_Management_Assignmnet\InventoryManagement\Model\InventoryData.json";

        public void CalculateInventoryValue()
        {
            var jsonData = File.ReadAllText(filepath);
            var InventoryData = JsonConvert.DeserializeObject<InverntoryManage>(jsonData);

            foreach (var Stocks in InventoryData.Stocks)
            {
                Console.WriteLine(
                    Stocks.StockName + "\n" +
                    Stocks.NumOfShares + "\n" +
                    Stocks.SharePrice
                    );
                int totalPrice = Stocks.NumOfShares*Stocks.SharePrice;
                Console.WriteLine($"Total Price of Shares {totalPrice}");
            }
           
            Console.WriteLine("\nInventory(Weight in Kg, Price in Rs.)\n" + jsonData);
            Console.ReadLine();
        }
    }
}
