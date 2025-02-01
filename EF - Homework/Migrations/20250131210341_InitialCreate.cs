using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF___Homework.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarColor_Cars_CarId",
                table: "CarColor");

            migrationBuilder.DropForeignKey(
                name: "FK_CarColor_Colors_ColorId",
                table: "CarColor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarColor",
                table: "CarColor");

            migrationBuilder.RenameTable(
                name: "CarColor",
                newName: "ColorsColor");

            migrationBuilder.RenameIndex(
                name: "IX_CarColor_ColorId",
                table: "ColorsColor",
                newName: "IX_ColorsColor_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_CarColor_CarId",
                table: "ColorsColor",
                newName: "IX_ColorsColor_CarId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorsColor_Cars_CarId",
                table: "ColorsColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorsColor_Colors_ColorId",
                table: "ColorsColor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorsColor",
                table: "ColorsColor");

            migrationBuilder.RenameTable(
                name: "ColorsColor",
                newName: "CarColor");

            migrationBuilder.RenameIndex(
                name: "IX_ColorsColor_ColorId",
                table: "CarColor",
                newName: "IX_CarColor_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_ColorsColor_CarId",
                table: "CarColor",
                newName: "IX_CarColor_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarColor",
                table: "CarColor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarColor_Cars_CarId",
                table: "CarColor",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarColor_Colors_ColorId",
                table: "CarColor",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
