using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
            using (SQLiteConnection con = new SQLiteConnection("Data Source=TakipProgramiDb.db"))   
            using (SQLiteCommand command = con.CreateCommand())
            {
                con.Open();
                command.CommandText = "CREATE TABLE IF NOT EXISTS 'Customer' ('Id' INTEGER NOT NULL, 'Name' TEXT, 'Surname' TEXT, 'Risk' INTEGER NOT NULL, 'Change'  INTEGER NOT NULL, 'Position' TEXT, 'Phone'  TEXT, 'MobilePhone' TEXT, 'VergiDairesi'    TEXT, 'VergiNo' TEXT, 'Adress'  TEXT, CONSTRAINT 'PK_Customer' PRIMARY KEY('Id' AUTOINCREMENT))";
                command.ExecuteNonQuery();
             
                /*command.CommandText  = "SELECT name FROM sqlite_master WHERE name='User2'";
                var name = command.ExecuteScalar();
                if (name == null)
                {
                  
                    
                    command.CommandText = "INSERT 'User2' ('Id' INTEGER NOT NULL, 'Username' TEXT, 'Password' TEXT, 'Role' TEXT, CONSTRAINT 'PK_User' PRIMARY KEY('Id' AUTOINCREMENT) )";
                    command.ExecuteNonQuery();
                }*/
            }

           
        }
        public DbSet<User> User { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<ProductDefine> ProductDefine { get; set; }
        public DbSet<PumpDefine> PumpDefine { get; set; }
        public DbSet<WareHouse> WareHouseDefine { get; set; }
        public DbSet<PumpFormModel> PumpFormModel { get; set; }
    }
}
