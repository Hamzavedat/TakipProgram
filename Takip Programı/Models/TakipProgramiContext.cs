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
                command.CommandText = "CREATE TABLE IF NOT EXISTS 'Customer' ('Id' INTEGER NOT NULL, 'Name' TEXT, 'Surname' TEXT, 'Risk' INTEGER NOT NULL, 'Change'  INTEGER NOT NULL, 'Position' TEXT, 'Phone'  TEXT, 'MobilePhone' TEXT, 'VergiDairesi' TEXT, 'VergiNo' TEXT, 'Adress'  TEXT,	'TotalDebt'	REAL,'ProductDebtList' TEXT, 'PruductDebtNumberList' TEXT, CONSTRAINT 'PK_Customer' PRIMARY KEY('Id' AUTOINCREMENT))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS 'ProductDefine' ( 'Id' INTEGER NOT NULL, 'Name' TEXT, 'Type' TEXT, 'Amount' REAL NOT NULL, 'BuyPrice' REAL NOT NULL, 'SellPrice' REAL NOT NULL, 'BuyAmount' REAL NOT NULL, 'SellAmount' REAL NOT NULL, CONSTRAINT 'PK_ProductDefine' PRIMARY KEY('Id' AUTOINCREMENT))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS 'PumpDefine'('Id' INTEGER NOT NULL, 'InitialCounter' REAL NOT NULL, 'PumpName' TEXT, 'WareHouseId' INTEGER, 'Counter' REAL, CONSTRAINT 'FK_PumpDefine_WareHouseDefine_WareHouseId' FOREIGN KEY('WareHouseId') REFERENCES 'WareHouseDefine'('Id') ON DELETE RESTRICT, CONSTRAINT 'PK_PumpDefine' PRIMARY KEY('Id' AUTOINCREMENT))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS 'PumpFormModel' ( 'Id' INTEGER NOT NULL, 'WorkDate' TEXT NOT NULL, 'PersonName' TEXT, 'FirstCounter' TEXT, 'LastCounter' TEXT, 'Difference' TEXT, 'Amount' TEXT, 'PumpDefineId' INTEGER, 'Price' NUMERIC, CONSTRAINT 'FK_PumpFormModel_PumpDefine_PumpDefineId' FOREIGN KEY('PumpDefineId') REFERENCES 'PumpDefine'('Id') ON DELETE RESTRICT, CONSTRAINT 'PK_PumpFormModel' PRIMARY KEY('Id' AUTOINCREMENT))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS 'User' ( 'Id' INTEGER NOT NULL, 'Username' TEXT, 'Password' TEXT, 'Role' TEXT, CONSTRAINT 'PK_User' PRIMARY KEY('Id' AUTOINCREMENT))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS 'WareHouseDefine' ( 'Id' INTEGER NOT NULL, 'WareHouseName' TEXT, 'WareHouseVolume' NUMERIC NOT NULL, 'WareHouseStock' NUMERIC NOT NULL, 'ProductDefineId' INTEGER, CONSTRAINT 'FK_WareHouseDefine_ProductDefine_ProductDefineId' FOREIGN KEY('ProductDefineId') REFERENCES 'ProductDefine'('Id') ON DELETE RESTRICT, CONSTRAINT 'PK_WareHouseDefine' PRIMARY KEY('Id' AUTOINCREMENT))";
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
