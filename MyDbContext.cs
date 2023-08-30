using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using motogoAPI.Entities;

namespace motogoAPI;

public partial class MyDbContext : DbContext
{

        public DbSet<Usuarios> Usuario {get; set;}
        public DbSet<Entregadores> Entregador {get; set;}
        public DbSet<Veiculos> Veiculo {get; set;}
        public DbSet<EnderecoEntregadores> EnderecoEntregador {get; set;}
        public DbSet<EnderecosRetiradas> EnderecoRetirada {get; set;}
        public DbSet<EnderecosEntregas> EnderecoEntrega {get; set;}
        public DbSet<EnderecoUsuarios> EnderecoUsuario {get; set;}
        public DbSet<EnderecoFuncionarios> EnderecoFuncionario {get; set;}
        public DbSet<Pedidos> Pedido {get; set;}
        public DbSet<Remessa> Remessa {get; set;}
        public DbSet<Funcionarios> Funcionario  {get; set;}
        public DbSet<Precos> Preco {get; set;}
        
        public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost; port=3306; user id=root;password=Senai2022;database=MotoGo_DB", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
