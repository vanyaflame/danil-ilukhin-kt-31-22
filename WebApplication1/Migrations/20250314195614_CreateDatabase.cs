using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cd_work_time",
                columns: table => new
                {
                    work_time_id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор записи рабочего времени")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_work_time_hours = table.Column<int>(type: "int4", nullable: false, comment: "Количество часов"),
                    f_professor_id = table.Column<int>(type: "int4", nullable: false, comment: "ID профессора"),
                    f_cafedre_id = table.Column<int>(type: "int4", nullable: false, comment: "ID кафедры"),
                    f_discipline_id = table.Column<int>(type: "int4", nullable: false, comment: "ID дисциплины")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_work_time_work_time_id", x => x.work_time_id);
                });

            migrationBuilder.CreateTable(
                name: "ScienceStates",
                columns: table => new
                {
                    science_state_id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор записи научной степени")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_science_state_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Название научной степени")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_science_state_science_state_id", x => x.science_state_id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    title_id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор записи должности")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_title_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Название должности")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_title_title_id", x => x.title_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_cafedre",
                columns: table => new
                {
                    cafedre_id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор записи кафедры"),
                    c_cafedre_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Название кафедры"),
                    c_cafedre_creation_date = table.Column<int>(type: "int4", nullable: false, comment: "Дата основания кафедры"),
                    c_cafedre_main_professor = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Старший преподаватель кафедры"),
                    f_professor_id = table.Column<int>(type: "int4", nullable: false, comment: "ID профессора")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_cafedre_cafedre_id", x => x.cafedre_id);
                    table.ForeignKey(
                        name: "fk_f_cafedre_id",
                        column: x => x.cafedre_id,
                        principalTable: "cd_work_time",
                        principalColumn: "work_time_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    discipline_id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор записи дисциплины"),
                    c_discipline_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Название дисциплины")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_discipline_discipline_id", x => x.discipline_id);
                    table.ForeignKey(
                        name: "fk_f_discipline_id",
                        column: x => x.discipline_id,
                        principalTable: "cd_work_time",
                        principalColumn: "work_time_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cd_professor",
                columns: table => new
                {
                    professor_id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор записи профессора"),
                    c_professor_first_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Имя профессора"),
                    c_professor_last_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Фамилия профессора"),
                    c_professor_middle_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Отчество профессора"),
                    c_professor_title = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Должность профессора"),
                    f_cafedre_id = table.Column<int>(type: "int4", nullable: false, comment: "ID кафедры")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_professor_professor_id", x => x.professor_id);
                    table.ForeignKey(
                        name: "fk_f_cafedre_id",
                        column: x => x.f_cafedre_id,
                        principalTable: "cd_cafedre",
                        principalColumn: "cafedre_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_f_professor_id",
                        column: x => x.professor_id,
                        principalTable: "cd_work_time",
                        principalColumn: "work_time_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_f_professor_id_cafedre",
                        column: x => x.professor_id,
                        principalTable: "cd_cafedre",
                        principalColumn: "cafedre_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx+cd_cafedre_fk_f_professor_id",
                table: "cd_cafedre",
                column: "f_professor_id");

            migrationBuilder.CreateIndex(
                name: "idx+cd_professor_fk_f_cafedre_id",
                table: "cd_professor",
                column: "f_cafedre_id");

            migrationBuilder.CreateIndex(
                name: "idx+cd_work_time_fk_f_cafedre_id",
                table: "cd_work_time",
                column: "f_cafedre_id");

            migrationBuilder.CreateIndex(
                name: "idx+cd_work_time_fk_f_discipline_id",
                table: "cd_work_time",
                column: "f_discipline_id");

            migrationBuilder.CreateIndex(
                name: "idx+cd_work_time_fk_f_professor_id",
                table: "cd_work_time",
                column: "f_professor_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cd_professor");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "ScienceStates");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "cd_cafedre");

            migrationBuilder.DropTable(
                name: "cd_work_time");
        }
    }
}
