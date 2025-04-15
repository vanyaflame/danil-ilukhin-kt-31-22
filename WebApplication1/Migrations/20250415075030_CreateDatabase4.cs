using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_professor_Cafedres_CafedreId1",
                table: "cd_professor");

            migrationBuilder.DropIndex(
                name: "IX_cd_professor_CafedreId1",
                table: "cd_professor");

            migrationBuilder.DropColumn(
                name: "CafedreId1",
                table: "cd_professor");

            migrationBuilder.DropColumn(
                name: "f_professor_id",
                table: "Cafedres");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CafedreId1",
                table: "cd_professor",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "f_professor_id",
                table: "Cafedres",
                type: "int4",
                nullable: false,
                defaultValue: 0,
                comment: "ID профессора");

            migrationBuilder.CreateIndex(
                name: "IX_cd_professor_CafedreId1",
                table: "cd_professor",
                column: "CafedreId1");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_professor_Cafedres_CafedreId1",
                table: "cd_professor",
                column: "CafedreId1",
                principalTable: "Cafedres",
                principalColumn: "cafedre_id");
        }
    }
}
