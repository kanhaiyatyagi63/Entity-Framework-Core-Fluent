using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.DataLayer.Migrations
{
    public partial class AddLanguageQueryIntoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Language values ('Php')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Language Where Name = 'php'");
        }
    }
}
