﻿// <auto-generated />
using System;
using ControleDeOrcamentoFamiliar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleDeOrcamentoFamiliar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("ControleDeOrcamentoFamiliar.Models.Despesas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDespesa")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoDespesa")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<double>("ValorDespesa")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("ControleDeOrcamentoFamiliar.Receitas", b =>
                {
                    b.Property<int>("IdReceita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataReceita")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoReceita")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<double>("ValorReceita")
                        .HasColumnType("double");

                    b.HasKey("IdReceita");

                    b.ToTable("receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
