using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaonomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remessa_Pedido_PedidosId",
                table: "Remessa");

            migrationBuilder.DropTable(
                name: "EndereçoEntregador");

            migrationBuilder.RenameColumn(
                name: "PedidosId",
                table: "Remessa",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Remessa_PedidosId",
                table: "Remessa",
                newName: "IX_Remessa_PedidoId");

            migrationBuilder.RenameColumn(
                name: "IdEnderecoFuncionarios",
                table: "EnderecoFuncionario",
                newName: "IdEnderecoFuncionario");

            migrationBuilder.CreateTable(
                name: "EnderecoEntregador",
                columns: table => new
                {
                    IdEnderecoEntregador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Uf = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntregadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEntregador", x => x.IdEnderecoEntregador);
                    table.ForeignKey(
                        name: "FK_EnderecoEntregador_Entregador_EntregadorId",
                        column: x => x.EntregadorId,
                        principalTable: "Entregador",
                        principalColumn: "IdEntregador",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEntregador_EntregadorId",
                table: "EnderecoEntregador",
                column: "EntregadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remessa_Pedido_PedidoId",
                table: "Remessa",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remessa_Pedido_PedidoId",
                table: "Remessa");

            migrationBuilder.DropTable(
                name: "EnderecoEntregador");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Remessa",
                newName: "PedidosId");

            migrationBuilder.RenameIndex(
                name: "IX_Remessa_PedidoId",
                table: "Remessa",
                newName: "IX_Remessa_PedidosId");

            migrationBuilder.RenameColumn(
                name: "IdEnderecoFuncionario",
                table: "EnderecoFuncionario",
                newName: "IdEnderecoFuncionarios");

            migrationBuilder.CreateTable(
                name: "EndereçoEntregador",
                columns: table => new
                {
                    IdEnderecoEntregadores = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EntregadorId = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Uf = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndereçoEntregador", x => x.IdEnderecoEntregadores);
                    table.ForeignKey(
                        name: "FK_EndereçoEntregador_Entregador_EntregadorId",
                        column: x => x.EntregadorId,
                        principalTable: "Entregador",
                        principalColumn: "IdEntregador",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_EndereçoEntregador_EntregadorId",
                table: "EndereçoEntregador",
                column: "EntregadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remessa_Pedido_PedidosId",
                table: "Remessa",
                column: "PedidosId",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
