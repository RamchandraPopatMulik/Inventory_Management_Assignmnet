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

            foreach (var Rice in InventoryData.Rice)
            {
                Console.WriteLine(
                    Rice.Name + "\n" +
                    Rice.Weight + "\n" +
                    Rice.PricePerKg
                    );
                int totalPrice = Rice.PricePerKg*Rice.Weight;
                Console.WriteLine($"Total Price of {totalPrice}");
            }
            foreach (var Pulses in InventoryData.Pulses)
            {
                Console.WriteLine(
                    Pulses.Name + "\n" +
                    Pulses.Weight + "\n" +
                    Pulses.PricePerKg
                    );
                int totalPrice = Pulses.PricePerKg * Pulses.Weight;
                Console.WriteLine($"Total Price of {totalPrice}");
            }
            foreach (var Wheats in InventoryData.Wheats)
            {
                Console.WriteLine(
                    Wheats.Name + "\n" +
                    Wheats.Weight + "\n" +
                    Wheats.PricePerKg
                    );
                int totalPrice = Wheats.PricePerKg * Wheats.Weight;
                Console.WriteLine($"Total Price of {totalPrice}");
            }

            Console.WriteLine("\nInventory(Weight in Kg, Price in Rs.)\n" + jsonData);
            Console.ReadLine();
        }
    }
}
