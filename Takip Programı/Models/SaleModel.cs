using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class SaleModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductNumber { get; set; }
        public double ProductPrice { get; set; }
        public double ProductTotalPrice { get; set; }
    }
}
