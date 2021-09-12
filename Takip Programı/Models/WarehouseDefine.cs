using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class WarehouseDefine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int BuyAmount { get; set; }
        public int SellAmount { get; set; }
    }
}
