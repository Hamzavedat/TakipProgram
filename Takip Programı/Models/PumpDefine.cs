using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class PumpDefine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double LastCounter { get; set; }
        public double NewCounter { get; set; }
        public double Gap { get; set; }
        public double Total { get; set; }
    }
}
