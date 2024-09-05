using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace parcialUno.API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HistorialClinico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Seguro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_ApellidoMaterno",
                table: "pacientes",
                column: "ApellidoMaterno",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_ApellidoPaterno",
                table: "pacientes",
                column: "ApellidoPaterno",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_Celular",
                table: "pacientes",
                column: "Celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_HistorialClinico",
                table: "pacientes",
                column: "HistorialClinico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_Nombre",
                table: "pacientes",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pacientes");
        }
    }
}
