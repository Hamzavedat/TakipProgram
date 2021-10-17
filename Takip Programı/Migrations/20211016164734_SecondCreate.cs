using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Takip_Programı.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "InitialCounter",
                table: "PumpDefine",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "PumpFormModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WorkDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PersonName = table.Column<string>(type: "TEXT", nullable: true),
                    NewCounter = table.Column<string>(type: "TEXT", nullable: true),
                    FirstCounter = table.Column<string>(type: "TEXT", nullable: true),
                    LastCounter = table.Column<string>(type: "TEXT", nullable: true),
                    Difference = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<string>(type: "TEXT", nullable: true),
                    PumpDefineId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PumpFormModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PumpFormModel_PumpDefine_PumpDefineId",
                        column: x => x.PumpDefineId,
                        principalTable: "PumpDefine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PumpFormModel_PumpDefineId",
                table: "PumpFormModel",
                column: "PumpDefineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PumpFormModel");

            migrationBuilder.AlterColumn<int>(
                name: "InitialCounter",
                table: "PumpDefine",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
