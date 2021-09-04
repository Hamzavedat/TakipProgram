using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string sifre { get; set; }
        public string role { get; set; }
    }
}
