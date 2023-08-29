using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoVariasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entregador_ImagemEntregador_AvatarIdImagemEntregador",
                table: "Entregador");

            migrationBuilder.DropTable(
                name: "imagemCnh");

            migrationBuilder.DropTable(
                name: "ImagemDocumentoVeiculos");

            migrationBuilder.DropTable(
                name: "ImagemEntregador");

            migrationBuilder.DropIndex(
                name: "IX_Entregador_AvatarIdImagemEntregador",
                table: "Entregador");

            migrationBuilder.DropColumn(
                name: "IdEnderecoEntregas",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "AvatarIdImagemEntregador",
                table: "Entregador");

            migrationBuilder.RenameColumn(
                name: "IdEntregador",
                table: "Veiculo",
                newName: "IdEntregador1");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Pedido",
                newName: "IdUsusarioIdUsuario");

            migrationBuilder.RenameColumn(
                name: "IdProdutos",
                table: "Pedido",
                newName: "IdProdutos1");

            migrationBuilder.RenameColumn(
                name: "IdEntregador",
                table: "Pedido",
                newName: "IdEnregadoresIdEntregador");

            migrationBuilder.RenameColumn(
                name: "IdEntregador",
                table: "EndereçoEntregador",
                newName: "IdEntregador1");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario1",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdEnderecoRetiradas",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddColumn<int>(
                name: "IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagemDocEntregador",
                table: "Entregador",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImagemEntregador",
                table: "Entregador",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_IdEntregador1",
                table: "Veiculo",
                column: "IdEntregador1");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdUsuario1",
                table: "Produto",
                column: "IdUsuario1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido",
                column: "IdEnderecoEntregasIdEnderecosEntrega");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdEnderecoRetiradas",
                table: "Pedido",
                column: "IdEnderecoRetiradas");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdEnregadoresIdEntregador",
                table: "Pedido",
                column: "IdEnregadoresIdEntregador");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdProdutos1",
                table: "Pedido",
                column: "IdProdutos1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdUsusarioIdUsuario",
                table: "Pedido",
                column: "IdUsusarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoRetirada_IdUsuario1",
                table: "EnderecoRetirada",
                column: "IdUsuario1");

            migrationBuilder.CreateIndex(
                name: "IX_EndereçoEntregador_IdEntregador1",
                table: "EndereçoEntregador",
                column: "IdEntregador1");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEntrega_IdUsuario1",
                table: "EnderecoEntrega",
                column: "IdUsuario1");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoEntrega_Usuario_IdUsuario1",
                table: "EnderecoEntrega",
                column: "IdUsuario1",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EndereçoEntregador_Entregador_IdEntregador1",
                table: "EndereçoEntregador",
                column: "IdEntregador1",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoRetirada_Usuario_IdUsuario1",
                table: "EnderecoRetirada",
                column: "IdUsuario1",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_EnderecoEntrega_IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido",
                column: "IdEnderecoEntregasIdEnderecosEntrega",
                principalTable: "EnderecoEntrega",
                principalColumn: "IdEnderecosEntrega",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_EnderecoRetirada_IdEnderecoRetiradas",
                table: "Pedido",
                column: "IdEnderecoRetiradas",
                principalTable: "EnderecoRetirada",
                principalColumn: "IdEnderecoRetiradas",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Entregador_IdEnregadoresIdEntregador",
                table: "Pedido",
                column: "IdEnregadoresIdEntregador",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_IdProdutos1",
                table: "Pedido",
                column: "IdProdutos1",
                principalTable: "Produto",
                principalColumn: "IdProdutos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Usuario_IdUsusarioIdUsuario",
                table: "Pedido",
                column: "IdUsusarioIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Usuario_IdUsuario1",
                table: "Produto",
                column: "IdUsuario1",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Entregador_IdEntregador1",
                table: "Veiculo",
                column: "IdEntregador1",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoEntrega_Usuario_IdUsuario1",
                table: "EnderecoEntrega");

            migrationBuilder.DropForeignKey(
                name: "FK_EndereçoEntregador_Entregador_IdEntregador1",
                table: "EndereçoEntregador");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoRetirada_Usuario_IdUsuario1",
                table: "EnderecoRetirada");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_EnderecoEntrega_IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_EnderecoRetirada_IdEnderecoRetiradas",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Entregador_IdEnregadoresIdEntregador",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_IdProdutos1",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Usuario_IdUsusarioIdUsuario",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Usuario_IdUsuario1",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Entregador_IdEntregador1",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_IdEntregador1",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Produto_IdUsuario1",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdEnderecoRetiradas",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdEnregadoresIdEntregador",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdProdutos1",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdUsusarioIdUsuario",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_EnderecoRetirada_IdUsuario1",
                table: "EnderecoRetirada");

            migrationBuilder.DropIndex(
                name: "IX_EndereçoEntregador_IdEntregador1",
                table: "EndereçoEntregador");

            migrationBuilder.DropIndex(
                name: "IX_EnderecoEntrega_IdUsuario1",
                table: "EnderecoEntrega");

            migrationBuilder.DropColumn(
                name: "IdUsuario1",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ImagemDocEntregador",
                table: "Entregador");

            migrationBuilder.DropColumn(
                name: "ImagemEntregador",
                table: "Entregador");

            migrationBuilder.DropColumn(
                name: "IdUsuario1",
                table: "EnderecoRetirada");

            migrationBuilder.DropColumn(
                name: "IdUsuario1",
                table: "EnderecoEntrega");

            migrationBuilder.RenameColumn(
                name: "IdEntregador1",
                table: "Veiculo",
                newName: "IdEntregador");

            migrationBuilder.RenameColumn(
                name: "IdUsusarioIdUsuario",
                table: "Pedido",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "IdProdutos1",
                table: "Pedido",
                newName: "IdProdutos");

            migrationBuilder.RenameColumn(
                name: "IdEnregadoresIdEntregador",
                table: "Pedido",
                newName: "IdEntregador");

            migrationBuilder.RenameColumn(
                name: "IdEntregador1",
                table: "EndereçoEntregador",
                newName: "IdEntregador");

            migrationBuilder.AlterColumn<string>(
                name: "IdEnderecoRetiradas",
                table: "Pedido",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "IdEnderecoEntregas",
                table: "Pedido",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "AvatarIdImagemEntregador",
                table: "Entregador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "imagemCnh",
                columns: table => new
                {
                    IdImagemCnh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEntregador = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<byte[]>(type: "longblob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagemCnh", x => x.IdImagemCnh);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ImagemDocumentoVeiculos",
                columns: table => new
                {
                    IdImagemDocumentoVeiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEntregador = table.Column<int>(type: "int", nullable: false),
                    IdVeiculos = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<byte[]>(type: "longblob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemDocumentoVeiculos", x => x.IdImagemDocumentoVeiculo);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ImagemEntregador",
                columns: table => new
                {
                    IdImagemEntregador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEntregador = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<byte[]>(type: "longblob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemEntregador", x => x.IdImagemEntregador);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Entregador_AvatarIdImagemEntregador",
                table: "Entregador",
                column: "AvatarIdImagemEntregador");

            migrationBuilder.AddForeignKey(
                name: "FK_Entregador_ImagemEntregador_AvatarIdImagemEntregador",
                table: "Entregador",
                column: "AvatarIdImagemEntregador",
                principalTable: "ImagemEntregador",
                principalColumn: "IdImagemEntregador",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
