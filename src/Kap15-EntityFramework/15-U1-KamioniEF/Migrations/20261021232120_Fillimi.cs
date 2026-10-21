using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _15U1KamioniEF.Migrations
{
    /// <inheritdoc />
    public partial class Fillimi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kamionet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brendi = table.Column<string>(type: "TEXT", nullable: false),
                    Modeli = table.Column<string>(type: "TEXT", nullable: false),
                    Viti = table.Column<int>(type: "INTEGER", nullable: false),
                    KF = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kamionet", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kamionet");
        }
    }
}
