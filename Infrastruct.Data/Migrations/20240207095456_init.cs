using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionArcProject.Infrastruct.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "venders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Marketshare = table.Column<float>(name: "Market share", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("venders_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gpus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Frequency = table.Column<float>(type: "real", nullable: false),
                    VenderId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gpus_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "gpus_VenderId_fkey",
                        column: x => x.VenderId,
                        principalTable: "venders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_gpus_VenderId",
                table: "gpus",
                column: "VenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gpus");

            migrationBuilder.DropTable(
                name: "venders");
        }
    }
}
