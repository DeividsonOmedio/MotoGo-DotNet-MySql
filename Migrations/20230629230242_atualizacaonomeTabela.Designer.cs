﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using motogoAPI;

#nullable disable

namespace motogoAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230629230242_atualizacaonomeTabela")]
    partial class atualizacaonomeTabela
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("motogoAPI.Entities.EnderecoEntregadores", b =>
                {
                    b.Property<int>("IdEnderecoEntregador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EntregadorId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEnderecoEntregador");

                    b.HasIndex("EntregadorId");

                    b.ToTable("EnderecoEntregador");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecoFuncionarios", b =>
                {
                    b.Property<int>("IdEnderecoFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEnderecoFuncionario");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("EnderecoFuncionario");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecoUsuarios", b =>
                {
                    b.Property<int>("IdEnderecosUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("IdEnderecosUsuario");

                    b.HasIndex("UsuarioId");

                    b.ToTable("EnderecoUsuario");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecosEntregas", b =>
                {
                    b.Property<int>("IdEnderecosEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEnderecosEntrega");

                    b.ToTable("EnderecoEntrega");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecosRetiradas", b =>
                {
                    b.Property<int>("IdEnderecoRetiradas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEnderecoRetiradas");

                    b.ToTable("EnderecoRetirada");
                });

            modelBuilder.Entity("motogoAPI.Entities.Entregadores", b =>
                {
                    b.Property<int>("IdEntregador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AvaliacaoMedia")
                        .HasColumnType("double");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemCnhEntregador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemEntregador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.Property<double>("ValoresReceber")
                        .HasColumnType("double");

                    b.HasKey("IdEntregador");

                    b.ToTable("Entregador");
                });

            modelBuilder.Entity("motogoAPI.Entities.Funcionarios", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemDocumentoFuncionario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemFuncionario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("motogoAPI.Entities.Pedidos", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EnderecoEntregasId")
                        .HasColumnType("int");

                    b.Property<int>("EnderecoRetiradaId")
                        .HasColumnType("int");

                    b.Property<int>("EntregadoresId")
                        .HasColumnType("int");

                    b.Property<bool>("StatusPagamento")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("StatusPedido")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("UsusarioIdUsuario")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("IdPedido");

                    b.HasIndex("EnderecoEntregasId");

                    b.HasIndex("EnderecoRetiradaId");

                    b.HasIndex("EntregadoresId");

                    b.HasIndex("UsusarioIdUsuario");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("motogoAPI.Entities.Precos", b =>
                {
                    b.Property<int>("IdPreco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PrecoChuva")
                        .HasColumnType("int");

                    b.Property<int>("PrecoKg")
                        .HasColumnType("int");

                    b.Property<int>("PrecoKm")
                        .HasColumnType("int");

                    b.Property<int>("PrecoNoite")
                        .HasColumnType("int");

                    b.Property<int>("precoDia")
                        .HasColumnType("int");

                    b.HasKey("IdPreco");

                    b.ToTable("Precos");
                });

            modelBuilder.Entity("motogoAPI.Entities.Remessa", b =>
                {
                    b.Property<int>("IdRemessa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Altura")
                        .HasColumnType("double");

                    b.Property<double>("Comprimento")
                        .HasColumnType("double");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemProduto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Largura")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<double>("Peso")
                        .HasColumnType("double");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("IdRemessa");

                    b.HasIndex("PedidoId");

                    b.ToTable("Remessa");
                });

            modelBuilder.Entity("motogoAPI.Entities.Usuarios", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MeioDePagamentoPadrao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("motogoAPI.Entities.Veiculos", b =>
                {
                    b.Property<int>("IdVeiculos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AnoFabricacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EntregadorId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdVeiculos");

                    b.HasIndex("EntregadorId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecoEntregadores", b =>
                {
                    b.HasOne("motogoAPI.Entities.Entregadores", "Entregador")
                        .WithMany()
                        .HasForeignKey("EntregadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entregador");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecoFuncionarios", b =>
                {
                    b.HasOne("motogoAPI.Entities.Funcionarios", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecoUsuarios", b =>
                {
                    b.HasOne("motogoAPI.Entities.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("motogoAPI.Entities.Pedidos", b =>
                {
                    b.HasOne("motogoAPI.Entities.EnderecosEntregas", "EnderecoEntregas")
                        .WithMany()
                        .HasForeignKey("EnderecoEntregasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.EnderecosRetiradas", "EnderecoRetirada")
                        .WithMany()
                        .HasForeignKey("EnderecoRetiradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.Entregadores", "Entregadores")
                        .WithMany()
                        .HasForeignKey("EntregadoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.Usuarios", "Ususario")
                        .WithMany()
                        .HasForeignKey("UsusarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnderecoEntregas");

                    b.Navigation("EnderecoRetirada");

                    b.Navigation("Entregadores");

                    b.Navigation("Ususario");
                });

            modelBuilder.Entity("motogoAPI.Entities.Remessa", b =>
                {
                    b.HasOne("motogoAPI.Entities.Pedidos", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("motogoAPI.Entities.Veiculos", b =>
                {
                    b.HasOne("motogoAPI.Entities.Entregadores", "Entregador")
                        .WithMany()
                        .HasForeignKey("EntregadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entregador");
                });
#pragma warning restore 612, 618
        }
    }
}
