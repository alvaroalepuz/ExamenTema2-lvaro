using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "casaApuestas",
                columns: table => new
                {
                    casaApuestasId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SaldoActual = table.Column<double>(nullable: false),
                    NombreBanco = table.Column<string>(nullable: true),
                    Numtarjeta = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_casaApuestas", x => x.casaApuestasId);
                });

            migrationBuilder.CreateTable(
                name: "mercados",
                columns: table => new
                {
                    mercadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mercado = table.Column<double>(nullable: false),
                    cuotaOver = table.Column<double>(nullable: false),
                    cuotaUnder = table.Column<double>(nullable: false),
                    dineroOver = table.Column<double>(nullable: false),
                    dineroUnder = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mercados", x => x.mercadoId);
                });

            migrationBuilder.CreateTable(
                name: "eventos",
                columns: table => new
                {
                    eventoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreLocal = table.Column<string>(nullable: true),
                    nombreVisitante = table.Column<string>(nullable: true),
                    fecha = table.Column<string>(nullable: true),
                    mercado = table.Column<double>(nullable: false),
                    mercadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventos", x => x.eventoId);
                    table.ForeignKey(
                        name: "FK_eventos_mercados_mercadoId",
                        column: x => x.mercadoId,
                        principalTable: "mercados",
                        principalColumn: "mercadoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    usuarioId = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    edad = table.Column<int>(nullable: false),
                    mercado = table.Column<double>(nullable: false),
                    casaApuestas2casaApuestasId = table.Column<int>(nullable: true),
                    mercadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.usuarioId);
                    table.ForeignKey(
                        name: "FK_usuarios_casaApuestas_casaApuestas2casaApuestasId",
                        column: x => x.casaApuestas2casaApuestasId,
                        principalTable: "casaApuestas",
                        principalColumn: "casaApuestasId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_mercados_mercadoId",
                        column: x => x.mercadoId,
                        principalTable: "mercados",
                        principalColumn: "mercadoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "apuestas",
                columns: table => new
                {
                    apuestaId = table.Column<string>(nullable: false),
                    tipo = table.Column<string>(nullable: true),
                    dinero = table.Column<double>(nullable: false),
                    mercadoId = table.Column<int>(nullable: false),
                    usuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_apuestas", x => x.apuestaId);
                    table.ForeignKey(
                        name: "FK_apuestas_mercados_mercadoId",
                        column: x => x.mercadoId,
                        principalTable: "mercados",
                        principalColumn: "mercadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_apuestas_usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "casaApuestas",
                columns: new[] { "casaApuestasId", "Correo", "NombreBanco", "Numtarjeta", "SaldoActual" },
                values: new object[] { 1, "alexmontalvo1112@gmail.com", "Caixa", 12345678, 4000.0 });

            migrationBuilder.InsertData(
                table: "eventos",
                columns: new[] { "eventoId", "fecha", "mercado", "mercadoId", "nombreLocal", "nombreVisitante" },
                values: new object[] { 1, "12-12-2040", 1.5, null, "Valencia", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "mercados",
                columns: new[] { "mercadoId", "cuotaOver", "cuotaUnder", "dineroOver", "dineroUnder", "mercado" },
                values: new object[] { 1, 60.0, 40.0, 200.0, 500.0, 1.5 });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "usuarioId", "apellido", "casaApuestas2casaApuestasId", "edad", "mercado", "mercadoId", "nombre" },
                values: new object[] { "alexmontalvo1112@gmail.com", "Montalvo", null, 50, 1.5, null, "Alex" });

            migrationBuilder.InsertData(
                table: "apuestas",
                columns: new[] { "apuestaId", "dinero", "mercadoId", "tipo", "usuarioId" },
                values: new object[] { "alexmontalvo1112@gmail.com", 4000.0, 1, "over", null });

            migrationBuilder.CreateIndex(
                name: "IX_apuestas_mercadoId",
                table: "apuestas",
                column: "mercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_apuestas_usuarioId",
                table: "apuestas",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_eventos_mercadoId",
                table: "eventos",
                column: "mercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_casaApuestas2casaApuestasId",
                table: "usuarios",
                column: "casaApuestas2casaApuestasId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_mercadoId",
                table: "usuarios",
                column: "mercadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "apuestas");

            migrationBuilder.DropTable(
                name: "eventos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "casaApuestas");

            migrationBuilder.DropTable(
                name: "mercados");
        }
    }
}
