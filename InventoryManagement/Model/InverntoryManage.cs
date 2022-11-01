using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class InverntoryManage
    {
        public List<CommonProperties>? Stocks { get; set; }

    }
    public class CommonProperties
    {
        public string? StockName { get; set; }
        public int  NumOfShares { get; set; }
        public int SharePrice { get; set; }
    }
}
