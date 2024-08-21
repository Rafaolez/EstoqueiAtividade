﻿// <auto-generated />
using System;
using Estoquei.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estoquei.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240821172256_Criacao-Estoquei3")]
    partial class CriacaoEstoquei3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Estoquei.Models.EntradaSaida", b =>
                {
                    b.Property<int>("EntradaSaidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EntradaSaidaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntradaSaidaId"));

                    b.Property<DateTime>("DataMovimentaçãoId")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataMovimentaçãoId");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeMovimentação")
                        .HasColumnType("int")
                        .HasColumnName("QuantidadeMovimentação");

                    b.Property<int>("TipoMovimentacaoId")
                        .HasColumnType("int");

                    b.HasKey("EntradaSaidaId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("TipoMovimentacaoId");

                    b.ToTable("EntradaSaida");
                });

            modelBuilder.Entity("Estoquei.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProdutoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeProduto");

                    b.Property<int>("PesoProduto")
                        .HasColumnType("int")
                        .HasColumnName("PesoProduto");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int")
                        .HasColumnName("QuantidadeEstoque");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Status");

                    b.Property<int>("TipoProdutoId")
                        .HasColumnType("int");

                    b.HasKey("ProdutoId");

                    b.HasIndex("TipoProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Estoquei.Models.TipoMovimentacao", b =>
                {
                    b.Property<int>("TipoMovimentacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoMovimentacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoMovimentacaoId"));

                    b.Property<string>("NomeTipomovimentacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeTipomovimentacao");

                    b.HasKey("TipoMovimentacaoId");

                    b.ToTable("TipoMovimentacao");
                });

            modelBuilder.Entity("Estoquei.Models.TipoProduto", b =>
                {
                    b.Property<int>("TipoProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoProdutoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoProdutoId"));

                    b.Property<string>("NomeTipoProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeTipoProduto");

                    b.HasKey("TipoProdutoId");

                    b.ToTable("TipoProduto");
                });

            modelBuilder.Entity("Estoquei.Models.EntradaSaida", b =>
                {
                    b.HasOne("Estoquei.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estoquei.Models.TipoMovimentacao", "TipoMovimentacao")
                        .WithMany()
                        .HasForeignKey("TipoMovimentacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("TipoMovimentacao");
                });

            modelBuilder.Entity("Estoquei.Models.Produto", b =>
                {
                    b.HasOne("Estoquei.Models.TipoProduto", "TipoProduto")
                        .WithMany()
                        .HasForeignKey("TipoProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
