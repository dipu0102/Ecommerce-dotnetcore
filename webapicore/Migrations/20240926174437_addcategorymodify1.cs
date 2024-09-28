using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapicore.Migrations
{
    /// <inheritdoc />
    public partial class addcategorymodify1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryId",
                schema: "Product",
                table: "Category",
                column: "ParentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentCategoryId",
                schema: "Product",
                table: "Category",
                column: "ParentCategoryId",
                principalSchema: "Product",
                principalTable: "Category",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_ParentCategoryId",
                schema: "Product",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ParentCategoryId",
                schema: "Product",
                table: "Category");
        }
    }
}
