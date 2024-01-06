﻿// <auto-generated />
using System;
using ContaCerta.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContaCerta.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240106053446_CriacaoDoBanco")]
    partial class CriacaoDoBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContaCerta.Models.DespesasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormaDePagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantiadeDeParcelasFaltantes")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeParcelasPagas")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeTotalDeParcelas")
                        .HasColumnType("int");

                    b.Property<string>("StatusDoMes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorDaParcela")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotalAPagar")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Despesas");
                });
#pragma warning restore 612, 618
        }
    }
}
