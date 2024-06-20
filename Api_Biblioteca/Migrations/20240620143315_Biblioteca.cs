using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Biblioteca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id_libro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id_libro);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id_autor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibroId_libro = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id_autor);
                    table.ForeignKey(
                        name: "FK_Autores_Libros_LibroId_libro",
                        column: x => x.LibroId_libro,
                        principalTable: "Libros",
                        principalColumn: "Id_libro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autores_LibroId_libro",
                table: "Autores",
                column: "LibroId_libro");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_titulo",
                table: "Libros",
                column: "titulo",
                unique: true,
                filter: "[titulo] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Libros");
        }
    }
}
