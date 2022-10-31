using InventoryManagement.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class InventoryManager
    {
        public string filepath = @"E:\Basic Core Program\InventoryManagement\Inventory_Management_Assignmnet\InventoryManagement\Model\InventoryData.json";

        public void CalculateInventoryValue()
        {
            var jsonData = File.ReadAllText(filepath);
            var InventoryData = JsonConvert.DeserializeObject<InverntoryManage>(jsonData);

            Console.WriteLine(InventoryData.Rice.Name +"\n"+InventoryData.Rice.Weight+"\n"+InventoryData.Rice.PricePerKg+"\n"+ InventoryData.Pulses.Name + "\n" + InventoryData.Pulses.Weight + "\n" + InventoryData.Pulses.PricePerKg + "\n"+ InventoryData.Wheats.Name + "\n" + InventoryData.Wheats.Weight + "\n" + InventoryData.Wheats.PricePerKg + "\n");
            int totalValueForRice = InventoryData.Rice.PricePerKg * InventoryData.Rice.Weight;
            int totalValueForPulses = InventoryData.Pulses.PricePerKg * InventoryData.Pulses.Weight;
            int totalValueForWheats = InventoryData.Wheats.PricePerKg * InventoryData.Wheats.Weight;

            Console.WriteLine($"Total Value for Rice in Rs. :: {totalValueForRice}");
            Console.WriteLine($"Total Value for Pulses in Rs. :: {totalValueForPulses}");
            Console.WriteLine($"Total Value for Wheats in Rs. :: {totalValueForWheats}");
            Console.WriteLine("\nInventory(Weight in Kg, Price in Rs.)\n" + jsonData);
            Console.ReadLine();
        }
    }
}
