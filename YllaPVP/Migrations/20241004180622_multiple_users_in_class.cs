using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YllaPVP.Migrations
{
    /// <inheritdoc />
    public partial class multiple_users_in_class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass");

            migrationBuilder.DropIndex(
                name: "IX_UserClass_UserId",
                table: "UserClass");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserClass");

            migrationBuilder.CreateTable(
                name: "UserUserClass",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUserClass", x => new { x.ClassesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserUserClass_UserClass_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "UserClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUserClass_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserUserClass_UserId",
                table: "UserUserClass",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserUserClass");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserClass_UserId",
                table: "UserClass",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClass_Users_UserId",
                table: "UserClass",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
