using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapicore.Migrations
{
    /// <inheritdoc />
    public partial class addusertoproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                schema: "product",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                schema: "product",
                table: "Product",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Users_UserId",
                schema: "product",
                table: "Product",
                column: "UserId",
                principalSchema: "System",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Users_UserId",
                schema: "product",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_UserId",
                schema: "product",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "product",
                table: "Product");
        }
    }
}
