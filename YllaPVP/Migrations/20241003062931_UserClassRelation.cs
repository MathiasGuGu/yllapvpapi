using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YllaPVP.Migrations
{
    /// <inheritdoc />
    public partial class UserClassRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Classes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Classes",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Classes",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "ClassUser",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassUser", x => new { x.ClassesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ClassUser_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassUser_UsersId",
                table: "ClassUser",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassUser");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Classes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Classes",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classes",
                newName: "id");
        }
    }
}
