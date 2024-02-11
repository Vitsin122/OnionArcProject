using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionArcProject.Infrastruct.Data.Migrations
{
    /// <inheritdoc />
    public partial class AutoGenerateGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Market share",
                table: "venders",
                newName: "MarketShare");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MarketShare",
                table: "venders",
                newName: "Market share");
        }
    }
}
