using Microsoft.EntityFrameworkCore.Migrations;

namespace PROGRAMA_BOVINO.persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aper_Vacas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_Vaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veterinario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aper_Vacas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Historias_Clinicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Historia = table.Column<int>(type: "int", nullable: false),
                    Fecha_Visita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Vaca = table.Column<int>(type: "int", nullable: false),
                    Id_Veterinario = table.Column<int>(type: "int", nullable: false),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Frecuencia_Respiratoria = table.Column<int>(type: "int", nullable: false),
                    Frecuencia_Cardiaca = table.Column<int>(type: "int", nullable: false),
                    Estado_Animo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias_Clinicas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E_mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Propietario = table.Column<int>(type: "int", nullable: true),
                    Nombre_Hacienda = table.Column<int>(type: "int", nullable: true),
                    Id_Veterinario = table.Column<int>(type: "int", nullable: true),
                    Tarjeta_Profesional = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aper_Vacas");

            migrationBuilder.DropTable(
                name: "Historias_Clinicas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
