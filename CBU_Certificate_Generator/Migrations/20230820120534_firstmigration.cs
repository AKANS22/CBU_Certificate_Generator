using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBU_Certificate_Generator.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "certificateTemplates",
                columns: table => new
                {
                    TemplateId = table.Column<string>(type: "TEXT", nullable: false),
                    CourseName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificateTemplates", x => x.TemplateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "certificateTemplates");
        }
    }
}
