﻿// <auto-generated />
using InventatioMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace InventarioMVC.Migrations
{
    [DbContext(typeof(MvcProductoContext))]
    [Migration("20200705235043_MigracionInventario")]
    partial class MigracionInventario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("InventatioMVC.Models.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<int>("ProductosId");

                    b.HasKey("Id");

                    b.HasIndex("ProductosId");

                    b.ToTable("Inventario");
                });

            modelBuilder.Entity("InventatioMVC.Models.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Peso_KG");

                    b.Property<string>("Unidad_Medida")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("InventatioMVC.Models.Inventario", b =>
                {
                    b.HasOne("InventatioMVC.Models.Productos", "Productos")
                        .WithMany()
                        .HasForeignKey("ProductosId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}