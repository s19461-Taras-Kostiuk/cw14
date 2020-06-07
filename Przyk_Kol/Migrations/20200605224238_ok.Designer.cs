﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Przyk_Kol.Models;

namespace Przyk_Kol.Migrations
{
    [DbContext(typeof(CukierniaDbContext2))]
    [Migration("20200605224238_ok")]
    partial class ok
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Przyk_Kol.Models.Klient3", b =>
                {
                    b.Property<int>("IdKlient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdKlient");

                    b.ToTable("klient3");

                    b.HasData(
                        new
                        {
                            IdKlient = 1,
                            Imie = "Ja",
                            Nazwisko = "AAA"
                        },
                        new
                        {
                            IdKlient = 2,
                            Imie = "Ty",
                            Nazwisko = "BBB"
                        },
                        new
                        {
                            IdKlient = 3,
                            Imie = "On",
                            Nazwisko = "CCC"
                        });
                });

            modelBuilder.Entity("Przyk_Kol.Models.Pracownik3", b =>
                {
                    b.Property<int>("IdPracownik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdPracownik");

                    b.ToTable("pracownik3");

                    b.HasData(
                        new
                        {
                            IdPracownik = 1,
                            Imie = "Ala",
                            Nazwisko = "AAA"
                        },
                        new
                        {
                            IdPracownik = 2,
                            Imie = "Bob",
                            Nazwisko = "BBB"
                        },
                        new
                        {
                            IdPracownik = 3,
                            Imie = "Cezary",
                            Nazwisko = "CCC"
                        });
                });

            modelBuilder.Entity("Przyk_Kol.Models.WyrobCukierniczy3", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CenaZaSzt")
                        .HasColumnType("real");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdWyrobuCukierniczego");

                    b.ToTable("wyrobCukierniczy");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            CenaZaSzt = 20f,
                            Nazwa = "Mak",
                            Typ = "Cukierka"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            CenaZaSzt = 30f,
                            Nazwa = "Artek",
                            Typ = "Wafelka"
                        });
                });

            modelBuilder.Entity("Przyk_Kol.Models.Zamowienie3", b =>
                {
                    b.Property<int>("IdZamowienia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPrzyjecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRealizacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<int>("IdPracownik")
                        .HasColumnType("int");

                    b.Property<int?>("Klient3IdKlient")
                        .HasColumnType("int");

                    b.Property<int?>("Pracownik3IdPracownik")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdZamowienia");

                    b.HasIndex("IdKlient");

                    b.HasIndex("IdPracownik");

                    b.HasIndex("Klient3IdKlient");

                    b.HasIndex("Pracownik3IdPracownik");

                    b.ToTable("zamowienie");

                    b.HasData(
                        new
                        {
                            IdZamowienia = 1,
                            DataPrzyjecia = new DateTime(2006, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 1,
                            IdPracownik = 1,
                            Uwagi = "Wszystko ok"
                        },
                        new
                        {
                            IdZamowienia = 2,
                            DataPrzyjecia = new DateTime(2008, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(2009, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 2,
                            IdPracownik = 2,
                            Uwagi = "Cos nie poszlo :( "
                        });
                });

            modelBuilder.Entity("Przyk_Kol.Models.Zamowienie_WyrobCukierniczy3", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .HasColumnType("int");

                    b.Property<int>("IdZamowienia")
                        .HasColumnType("int");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int?>("WyrobCukierniczy3IdWyrobuCukierniczego")
                        .HasColumnType("int");

                    b.Property<int?>("Zamowienie3IdZamowienia")
                        .HasColumnType("int");

                    b.HasKey("IdWyrobuCukierniczego", "IdZamowienia");

                    b.HasIndex("IdZamowienia");

                    b.HasIndex("WyrobCukierniczy3IdWyrobuCukierniczego");

                    b.HasIndex("Zamowienie3IdZamowienia");

                    b.ToTable("zamowienie_Wyroby");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            IdZamowienia = 1,
                            Ilosc = 12,
                            Uwagi = "Bardzo dobre slodycze"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            IdZamowienia = 2,
                            Ilosc = 19,
                            Uwagi = "Bardzo dobre wafelki"
                        });
                });

            modelBuilder.Entity("Przyk_Kol.Models.Zamowienie3", b =>
                {
                    b.HasOne("Przyk_Kol.Models.Klient3", "klient3")
                        .WithMany()
                        .HasForeignKey("IdKlient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Przyk_Kol.Models.Pracownik3", "pracownik3")
                        .WithMany()
                        .HasForeignKey("IdPracownik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Przyk_Kol.Models.Klient3", null)
                        .WithMany("Zamowienia")
                        .HasForeignKey("Klient3IdKlient");

                    b.HasOne("Przyk_Kol.Models.Pracownik3", null)
                        .WithMany("Zamowienia")
                        .HasForeignKey("Pracownik3IdPracownik");
                });

            modelBuilder.Entity("Przyk_Kol.Models.Zamowienie_WyrobCukierniczy3", b =>
                {
                    b.HasOne("Przyk_Kol.Models.WyrobCukierniczy3", "wyrobCukierniczy")
                        .WithMany()
                        .HasForeignKey("IdWyrobuCukierniczego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Przyk_Kol.Models.Zamowienie3", "zamowienie")
                        .WithMany()
                        .HasForeignKey("IdZamowienia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Przyk_Kol.Models.WyrobCukierniczy3", null)
                        .WithMany("Zamowienie_WyrobCukierniczy")
                        .HasForeignKey("WyrobCukierniczy3IdWyrobuCukierniczego");

                    b.HasOne("Przyk_Kol.Models.Zamowienie3", null)
                        .WithMany("Zamowienie_WyrobCukiernicze")
                        .HasForeignKey("Zamowienie3IdZamowienia");
                });
#pragma warning restore 612, 618
        }
    }
}