using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class PumpDefine
    {
        public int Id { get; set; }
        public string PumpName { get; set; }
        public double InitialCounter { get; set; }
        public double Counter { get; set; }
        public WareHouse WareHouse { get; set; }
    }
}
