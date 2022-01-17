﻿// <auto-generated />
using System;
using EntityFramework_pamoka.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFramework_pamoka.Migrations
{
    [DbContext(typeof(PavyzdinisDbContext))]
    [Migration("20220112191834_PirmaMigracija")]
    partial class PirmaMigracija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityFramework_pamoka.Automobilis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Marke")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SavininkoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Automobiliai");
                });

            modelBuilder.Entity("EntityFramework_pamoka.Models.Daiktas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Pavadinimas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SavininkasId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Daiktai");
                });

            modelBuilder.Entity("EntityFramework_pamoka.Models.Savininkas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Vardas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Savininkai");
                });
#pragma warning restore 612, 618
        }
    }
}
