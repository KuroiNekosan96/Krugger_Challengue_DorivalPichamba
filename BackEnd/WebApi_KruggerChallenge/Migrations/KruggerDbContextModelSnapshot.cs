﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi_KruggerChallenge;

#nullable disable

namespace WebApi_KruggerChallenge.Migrations
{
    [DbContext(typeof(KruggerDbContext))]
    partial class KruggerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApi_KruggerChallenge.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id_clie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ci")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Dom_lat")
                        .HasColumnType("double precision");

                    b.Property<double>("Dom_long")
                        .HasColumnType("double precision");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("User_clie")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id_clie");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("WebApi_KruggerChallenge.Models.Sector", b =>
                {
                    b.Property<Guid>("Id_sector")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("hora_fin")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("hora_inicio")
                        .HasColumnType("time");

                    b.Property<string>("nombre_sector")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("sec_lat")
                        .HasColumnType("double precision");

                    b.Property<double>("sec_long")
                        .HasColumnType("double precision");

                    b.HasKey("Id_sector");

                    b.ToTable("Sector");
                });
#pragma warning restore 612, 618
        }
    }
}
