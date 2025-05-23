﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MisPrimerasAPIs.Migrations
{
    [DbContext(typeof(SQLServer))]
    partial class SQLServerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MisPrimerasAPIs.Models.Cuenta", b =>
                {
                    b.Property<int>("NumeroCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumeroCuenta"));

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.Property<int>("TipoCuenta")
                        .HasColumnType("int");

                    b.HasKey("NumeroCuenta");

                    b.ToTable("Cuenta");
                });
#pragma warning restore 612, 618
        }
    }
}
