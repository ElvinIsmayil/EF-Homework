using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF___Homework.Migrations
{
    /// <inheritdoc />
    public partial class ProjectReady : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorsColor_Cars_CarId",
                table: "ColorsColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorsColor_Colors_ColorId",
                table: "ColorsColor");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorsColor",
                table: "ColorsColor");

            migrationBuilder.RenameTable(
                name: "ColorsColor",
                newName: "CarColors");

            migrationBuilder.RenameIndex(
                name: "IX_ColorsColor_ColorId",
                table: "CarColors",
                newName: "IX_CarColors_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_ColorsColor_CarId",
                table: "CarColors",
                newName: "IX_CarColors_CarId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarColors",
                table: "CarColors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarColors_Cars_CarId",
                table: "CarColors",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarColors_Colors_ColorId",
                table: "CarColors",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarColors_Cars_CarId",
                table: "CarColors");

            migrationBuilder.DropForeignKey(
                name: "FK_CarColors_Colors_ColorId",
                table: "CarColors");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarColors",
                table: "CarColors");

            migrationBuilder.RenameTable(
                name: "CarColors",
                newName: "ColorsColor");

            migrationBuilder.RenameIndex(
                name: "IX_CarColors_ColorId",
                table: "ColorsColor",
                newName: "IX_ColorsColor_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_CarColors_CarId",
                table: "ColorsColor",
                newName: "IX_ColorsColor_CarId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorsColor",
                table: "ColorsColor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorsColor_Cars_CarId",
                table: "ColorsColor",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorsColor_Colors_ColorId",
                table: "ColorsColor",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
