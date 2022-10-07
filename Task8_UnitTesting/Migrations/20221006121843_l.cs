using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task8_UnitTesting.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GadgetTbl",
                columns: table => new
                {
                    GadgetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GadgetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GadgetType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GadgetPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GadgetTbl", x => x.GadgetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GadgetTbl");
        }
    }
}
