using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapicore.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "product");

            migrationBuilder.CreateTable(
                name: "Band",
                schema: "product",
                columns: table => new
                {
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BandDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Band", x => x.BandId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Band",
                schema: "product");
        }
    }
}
