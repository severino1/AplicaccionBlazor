using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea9y10.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    img = table.Column<string>(nullable: true),
                    genero = table.Column<string>(nullable: true),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    telefonoPer = table.Column<string>(nullable: true),
                    celular = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    TipoDocumento = table.Column<string>(nullable: true),
                    DocuIdentidad = table.Column<string>(nullable: true),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    PaisNacimiento = table.Column<string>(nullable: true),
                    CiudadNacimiento = table.Column<string>(nullable: true),
                    PaisResidencia = table.Column<string>(nullable: true),
                    CiudadResidencia = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    Hijos = table.Column<string>(nullable: true),
                    Profesion = table.Column<string>(nullable: true),
                    NombreEmpresa = table.Column<string>(nullable: true),
                    Ocupacion = table.Column<string>(nullable: true),
                    TelefonoEmp = table.Column<string>(nullable: true),
                    FechaConversion = table.Column<DateTime>(nullable: false),
                    FechaBautismo = table.Column<DateTime>(nullable: false),
                    FechaAceptado = table.Column<DateTime>(nullable: false),
                    Denominacion = table.Column<string>(nullable: true),
                    NombreIglesia = table.Column<string>(nullable: true),
                    IglesiaAnterior = table.Column<string>(nullable: true),
                    NombrePastor = table.Column<string>(nullable: true),
                    Disciplinado = table.Column<string>(nullable: true),
                    Causas = table.Column<string>(nullable: true),
                    Funciones = table.Column<string>(nullable: true),
                    Ministerios = table.Column<string>(nullable: true),
                    MinisterioMayorFruto = table.Column<string>(nullable: true),
                    MinisterioLlamado = table.Column<string>(nullable: true),
                    Metas = table.Column<string>(nullable: true),
                    Respaldo = table.Column<string>(nullable: true),
                    NivelEstudio = table.Column<string>(nullable: true),
                    ExpulsadoIns = table.Column<string>(nullable: true),
                    Razon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.PersonaId);
                });

            migrationBuilder.InsertData(
                table: "personas",
                columns: new[] { "PersonaId", "Causas", "CiudadNacimiento", "CiudadResidencia", "Denominacion", "Direccion", "Disciplinado", "DocuIdentidad", "EstadoCivil", "ExpulsadoIns", "FechaAceptado", "FechaBautismo", "FechaConversion", "Funciones", "Hijos", "IglesiaAnterior", "Metas", "MinisterioLlamado", "MinisterioMayorFruto", "Ministerios", "NivelEstudio", "NombreEmpresa", "NombreIglesia", "NombrePastor", "Ocupacion", "PaisNacimiento", "PaisResidencia", "Profesion", "Razon", "Respaldo", "TelefonoEmp", "TipoDocumento", "apellido", "celular", "correo", "fechaNacimiento", "genero", "img", "nombre", "telefonoPer" },
                values: new object[] { 1, "Me iban a expulsar", "Santo domingo", "Santo domingo este", "Católica", "Santo domingo este", "Si", "4554545454", "Soltero", "No", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diacono", "No", "Dios es mi vida", "Ser el mejor", "Ministerios de damas", "Ministerios de damas", "Ministerios de damas", "Tecnico", "--", "Jesus en mi vida", null, "--", "RD", "RD", "Ninguna", "--", "Si", "--", "Cedula", "Rodriguez", "849-280-9438", "roberticor05@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", null, "Roberto", "849-280-9438" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
