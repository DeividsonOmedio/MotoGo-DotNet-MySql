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
    [Migration("20230706204352_atualizacaoTabelaPrecokg")]
    partial class atualizacaoTabelaPrecokg
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
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<int>("EntregadorId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

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
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

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
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("IdEnderecosUsuario");

                    b.HasIndex("UsuarioId");

                    b.ToTable("EnderecoUsuario");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecosEntregas", b =>
                {
                    b.Property<int>("IdEnderecoEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.HasKey("IdEnderecoEntrega");

                    b.ToTable("EnderecoEntrega");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecosRetiradas", b =>
                {
                    b.Property<int>("IdEnderecoRetirada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.HasKey("IdEnderecoRetirada");

                    b.ToTable("EnderecoRetirada");
                });

            modelBuilder.Entity("motogoAPI.Entities.Entregadores", b =>
                {
                    b.Property<int>("IdEntregador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double?>("AvaliacaoMedia")
                        .HasColumnType("double");

                    b.Property<string>("ChavePix")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ImagemCnhEntregador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemEntregador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<double?>("ValoresReceber")
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
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ImagemDocumentoFuncionario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemFuncionario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("motogoAPI.Entities.Pedidos", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Chovendo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataHoraPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("DistanciaPrevista")
                        .HasColumnType("double");

                    b.Property<double?>("Distanciapercorrida")
                        .HasColumnType("double");

                    b.Property<int>("EnderecoEntregasId")
                        .HasColumnType("int");

                    b.Property<int>("EnderecoRetiradaId")
                        .HasColumnType("int");

                    b.Property<int?>("EntregadoresId")
                        .HasColumnType("int");

                    b.Property<bool>("Noite")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("RemessaId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusCliente")
                        .HasColumnType("int");

                    b.Property<int?>("StatusEntregador")
                        .HasColumnType("int");

                    b.Property<bool>("StatusPagamento")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("StatusPedido")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("ValorPorKm")
                        .HasColumnType("double");

                    b.Property<double?>("ValorTotal")
                        .HasColumnType("double");

                    b.Property<double>("valorPrevisto")
                        .HasColumnType("double");

                    b.HasKey("IdPedido");

                    b.HasIndex("EnderecoEntregasId");

                    b.HasIndex("EnderecoRetiradaId");

                    b.HasIndex("EntregadoresId");

                    b.HasIndex("RemessaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("motogoAPI.Entities.Precos", b =>
                {
                    b.Property<int>("IdPreco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Preco12Kg")
                        .HasColumnType("double");

                    b.Property<double>("Preco1Kg")
                        .HasColumnType("double");

                    b.Property<double>("Preco3Kg")
                        .HasColumnType("double");

                    b.Property<double>("Preco8Kg")
                        .HasColumnType("double");

                    b.Property<double>("PrecoChuva")
                        .HasColumnType("double");

                    b.Property<double>("PrecoDia")
                        .HasColumnType("double");

                    b.Property<double>("PrecoKm")
                        .HasColumnType("double");

                    b.Property<double>("PrecoNoite")
                        .HasColumnType("double");

                    b.Property<double>("PrecoTempo")
                        .HasColumnType("double");

                    b.HasKey("IdPreco");

                    b.ToTable("Preco");
                });

            modelBuilder.Entity("motogoAPI.Entities.Remessa", b =>
                {
                    b.Property<int>("IdRemessa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double?>("Altura")
                        .HasColumnType("double");

                    b.Property<double?>("Comprimento")
                        .HasColumnType("double");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemProduto")
                        .HasColumnType("longtext");

                    b.Property<double?>("Largura")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double?>("Peso")
                        .HasColumnType("double");

                    b.Property<double?>("Valor")
                        .HasColumnType("double");

                    b.HasKey("IdRemessa");

                    b.ToTable("Remessa");
                });

            modelBuilder.Entity("motogoAPI.Entities.Usuarios", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("MeioDePagamentoPadrao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

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
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("EntregadorId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

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
                        .HasForeignKey("EntregadoresId");

                    b.HasOne("motogoAPI.Entities.Remessa", "Remessa")
                        .WithMany()
                        .HasForeignKey("RemessaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnderecoEntregas");

                    b.Navigation("EnderecoRetirada");

                    b.Navigation("Entregadores");

                    b.Navigation("Remessa");

                    b.Navigation("Usuario");
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