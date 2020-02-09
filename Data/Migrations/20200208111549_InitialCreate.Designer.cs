﻿// <auto-generated />
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(EfCrudContext))]
    [Migration("20200208111549_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Models.Veiculos.Caminhao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<short>("AnoFabricacao")
                        .HasColumnType("INTEGER");

                    b.Property<short>("AnoModelo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Modelo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Caminhoes");
                });
#pragma warning restore 612, 618
        }
    }
}
