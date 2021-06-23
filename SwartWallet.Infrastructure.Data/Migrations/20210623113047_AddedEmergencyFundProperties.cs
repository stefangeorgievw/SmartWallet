using Microsoft.EntityFrameworkCore.Migrations;

namespace SwartWallet.Infrastructure.Data.Migrations
{
    public partial class AddedEmergencyFundProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CurrentEmergencyFund",
                table: "Accounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpentedEmergencyFund",
                table: "Accounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentEmergencyFund",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ExpentedEmergencyFund",
                table: "Accounts");
        }
    }
}
