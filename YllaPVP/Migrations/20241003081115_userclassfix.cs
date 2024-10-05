using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YllaPVP.Migrations
{
    /// <inheritdoc />
    public partial class userclassfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserClass",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserClass",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
