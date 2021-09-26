using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takip_Programı.Models
{
    public class TakipProgramiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TakipProgramiDb.db");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<ProductDefine> ProductDefine { get; set; }
        public DbSet<PumpDefine> PumpDefine { get; set; }
        public DbSet<WareHouse> WareHouseDefine { get; set; }
    }
}
