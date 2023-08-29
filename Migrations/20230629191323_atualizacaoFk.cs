using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace motogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EndereçoEntregador_Entregador_IdEntregador1",
                table: "EndereçoEntregador");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoFuncionario_Funcionario_IdFuncionario1",
                table: "EnderecoFuncionario");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoUsuario_Usuario_IdUsuario1",
                table: "EnderecoUsuario");

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
                name: "FK_Pedido_Usuario_IdUsusarioIdUsuario",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Remessa_Pedido_IdPedidosIdPedido",
                table: "Remessa");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Entregador_IdEntregador1",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdEnregadoresIdEntregador",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "IdEntregador1",
                table: "Veiculo",
                newName: "EntregadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_IdEntregador1",
                table: "Veiculo",
                newName: "IX_Veiculo_EntregadorId");

            migrationBuilder.RenameColumn(
                name: "IdPedidosIdPedido",
                table: "Remessa",
                newName: "PedidosId");

            migrationBuilder.RenameIndex(
                name: "IX_Remessa_IdPedidosIdPedido",
                table: "Remessa",
                newName: "IX_Remessa_PedidosId");

            migrationBuilder.RenameColumn(
                name: "IdUsusarioIdUsuario",
                table: "Pedido",
                newName: "UsusarioIdUsuario");

            migrationBuilder.RenameColumn(
                name: "IdEnregadoresIdEntregador",
                table: "Pedido",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdEnderecoRetiradas",
                table: "Pedido",
                newName: "EntregadoresId");

            migrationBuilder.RenameColumn(
                name: "IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido",
                newName: "EnderecoRetiradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_IdUsusarioIdUsuario",
                table: "Pedido",
                newName: "IX_Pedido_UsusarioIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_IdEnderecoRetiradas",
                table: "Pedido",
                newName: "IX_Pedido_EntregadoresId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_IdEnderecoEntregasIdEnderecosEntrega",
                table: "Pedido",
                newName: "IX_Pedido_EnderecoRetiradaId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario1",
                table: "EnderecoUsuario",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdEnderecosEntrega",
                table: "EnderecoUsuario",
                newName: "IdEnderecosUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_EnderecoUsuario_IdUsuario1",
                table: "EnderecoUsuario",
                newName: "IX_EnderecoUsuario_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdFuncionario1",
                table: "EnderecoFuncionario",
                newName: "FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_EnderecoFuncionario_IdFuncionario1",
                table: "EnderecoFuncionario",
                newName: "IX_EnderecoFuncionario_FuncionarioId");

            migrationBuilder.RenameColumn(
                name: "IdEntregador1",
                table: "EndereçoEntregador",
                newName: "EntregadorId");

            migrationBuilder.RenameIndex(
                name: "IX_EndereçoEntregador_IdEntregador1",
                table: "EndereçoEntregador",
                newName: "IX_EndereçoEntregador_EntregadorId");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoEntregasId",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EnderecoEntregasId",
                table: "Pedido",
                column: "EnderecoEntregasId");

            migrationBuilder.AddForeignKey(
                name: "FK_EndereçoEntregador_Entregador_EntregadorId",
                table: "EndereçoEntregador",
                column: "EntregadorId",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoFuncionario_Funcionario_FuncionarioId",
                table: "EnderecoFuncionario",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoUsuario_Usuario_UsuarioId",
                table: "EnderecoUsuario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_EnderecoEntrega_EnderecoEntregasId",
                table: "Pedido",
                column: "EnderecoEntregasId",
                principalTable: "EnderecoEntrega",
                principalColumn: "IdEnderecosEntrega",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_EnderecoRetirada_EnderecoRetiradaId",
                table: "Pedido",
                column: "EnderecoRetiradaId",
                principalTable: "EnderecoRetirada",
                principalColumn: "IdEnderecoRetiradas",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Entregador_EntregadoresId",
                table: "Pedido",
                column: "EntregadoresId",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Usuario_UsusarioIdUsuario",
                table: "Pedido",
                column: "UsusarioIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remessa_Pedido_PedidosId",
                table: "Remessa",
                column: "PedidosId",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Entregador_EntregadorId",
                table: "Veiculo",
                column: "EntregadorId",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EndereçoEntregador_Entregador_EntregadorId",
                table: "EndereçoEntregador");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoFuncionario_Funcionario_FuncionarioId",
                table: "EnderecoFuncionario");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoUsuario_Usuario_UsuarioId",
                table: "EnderecoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_EnderecoEntrega_EnderecoEntregasId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_EnderecoRetirada_EnderecoRetiradaId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Entregador_EntregadoresId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Usuario_UsusarioIdUsuario",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Remessa_Pedido_PedidosId",
                table: "Remessa");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Entregador_EntregadorId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_EnderecoEntregasId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "EnderecoEntregasId",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "EntregadorId",
                table: "Veiculo",
                newName: "IdEntregador1");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_EntregadorId",
                table: "Veiculo",
                newName: "IX_Veiculo_IdEntregador1");

            migrationBuilder.RenameColumn(
                name: "PedidosId",
                table: "Remessa",
                newName: "IdPedidosIdPedido");

            migrationBuilder.RenameIndex(
                name: "IX_Remessa_PedidosId",
                table: "Remessa",
                newName: "IX_Remessa_IdPedidosIdPedido");

            migrationBuilder.RenameColumn(
                name: "UsusarioIdUsuario",
                table: "Pedido",
                newName: "IdUsusarioIdUsuario");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Pedido",
                newName: "IdEnregadoresIdEntregador");

            migrationBuilder.RenameColumn(
                name: "EntregadoresId",
                table: "Pedido",
                newName: "IdEnderecoRetiradas");

            migrationBuilder.RenameColumn(
                name: "EnderecoRetiradaId",
                table: "Pedido",
                newName: "IdEnderecoEntregasIdEnderecosEntrega");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_UsusarioIdUsuario",
                table: "Pedido",
                newName: "IX_Pedido_IdUsusarioIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_EntregadoresId",
                table: "Pedido",
                newName: "IX_Pedido_IdEnderecoRetiradas");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_EnderecoRetiradaId",
                table: "Pedido",
                newName: "IX_Pedido_IdEnderecoEntregasIdEnderecosEntrega");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "EnderecoUsuario",
                newName: "IdUsuario1");

            migrationBuilder.RenameColumn(
                name: "IdEnderecosUsuario",
                table: "EnderecoUsuario",
                newName: "IdEnderecosEntrega");

            migrationBuilder.RenameIndex(
                name: "IX_EnderecoUsuario_UsuarioId",
                table: "EnderecoUsuario",
                newName: "IX_EnderecoUsuario_IdUsuario1");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "EnderecoFuncionario",
                newName: "IdFuncionario1");

            migrationBuilder.RenameIndex(
                name: "IX_EnderecoFuncionario_FuncionarioId",
                table: "EnderecoFuncionario",
                newName: "IX_EnderecoFuncionario_IdFuncionario1");

            migrationBuilder.RenameColumn(
                name: "EntregadorId",
                table: "EndereçoEntregador",
                newName: "IdEntregador1");

            migrationBuilder.RenameIndex(
                name: "IX_EndereçoEntregador_EntregadorId",
                table: "EndereçoEntregador",
                newName: "IX_EndereçoEntregador_IdEntregador1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdEnregadoresIdEntregador",
                table: "Pedido",
                column: "IdEnregadoresIdEntregador");

            migrationBuilder.AddForeignKey(
                name: "FK_EndereçoEntregador_Entregador_IdEntregador1",
                table: "EndereçoEntregador",
                column: "IdEntregador1",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoFuncionario_Funcionario_IdFuncionario1",
                table: "EnderecoFuncionario",
                column: "IdFuncionario1",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoUsuario_Usuario_IdUsuario1",
                table: "EnderecoUsuario",
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
                name: "FK_Pedido_Usuario_IdUsusarioIdUsuario",
                table: "Pedido",
                column: "IdUsusarioIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remessa_Pedido_IdPedidosIdPedido",
                table: "Remessa",
                column: "IdPedidosIdPedido",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Entregador_IdEntregador1",
                table: "Veiculo",
                column: "IdEntregador1",
                principalTable: "Entregador",
                principalColumn: "IdEntregador",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
