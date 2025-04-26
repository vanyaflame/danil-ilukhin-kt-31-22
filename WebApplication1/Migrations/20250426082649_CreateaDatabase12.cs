using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateaDatabase12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_work_time_cd_discipline_DisciplineId1",
                table: "cd_work_time");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_work_time_cd_professor_ProfessorId1",
                table: "cd_work_time");

            migrationBuilder.DropIndex(
                name: "IX_cd_work_time_DisciplineId1",
                table: "cd_work_time");

            migrationBuilder.DropIndex(
                name: "IX_cd_work_time_ProfessorId1",
                table: "cd_work_time");

            migrationBuilder.DropColumn(
                name: "DisciplineId1",
                table: "cd_work_time");

            migrationBuilder.DropColumn(
                name: "ProfessorId1",
                table: "cd_work_time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplineId1",
                table: "cd_work_time",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId1",
                table: "cd_work_time",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cd_work_time_DisciplineId1",
                table: "cd_work_time",
                column: "DisciplineId1");

            migrationBuilder.CreateIndex(
                name: "IX_cd_work_time_ProfessorId1",
                table: "cd_work_time",
                column: "ProfessorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_work_time_cd_discipline_DisciplineId1",
                table: "cd_work_time",
                column: "DisciplineId1",
                principalTable: "cd_discipline",
                principalColumn: "discipline_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_work_time_cd_professor_ProfessorId1",
                table: "cd_work_time",
                column: "ProfessorId1",
                principalTable: "cd_professor",
                principalColumn: "professor_id");
        }
    }
}
