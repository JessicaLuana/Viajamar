﻿// <auto-generated />
using System;
using AgenciaViajamar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgenciaViajamar.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211230190150_newdb")]
    partial class newdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AgenciaViajamar.Models.Atendimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("atendimento");
                });

            modelBuilder.Entity("AgenciaViajamar.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<int?>("Comprasid")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Comprasid");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("AgenciaViajamar.Models.Compras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("Ida")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Volta")
                        .HasColumnType("datetime2");

                    b.Property<int>("idCompra")
                        .HasColumnType("int");

                    b.Property<int>("idComprador")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("compras");
                });

            modelBuilder.Entity("AgenciaViajamar.Models.Destinos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("local")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("destinos");
                });

            modelBuilder.Entity("AgenciaViajamar.Models.Cliente", b =>
                {
                    b.HasOne("AgenciaViajamar.Models.Compras", "Compras")
                        .WithMany()
                        .HasForeignKey("Comprasid");

                    b.Navigation("Compras");
                });
#pragma warning restore 612, 618
        }
    }
}
