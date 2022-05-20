using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiOne.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationNum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchBankAddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditManagerId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCurrent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Snils = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditType = table.Column<int>(type: "int", nullable: false),
                    RequestedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequestedCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScoringStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationNum);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
