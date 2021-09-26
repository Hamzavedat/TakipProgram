using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class ProductDefine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public double BuyAmount { get; set; }
        public double SellAmount { get; set; }
    }
}
