using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaTecnicaCovisian.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Crear la tabla Carros primero
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Modelo = table.Column<string>(type: "text", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Disponible = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Placa);
                });

            // Crear la tabla Clientes
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cedula = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Telefono1 = table.Column<string>(type: "text", nullable: false),
                    Telefono2 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cedula);
                });

            // Crear la tabla Alquileres
            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    IdAlquiler = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "text", nullable: false),
                    Cedula = table.Column<string>(type: "text", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp", nullable: false),
                    TiempoEnDias = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Devuelto = table.Column<bool>(type: "boolean", nullable: false),
                    CarroPlaca = table.Column<string>(type: "text", nullable: false),
                    ClienteCedula = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquileres", x => x.IdAlquiler);
                    table.ForeignKey(
                        name: "FK_Alquileres_Carros_CarroPlaca",
                        column: x => x.CarroPlaca,
                        principalTable: "Carros",
                        principalColumn: "Placa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquileres_Clientes_ClienteCedula",
                        column: x => x.ClienteCedula,
                        principalTable: "Clientes",
                        principalColumn: "Cedula",
                        onDelete: ReferentialAction.Cascade);
                });

            // Crear la tabla Pagos
            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAlquiler = table.Column<int>(type: "int", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "timestamp", nullable: false),
                    ValorPago = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AlquilerIdAlquiler = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pagos_Alquileres_AlquilerIdAlquiler",
                        column: x => x.AlquilerIdAlquiler,
                        principalTable: "Alquileres",
                        principalColumn: "IdAlquiler",
                        onDelete: ReferentialAction.Cascade);
                });

            // Crear índices
            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_CarroPlaca",
                table: "Alquileres",
                column: "CarroPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_ClienteCedula",
                table: "Alquileres",
                column: "ClienteCedula");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_AlquilerIdAlquiler",
                table: "Pagos",
                column: "AlquilerIdAlquiler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");
            migrationBuilder.DropTable(
                name: "Alquileres");
            migrationBuilder.DropTable(
                name: "Carros");
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
