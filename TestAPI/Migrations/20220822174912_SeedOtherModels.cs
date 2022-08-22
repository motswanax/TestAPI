using Microsoft.EntityFrameworkCore.Migrations;

namespace TestAPI.Migrations
{
    public partial class SeedOtherModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[] { 1, "Plot 123 Broadhurst", 1, "Absa Bank" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "BankId", "Name" },
                values: new object[] { 1, 1, "Broadhurst" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
