using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_cafedre_id",
                table: "Cafedres");

            migrationBuilder.DropForeignKey(
                name: "fk_f_cafedre_id",
                table: "cd_professor");

            migrationBuilder.DropForeignKey(
                name: "fk_f_professor_id",
                table: "cd_professor");

            migrationBuilder.DropForeignKey(
                name: "fk_f_discipline_id",
                table: "Disciplines");

            migrationBuilder.RenameTable(
                name: "Titles",
                newName: "cd_title");

            migrationBuilder.RenameTable(
                name: "ScienceStates",
                newName: "cd_science_state");

            migrationBuilder.RenameTable(
                name: "Disciplines",
                newName: "cd_discipline");

            migrationBuilder.RenameTable(
                name: "Cafedres",
                newName: "cd_cafedre");

            migrationBuilder.RenameIndex(
                name: "idx+cd_professor_fk_f_cafedre_id",
                table: "cd_professor",
                newName: "IX_cd_professor_f_cafedre_id");

            migrationBuilder.AlterColumn<int>(
                name: "f_professor_id",
                table: "cd_work_time",
                type: "integer",
                nullable: false,
                comment: "ID профессора",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "ID профессора");

            migrationBuilder.AlterColumn<int>(
                name: "f_discipline_id",
                table: "cd_work_time",
                type: "integer",
                nullable: false,
                comment: "ID дисциплины",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "ID дисциплины");

            migrationBuilder.AlterColumn<int>(
                name: "f_cafedre_id",
                table: "cd_work_time",
                type: "integer",
                nullable: false,
                comment: "ID кафедры",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "ID кафедры");

            migrationBuilder.AlterColumn<int>(
                name: "c_work_time_hours",
                table: "cd_work_time",
                type: "INT",
                nullable: false,
                comment: "Количество часов",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Количество часов");

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

            migrationBuilder.AlterColumn<int>(
                name: "f_cafedre_id",
                table: "cd_professor",
                type: "integer",
                nullable: false,
                comment: "ID кафедры",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "ID кафедры");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_title",
                table: "cd_professor",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Должность профессора",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Должность профессора");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_middle_name",
                table: "cd_professor",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Отчество профессора",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Отчество профессора");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_last_name",
                table: "cd_professor",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Фамилия профессора",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Фамилия профессора");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_first_name",
                table: "cd_professor",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Имя профессора",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Имя профессора");

            migrationBuilder.AlterColumn<int>(
                name: "professor_id",
                table: "cd_professor",
                type: "integer",
                nullable: false,
                comment: "Идентификатор записи профессора",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор записи профессора")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "c_title_name",
                table: "cd_title",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Название должности",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Название должности");

            migrationBuilder.AlterColumn<string>(
                name: "c_science_state_name",
                table: "cd_science_state",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Название научной степени",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Название научной степени");

            migrationBuilder.AlterColumn<string>(
                name: "c_discipline_name",
                table: "cd_discipline",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Название дисциплины",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Название дисциплины");

            migrationBuilder.AlterColumn<int>(
                name: "discipline_id",
                table: "cd_discipline",
                type: "integer",
                nullable: false,
                comment: "Идентификатор записи дисциплины",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор записи дисциплины")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "c_cafedre_name",
                table: "cd_cafedre",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Название кафедры",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Название кафедры");

            migrationBuilder.AlterColumn<string>(
                name: "c_cafedre_main_professor",
                table: "cd_cafedre",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "Старший преподаватель кафедры",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 100,
                oldComment: "Старший преподаватель кафедры");

            migrationBuilder.AlterColumn<int>(
                name: "c_cafedre_creation_date",
                table: "cd_cafedre",
                type: "INT",
                nullable: false,
                comment: "Дата основания кафедры",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Дата основания кафедры");

            migrationBuilder.AlterColumn<int>(
                name: "cafedre_id",
                table: "cd_cafedre",
                type: "integer",
                nullable: false,
                comment: "Идентификатор записи кафедры",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор записи кафедры")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_cd_work_time_DisciplineId1",
                table: "cd_work_time",
                column: "DisciplineId1");

            migrationBuilder.CreateIndex(
                name: "IX_cd_work_time_ProfessorId1",
                table: "cd_work_time",
                column: "ProfessorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_professor_cd_cafedre_f_cafedre_id",
                table: "cd_professor",
                column: "f_cafedre_id",
                principalTable: "cd_cafedre",
                principalColumn: "cafedre_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_work_time_cd_cafedre_f_cafedre_id",
                table: "cd_work_time",
                column: "f_cafedre_id",
                principalTable: "cd_cafedre",
                principalColumn: "cafedre_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_work_time_cd_discipline_DisciplineId1",
                table: "cd_work_time",
                column: "DisciplineId1",
                principalTable: "cd_discipline",
                principalColumn: "discipline_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_work_time_cd_discipline_f_discipline_id",
                table: "cd_work_time",
                column: "f_discipline_id",
                principalTable: "cd_discipline",
                principalColumn: "discipline_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_work_time_cd_professor_ProfessorId1",
                table: "cd_work_time",
                column: "ProfessorId1",
                principalTable: "cd_professor",
                principalColumn: "professor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_work_time_cd_professor_f_professor_id",
                table: "cd_work_time",
                column: "f_professor_id",
                principalTable: "cd_professor",
                principalColumn: "professor_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_professor_cd_cafedre_f_cafedre_id",
                table: "cd_professor");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_work_time_cd_cafedre_f_cafedre_id",
                table: "cd_work_time");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_work_time_cd_discipline_DisciplineId1",
                table: "cd_work_time");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_work_time_cd_discipline_f_discipline_id",
                table: "cd_work_time");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_work_time_cd_professor_ProfessorId1",
                table: "cd_work_time");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_work_time_cd_professor_f_professor_id",
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

            migrationBuilder.RenameTable(
                name: "cd_title",
                newName: "Titles");

            migrationBuilder.RenameTable(
                name: "cd_science_state",
                newName: "ScienceStates");

            migrationBuilder.RenameTable(
                name: "cd_discipline",
                newName: "Disciplines");

            migrationBuilder.RenameTable(
                name: "cd_cafedre",
                newName: "Cafedres");

            migrationBuilder.RenameIndex(
                name: "IX_cd_professor_f_cafedre_id",
                table: "cd_professor",
                newName: "idx+cd_professor_fk_f_cafedre_id");

            migrationBuilder.AlterColumn<int>(
                name: "f_professor_id",
                table: "cd_work_time",
                type: "int4",
                nullable: false,
                comment: "ID профессора",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "ID профессора");

            migrationBuilder.AlterColumn<int>(
                name: "f_discipline_id",
                table: "cd_work_time",
                type: "int4",
                nullable: false,
                comment: "ID дисциплины",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "ID дисциплины");

            migrationBuilder.AlterColumn<int>(
                name: "f_cafedre_id",
                table: "cd_work_time",
                type: "int4",
                nullable: false,
                comment: "ID кафедры",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "ID кафедры");

            migrationBuilder.AlterColumn<int>(
                name: "c_work_time_hours",
                table: "cd_work_time",
                type: "int4",
                nullable: false,
                comment: "Количество часов",
                oldClrType: typeof(int),
                oldType: "INT",
                oldComment: "Количество часов");

            migrationBuilder.AlterColumn<int>(
                name: "f_cafedre_id",
                table: "cd_professor",
                type: "int4",
                nullable: false,
                comment: "ID кафедры",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "ID кафедры");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_title",
                table: "cd_professor",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Должность профессора",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Должность профессора");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_middle_name",
                table: "cd_professor",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Отчество профессора",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Отчество профессора");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_last_name",
                table: "cd_professor",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Фамилия профессора",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Фамилия профессора");

            migrationBuilder.AlterColumn<string>(
                name: "c_professor_first_name",
                table: "cd_professor",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Имя профессора",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Имя профессора");

            migrationBuilder.AlterColumn<int>(
                name: "professor_id",
                table: "cd_professor",
                type: "integer",
                nullable: false,
                comment: "Идентификатор записи профессора",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор записи профессора")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "c_title_name",
                table: "Titles",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Название должности",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Название должности");

            migrationBuilder.AlterColumn<string>(
                name: "c_science_state_name",
                table: "ScienceStates",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Название научной степени",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Название научной степени");

            migrationBuilder.AlterColumn<string>(
                name: "c_discipline_name",
                table: "Disciplines",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Название дисциплины",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Название дисциплины");

            migrationBuilder.AlterColumn<int>(
                name: "discipline_id",
                table: "Disciplines",
                type: "integer",
                nullable: false,
                comment: "Идентификатор записи дисциплины",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор записи дисциплины")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "c_cafedre_name",
                table: "Cafedres",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Название кафедры",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Название кафедры");

            migrationBuilder.AlterColumn<string>(
                name: "c_cafedre_main_professor",
                table: "Cafedres",
                type: "varchar",
                maxLength: 100,
                nullable: false,
                comment: "Старший преподаватель кафедры",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "Старший преподаватель кафедры");

            migrationBuilder.AlterColumn<int>(
                name: "c_cafedre_creation_date",
                table: "Cafedres",
                type: "int4",
                nullable: false,
                comment: "Дата основания кафедры",
                oldClrType: typeof(int),
                oldType: "INT",
                oldComment: "Дата основания кафедры");

            migrationBuilder.AlterColumn<int>(
                name: "cafedre_id",
                table: "Cafedres",
                type: "integer",
                nullable: false,
                comment: "Идентификатор записи кафедры",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор записи кафедры")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "fk_f_cafedre_id",
                table: "Cafedres",
                column: "cafedre_id",
                principalTable: "cd_work_time",
                principalColumn: "work_time_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_f_cafedre_id",
                table: "cd_professor",
                column: "f_cafedre_id",
                principalTable: "Cafedres",
                principalColumn: "cafedre_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_f_professor_id",
                table: "cd_professor",
                column: "professor_id",
                principalTable: "cd_work_time",
                principalColumn: "work_time_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_f_discipline_id",
                table: "Disciplines",
                column: "discipline_id",
                principalTable: "cd_work_time",
                principalColumn: "work_time_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
