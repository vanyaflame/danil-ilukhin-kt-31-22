using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_professor_id_cafedre",
                table: "cd_professor");

            migrationBuilder.DropIndex(
                name: "idx+cd_cafedre_fk_f_professor_id",
                table: "cd_cafedre");

            migrationBuilder.RenameTable(
                name: "cd_cafedre",
                newName: "Cafedres");

            migrationBuilder.AddColumn<int>(
                name: "CafedreId1",
                table: "cd_professor",
                type: "integer",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "Cafedres",
                newName: "cd_cafedre");

            migrationBuilder.CreateIndex(
                name: "idx+cd_cafedre_fk_f_professor_id",
                table: "cd_cafedre",
                column: "f_professor_id");

            migrationBuilder.AddForeignKey(
                name: "fk_f_professor_id_cafedre",
                table: "cd_professor",
                column: "professor_id",
                principalTable: "cd_cafedre",
                principalColumn: "cafedre_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
