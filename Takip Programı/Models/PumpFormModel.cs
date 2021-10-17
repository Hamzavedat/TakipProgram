using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class PumpFormModel
    {
        public int Id { get; set; }
        public string WorkDate { get; set; }
        public string PersonName { get; set; }
        public double FirstCounter { get; set; }
        public double LastCounter { get; set; }
        public double Difference { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public PumpDefine PumpDefine { get; set; }
    }
}
