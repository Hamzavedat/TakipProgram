using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class WareHouse
    {
        public int Id { get; set; }
        public string WareHouseName { get; set; }
        public double WareHouseVolume { get; set; }
        public double WareHouseStock { get; set; }
        public ProductDefine ProductDefine { get; set; }
    }
}
