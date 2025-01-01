using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSSystem.Migrations
{
    /// <inheritdoc />
    public partial class Corr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Vendor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Items",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Customer",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendor",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Items",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "Code");
        }
    }
}
