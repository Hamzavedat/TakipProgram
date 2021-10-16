using Microsoft.EntityFrameworkCore.Migrations;

namespace Takip_Programı.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Risk = table.Column<int>(type: "INTEGER", nullable: false),
                    Change = table.Column<int>(type: "INTEGER", nullable: false),
                    Position = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: true),
                    VergiDairesi = table.Column<string>(type: "TEXT", nullable: true),
                    VergiNo = table.Column<string>(type: "TEXT", nullable: true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDefine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    BuyPrice = table.Column<double>(type: "REAL", nullable: false),
                    SellPrice = table.Column<double>(type: "REAL", nullable: false),
                    BuyAmount = table.Column<double>(type: "REAL", nullable: false),
                    SellAmount = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDefine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouseDefine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WareHouseName = table.Column<string>(type: "TEXT", nullable: true),
                    WareHouseVolume = table.Column<int>(type: "INTEGER", nullable: false),
                    WareHouseStock = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductDefineId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouseDefine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WareHouseDefine_ProductDefine_ProductDefineId",
                        column: x => x.ProductDefineId,
                        principalTable: "ProductDefine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PumpDefine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PumpName = table.Column<string>(type: "TEXT", nullable: true),
                    InitialCounter = table.Column<int>(type: "INTEGER", nullable: false),
                    WareHouseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PumpDefine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PumpDefine_WareHouseDefine_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "WareHouseDefine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PumpDefine_WareHouseId",
                table: "PumpDefine",
                column: "WareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_WareHouseDefine_ProductDefineId",
                table: "WareHouseDefine",
                column: "ProductDefineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "PumpDefine");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WareHouseDefine");

            migrationBuilder.DropTable(
                name: "ProductDefine");
        }
    }
}
