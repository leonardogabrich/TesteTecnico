﻿// <auto-generated />
using Cadastro.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cadastro.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210308124130_CreateProcedure")]
    partial class CreateProcedure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Cadastro.API.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Email = "12345678@gmail.com",
                            Endereco = "RUA JAMIL JOÃO ZARIF",
                            Nome = "JOSE"
                        },
                        new
                        {
                            Id = 13,
                            Email = "12345679@gmail.com",
                            Endereco = "RUA CORONEL JOÃO AFFONSO",
                            Nome = "RODINEIA"
                        },
                        new
                        {
                            Id = 14,
                            Email = "12345680@gmail.com",
                            Endereco = "RUA JAMIL JOÃO ZARIF",
                            Nome = "DANIELLY"
                        },
                        new
                        {
                            Id = 15,
                            Email = "12345681@gmail.com",
                            Endereco = "RUA JAMIL JOÃO ZARIF",
                            Nome = "ROSEVANIA"
                        },
                        new
                        {
                            Id = 16,
                            Email = "12345682@gmail.com",
                            Endereco = "RUA JAMIL JOÃO ZARIF",
                            Nome = "JULIANA"
                        },
                        new
                        {
                            Id = 22,
                            Email = "12345683@gmail.com",
                            Endereco = "RUA BENJAMIN CONSTANT",
                            Nome = "EVANDRO"
                        },
                        new
                        {
                            Id = 28,
                            Email = "12345684@gmail.com",
                            Endereco = "RUA ARAGÃO",
                            Nome = "LUIS ANTONIO"
                        },
                        new
                        {
                            Id = 29,
                            Email = "12345685@gmail.com",
                            Endereco = "AVENIDA ARMANDO ÍTALO SETTI",
                            Nome = "LUCIO"
                        },
                        new
                        {
                            Id = 30,
                            Email = "12345686@gmail.com",
                            Endereco = "AVENIDA ARMANDO ÍTALO SETTI",
                            Nome = "MIGUEL"
                        },
                        new
                        {
                            Id = 31,
                            Email = "12345687@gmail.com",
                            Endereco = "AVENIDA ARMANDO ÍTALO SETTI",
                            Nome = "LUCIANO"
                        },
                        new
                        {
                            Id = 32,
                            Email = "12345688@gmail.com",
                            Endereco = "AVENIDA ARMANDO ÍTALO SETTI",
                            Nome = "JOSE RODRIGUES"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
