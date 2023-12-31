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
    [Migration("20230627174057_atualizacaoVariasTabelas")]
    partial class atualizacaoVariasTabelas
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

                    b.Property<int>("IdUsuario1")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEnderecosEntrega");

                    b.HasIndex("IdUsuario1");

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

                    b.Property<int>("IdUsuario1")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEnderecoRetiradas");

                    b.HasIndex("IdUsuario1");

                    b.ToTable("EnderecoRetirada");
                });

            modelBuilder.Entity("motogoAPI.Entities.EndereçoEntregadores", b =>
                {
                    b.Property<int>("IdEnderecoEntregadores")
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

                    b.Property<int>("IdEntregador1")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEnderecoEntregadores");

                    b.HasIndex("IdEntregador1");

                    b.ToTable("EndereçoEntregador");
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

                    b.Property<string>("ImagemDocEntregador")
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

                    b.HasKey("IdEntregador");

                    b.ToTable("Entregador");
                });

            modelBuilder.Entity("motogoAPI.Entities.Pedidos", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdEnderecoEntregasIdEnderecosEntrega")
                        .HasColumnType("int");

                    b.Property<int>("IdEnderecoRetiradas")
                        .HasColumnType("int");

                    b.Property<int>("IdEnregadoresIdEntregador")
                        .HasColumnType("int");

                    b.Property<int>("IdProdutos1")
                        .HasColumnType("int");

                    b.Property<int>("IdUsusarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdEnderecoEntregasIdEnderecosEntrega");

                    b.HasIndex("IdEnderecoRetiradas");

                    b.HasIndex("IdEnregadoresIdEntregador");

                    b.HasIndex("IdProdutos1");

                    b.HasIndex("IdUsusarioIdUsuario");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("motogoAPI.Entities.Produtos", b =>
                {
                    b.Property<int>("IdProdutos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Altura")
                        .HasColumnType("double");

                    b.Property<double>("Comprimento")
                        .HasColumnType("double");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdUsuario1")
                        .HasColumnType("int");

                    b.Property<double>("Largura")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Peso")
                        .HasColumnType("double");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("IdProdutos");

                    b.HasIndex("IdUsuario1");

                    b.ToTable("Produto");
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

                    b.Property<int>("IdEntregador1")
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

                    b.HasIndex("IdEntregador1");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecosEntregas", b =>
                {
                    b.HasOne("motogoAPI.Entities.Usuarios", "IdUsuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUsuario");
                });

            modelBuilder.Entity("motogoAPI.Entities.EnderecosRetiradas", b =>
                {
                    b.HasOne("motogoAPI.Entities.Usuarios", "IdUsuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUsuario");
                });

            modelBuilder.Entity("motogoAPI.Entities.EndereçoEntregadores", b =>
                {
                    b.HasOne("motogoAPI.Entities.Entregadores", "IdEntregador")
                        .WithMany()
                        .HasForeignKey("IdEntregador1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdEntregador");
                });

            modelBuilder.Entity("motogoAPI.Entities.Pedidos", b =>
                {
                    b.HasOne("motogoAPI.Entities.EnderecosEntregas", "IdEnderecoEntregas")
                        .WithMany()
                        .HasForeignKey("IdEnderecoEntregasIdEnderecosEntrega")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.EnderecosRetiradas", "IdEnderecoRetirada")
                        .WithMany()
                        .HasForeignKey("IdEnderecoRetiradas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.Entregadores", "IdEnregadores")
                        .WithMany()
                        .HasForeignKey("IdEnregadoresIdEntregador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.Produtos", "IdProdutos")
                        .WithMany()
                        .HasForeignKey("IdProdutos1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("motogoAPI.Entities.Usuarios", "IdUsusario")
                        .WithMany()
                        .HasForeignKey("IdUsusarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdEnderecoEntregas");

                    b.Navigation("IdEnderecoRetirada");

                    b.Navigation("IdEnregadores");

                    b.Navigation("IdProdutos");

                    b.Navigation("IdUsusario");
                });

            modelBuilder.Entity("motogoAPI.Entities.Produtos", b =>
                {
                    b.HasOne("motogoAPI.Entities.Usuarios", "IdUsuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUsuario");
                });

            modelBuilder.Entity("motogoAPI.Entities.Veiculos", b =>
                {
                    b.HasOne("motogoAPI.Entities.Entregadores", "IdEntregador")
                        .WithMany()
                        .HasForeignKey("IdEntregador1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdEntregador");
                });
#pragma warning restore 612, 618
        }
    }
}
