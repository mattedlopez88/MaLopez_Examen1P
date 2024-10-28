using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaLopez_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class MaLopez_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ML_modelo1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MLNombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MLEdad = table.Column<int>(type: "int", nullable: false),
                    MLDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MLDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MLFechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MLIsCliente = table.Column<bool>(type: "bit", nullable: false),
                    MLSaldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ML_modelo1", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ML_modelo1");
        }
    }
}
