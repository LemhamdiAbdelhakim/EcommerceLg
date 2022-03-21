using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceLg.Data.Migrations
{
    public partial class AjouterTableSubCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Produits",
                newName: "SubCategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Produits_CategoryId",
                table: "Produits",
                newName: "IX_Produits_SubCategoriesId");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_SubCategories_SubCategoriesId",
                table: "Produits",
                column: "SubCategoriesId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_SubCategories_SubCategoriesId",
                table: "Produits");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "SubCategoriesId",
                table: "Produits",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Produits_SubCategoriesId",
                table: "Produits",
                newName: "IX_Produits_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategoryId",
                table: "Produits",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
