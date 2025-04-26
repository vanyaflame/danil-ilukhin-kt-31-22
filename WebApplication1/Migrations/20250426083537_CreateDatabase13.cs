using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE cd_cafedre ALTER COLUMN c_cafedre_creation_date TYPE timestamp without time zone USING to_timestamp(c_cafedre_creation_date::text, 'YYYY-MM-DD HH24:MI:SS')");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE cd_cafedre ALTER COLUMN c_cafedre_creation_date TYPE int USING c_cafedre_creation_date::int");
        }

    }
}
