using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Risk { get; set; }
        public int Change { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adress { get; set; }
        public string ChangeText { 
            get {
                return Change == 1 ? "Etkilensin" : "Etkilenmesin";    
            } 
        }
    }
}
