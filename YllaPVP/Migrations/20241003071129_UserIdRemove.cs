using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YllaPVP.Migrations
{
    /// <inheritdoc />
    public partial class UserIdRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClass_Users_UserId1",
                table: "UserClass");

            migrationBuilder.DropIndex(
                name: "IX_UserClass_UserId1",
                table: "UserClass");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserClass");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserClass",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_UserClass_UserId",
                table: "UserClass",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass");

            migrationBuilder.DropIndex(
                name: "IX_UserClass_UserId",
                table: "UserClass");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserClass",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClass_UserId1",
                table: "UserClass",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClass_Users_UserId1",
                table: "UserClass",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
