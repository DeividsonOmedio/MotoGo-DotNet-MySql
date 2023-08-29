using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoTabelaPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagemDocEntregador",
                table: "Entregador",
                newName: "ImagemCnhEntregador");

            migrationBuilder.AddColumn<string>(
                name: "ImagemProduto",
                table: "Produto",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "StatusPedido",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemProduto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "StatusPedido",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "ImagemCnhEntregador",
                table: "Entregador",
                newName: "ImagemDocEntregador");
        }
    }
}
