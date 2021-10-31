﻿// <auto-generated />
using System;
using ElmålingsSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElmålingsSystem.DAL.Migrations
{
    [DbContext(typeof(MålingContext))]
    partial class MålingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.EjerKunde", b =>
                {
                    b.Property<int>("KundeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ByNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CprNr")
                        .HasColumnType("int");

                    b.Property<string>("Dør")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EfterNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HusNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KommuneNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostNummer")
                        .HasColumnType("int");

                    b.Property<string>("VejNavn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KundeId");

                    b.ToTable("EjerKunder");
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.Installation", b =>
                {
                    b.Property<int>("InstallationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Afbrydelsesart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AflæsningsFrekvens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aflæsningsform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ByNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dør")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EffektgrænseAmpere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EffektgrænseKW")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EjerKundeFK")
                        .HasColumnType("int");

                    b.Property<string>("Etage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ForventetÅrsforbrug")
                        .HasColumnType("float");

                    b.Property<string>("HusNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandeKode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostNummer")
                        .HasColumnType("int");

                    b.Property<string>("Tilslutningstype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VejNavn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstallationsId");

                    b.HasIndex("EjerKundeFK");

                    b.ToTable("Installationer");
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.LejerKunde", b =>
                {
                    b.Property<int>("KundeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ByNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CprNr")
                        .HasColumnType("int");

                    b.Property<string>("Dør")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EfterNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HusNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstallionFK")
                        .HasColumnType("int");

                    b.Property<string>("KommuneNavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostNummer")
                        .HasColumnType("int");

                    b.Property<string>("VejNavn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KundeId");

                    b.HasIndex("InstallionFK")
                        .IsUnique();

                    b.ToTable("LejerKunder");
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.Måler", b =>
                {
                    b.Property<int>("MålerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstallionFK")
                        .HasColumnType("int");

                    b.Property<string>("MålerBeskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MålerCifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MåleromregningsFaktor")
                        .HasColumnType("float");

                    b.Property<string>("Målertype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Målingsenhed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MålerId");

                    b.HasIndex("InstallionFK")
                        .IsUnique();

                    b.ToTable("Måler");
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.Måleværdier", b =>
                {
                    b.Property<int>("MåleraflæsningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AflæsningDatoTid")
                        .HasColumnType("datetime2");

                    b.Property<int>("ForbrugKWH")
                        .HasColumnType("int");

                    b.Property<int>("MålerFK")
                        .HasColumnType("int");

                    b.Property<double>("Tællerstand")
                        .HasColumnType("float");

                    b.HasKey("MåleraflæsningId");

                    b.HasIndex("MålerFK");

                    b.ToTable("Måleværdier");
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.Installation", b =>
                {
                    b.HasOne("ElmålingsSystem.DAL.Models.EjerKunde", "EjerKunde")
                        .WithMany("Installationer")
                        .HasForeignKey("EjerKundeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.LejerKunde", b =>
                {
                    b.HasOne("ElmålingsSystem.DAL.Models.Installation", "Installation")
                        .WithOne("LejerKunde")
                        .HasForeignKey("ElmålingsSystem.DAL.Models.LejerKunde", "InstallionFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.Måler", b =>
                {
                    b.HasOne("ElmålingsSystem.DAL.Models.Installation", "Installation")
                        .WithOne("Måler")
                        .HasForeignKey("ElmålingsSystem.DAL.Models.Måler", "InstallionFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElmålingsSystem.DAL.Models.Måleværdier", b =>
                {
                    b.HasOne("ElmålingsSystem.DAL.Models.Måler", "Måler")
                        .WithMany("Måleværdier")
                        .HasForeignKey("MålerFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
