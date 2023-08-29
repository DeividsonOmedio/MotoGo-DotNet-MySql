using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoTabelasEmAula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoEntrega_Usuario_IdUsuario1",
                table: "EnderecoEntrega");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoRetirada_Usuario_IdUsuario1",
                table: "EnderecoRetirada");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_IdProdutos1",
                table: "Pedido");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdProdutos1",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_EnderecoRetirada_IdUsuario1",
                table: "EnderecoRetirada");

            migrationBuilder.DropIndex(
                name: "IX_EnderecoEntrega_IdUsuario1",
                table: "EnderecoEntrega");

            migrationBuilder.DropColumn(
                name: "IdProdutos1",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdUsuario1",
                table: "EnderecoRetirada");

            migrationBuilder.DropColumn(
                name: "IdUsuario1",
                table: "EnderecoEntrega");

            migrationBuilder.AddColumn<bool>(
                name: "StatusPagamento",
                table: "Pedido",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "ValorTotal",
                table: "Pedido",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ValoresReceber",
                table: "Entregador",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "EnderecoUsuario",
                columns: table => new
                {
                    IdEnderecosEntrega = table.Column<int>(type: "int", nullable: false)
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
                    IdUsuario1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoUsuario", x => x.IdEnderecosEntrega);
                    table.ForeignKey(
                        name: "FK_EnderecoUsuario_Usuario_IdUsuario1",
                        column: x => x.IdUsuario1,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Cargo = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Permissao = table.Column<int>(type: "int", nullable: false),
                    ImagemFuncionario = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagemDocumentoFuncionario = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "Precos",
                columns: table => new
                {
                    IdPreco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrecoKm = table.Column<int>(type: "int", nullable: false),
                    PrecoKg = table.Column<int>(type: "int", nullable: false),
                    precoDia = table.Column<int>(type: "int", nullable: false),
                    PrecoNoite = table.Column<int>(type: "int", nullable: false),
                    PrecoChuva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precos", x => x.IdPreco);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "Remessa",
                columns: table => new
                {
                    IdRemessa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Peso = table.Column<double>(type: "double", nullable: false),
                    Altura = table.Column<double>(type: "double", nullable: false),
                    Comprimento = table.Column<double>(type: "double", nullable: false),
                    Largura = table.Column<double>(type: "double", nullable: false),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    ImagemProduto = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPedidosIdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remessa", x => x.IdRemessa);
                    table.ForeignKey(
                        name: "FK_Remessa_Pedido_IdPedidosIdPedido",
                        column: x => x.IdPedidosIdPedido,
                        principalTable: "Pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "EnderecoFuncionario",
                columns: table => new
                {
                    IdEnderecoFuncionarios = table.Column<int>(type: "int", nullable: false)
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
                    IdFuncionario1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoFuncionario", x => x.IdEnderecoFuncionarios);
                    table.ForeignKey(
                        name: "FK_EnderecoFuncionario_Funcionario_IdFuncionario1",
                        column: x => x.IdFuncionario1,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoFuncionario_IdFuncionario1",
                table: "EnderecoFuncionario",
                column: "IdFuncionario1");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoUsuario_IdUsuario1",
                table: "EnderecoUsuario",
                column: "IdUsuario1");

            migrationBuilder.CreateIndex(
                name: "IX_Remessa_IdPedidosIdPedido",
                table: "Remessa",
                column: "IdPedidosIdPedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnderecoFuncionario");

            migrationBuilder.DropTable(
                name: "EnderecoUsuario");

            migrationBuilder.DropTable(
                name: "Precos");

            migrationBuilder.DropTable(
                name: "Remessa");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropColumn(
                name: "StatusPagamento",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ValoresReceber",
                table: "Entregador");

            migrationBuilder.AddColumn<int>(
                name: "IdProdutos1",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario1",
                table: "EnderecoRetirada",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario1",
                table: "EnderecoEntrega",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    IdProdutos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario1 = table.Column<int>(type: "int", nullable: false),
                    Altura = table.Column<double>(type: "double", nullable: false),
                    Comprimento = table.Column<double>(type: "double", nullable: false),
                    Descricao = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagemProduto = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Largura = table.Column<double>(type: "double", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Peso = table.Column<double>(type: "double", nullable: false),
                    Valor = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.IdProdutos);
                    table.ForeignKey(
                        name: "FK_Produto_Usuario_IdUsuario1",
                        column: x => x.IdUsuario1,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdProdutos1",
                table: "Pedido",
                column: "IdProdutos1");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoRetirada_IdUsuario1",
                table: "EnderecoRetirada",
                column: "IdUsuario1");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEntrega_IdUsuario1",
                table: "EnderecoEntrega",
                column: "IdUsuario1");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdUsuario1",
                table: "Produto",
                column: "IdUsuario1");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoEntrega_Usuario_IdUsuario1",
                table: "EnderecoEntrega",
                column: "IdUsuario1",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoRetirada_Usuario_IdUsuario1",
                table: "EnderecoRetirada",
                column: "IdUsuario1",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_IdProdutos1",
                table: "Pedido",
                column: "IdProdutos1",
                principalTable: "Produto",
                principalColumn: "IdProdutos",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
