using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "c_cafedre_professors_amount",
                table: "cd_cafedre",
                type: "INT",
                nullable: false,
                defaultValue: 0,
                comment: "Количество профессоров");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "c_cafedre_professors_amount",
                table: "cd_cafedre");
        }
    }
}
