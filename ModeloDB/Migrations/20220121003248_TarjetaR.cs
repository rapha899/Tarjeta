using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class TarjetaR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingresos = table.Column<int>(type: "int", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Deudas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeuda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentSolicitudid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deudas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Deudas_Solicitudes_CurrentSolicitudid",
                        column: x => x.CurrentSolicitudid,
                        principalTable: "Solicitudes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rolPago = table.Column<int>(type: "int", nullable: false),
                    FechaRol = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentSolicitudid = table.Column<int>(type: "int", nullable: false),
                    Solicitudid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rol_Solicitudes_Solicitudid",
                        column: x => x.Solicitudid,
                        principalTable: "Solicitudes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolPublica",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rolPagoPublica = table.Column<int>(type: "int", nullable: false),
                    FechaRol = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentSolicitudid = table.Column<int>(type: "int", nullable: false),
                    Solicitudid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPublica", x => x.id);
                    table.ForeignKey(
                        name: "FK_RolPublica_Solicitudes_Solicitudid",
                        column: x => x.Solicitudid,
                        principalTable: "Solicitudes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjetaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentSolicitudid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Solicitudes_CurrentSolicitudid",
                        column: x => x.CurrentSolicitudid,
                        principalTable: "Solicitudes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentSolicitudid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Solicitudes_CurrentSolicitudid",
                        column: x => x.CurrentSolicitudid,
                        principalTable: "Solicitudes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calculos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    calculo = table.Column<float>(type: "real", nullable: false),
                    rol12 = table.Column<float>(type: "real", nullable: false),
                    Factur36 = table.Column<float>(type: "real", nullable: false),
                    rol24 = table.Column<float>(type: "real", nullable: false),
                    rolPagoid = table.Column<int>(type: "int", nullable: true),
                    rolPagosPublicaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Calculos_Rol_rolPagoid",
                        column: x => x.rolPagoid,
                        principalTable: "Rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calculos_RolPublica_rolPagosPublicaid",
                        column: x => x.rolPagosPublicaid,
                        principalTable: "RolPublica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    factura = table.Column<int>(type: "int", nullable: false),
                    FechaFactura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentSolicitudid = table.Column<int>(type: "int", nullable: false),
                    Solicitudid = table.Column<int>(type: "int", nullable: true),
                    Calculos_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Facturas_Calculos_Calculos_Id",
                        column: x => x.Calculos_Id,
                        principalTable: "Calculos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Solicitudes_Solicitudid",
                        column: x => x.Solicitudid,
                        principalTable: "Solicitudes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prerequsitos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    RolPagoId = table.Column<int>(type: "int", nullable: false),
                    RolPagoPublicaId = table.Column<int>(type: "int", nullable: false),
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prerequsitos", x => new { x.RolPagoId, x.FacturaId, x.RolPagoPublicaId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_Prerequsitos_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Prerequsitos_Rol_RolPagoId",
                        column: x => x.RolPagoId,
                        principalTable: "Rol",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Prerequsitos_RolPublica_RolPagoPublicaId",
                        column: x => x.RolPagoPublicaId,
                        principalTable: "RolPublica",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Prerequsitos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calculos_rolPagoid",
                table: "Calculos",
                column: "rolPagoid");

            migrationBuilder.CreateIndex(
                name: "IX_Calculos_rolPagosPublicaid",
                table: "Calculos",
                column: "rolPagosPublicaid");

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_CurrentSolicitudid",
                table: "Deudas",
                column: "CurrentSolicitudid");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Calculos_Id",
                table: "Facturas",
                column: "Calculos_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Solicitudid",
                table: "Facturas",
                column: "Solicitudid");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequsitos_FacturaId",
                table: "Prerequsitos",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequsitos_RolPagoPublicaId",
                table: "Prerequsitos",
                column: "RolPagoPublicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequsitos_UsuarioId",
                table: "Prerequsitos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Solicitudid",
                table: "Rol",
                column: "Solicitudid");

            migrationBuilder.CreateIndex(
                name: "IX_RolPublica_Solicitudid",
                table: "RolPublica",
                column: "Solicitudid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_CurrentSolicitudid",
                table: "Tarjetas",
                column: "CurrentSolicitudid");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CurrentSolicitudid",
                table: "Usuarios",
                column: "CurrentSolicitudid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deudas");

            migrationBuilder.DropTable(
                name: "Prerequsitos");

            migrationBuilder.DropTable(
                name: "Tarjetas");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Calculos");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "RolPublica");

            migrationBuilder.DropTable(
                name: "Solicitudes");
        }
    }
}
