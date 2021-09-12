using Microsoft.EntityFrameworkCore.Migrations;

namespace Takip_Programı.Migrations
{
    public partial class WarehouseDefineCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WarehouseDefine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    BuyPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    SellPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    BuyAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    SellAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseDefine", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarehouseDefine");
        }
    }
}
