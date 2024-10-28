﻿// <auto-generated />
using System;
using MaLopez_Examen1P.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaLopez_Examen1P.Migrations
{
    [DbContext(typeof(MaLopez_Examen1PContext))]
    [Migration("20241028155056_MaLopez_DB")]
    partial class MaLopez_DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MaLopez_Examen1P.Models.ML_modelo1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MLDepartamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MLDireccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MLEdad")
                        .HasColumnType("int");

                    b.Property<DateTime>("MLFechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MLIsCliente")
                        .HasColumnType("bit");

                    b.Property<string>("MLNombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("MLSaldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ML_modelo1");
                });
#pragma warning restore 612, 618
        }
    }
}
