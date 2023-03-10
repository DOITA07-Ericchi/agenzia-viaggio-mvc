// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bootstrap_travel_agency_MVC.Databeezu;

#nullable disable

namespace bootstraptravelagencyMVC.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20230116122259_ManyToMany")]
    partial class ManyToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DestinazioneViaggio", b =>
                {
                    b.Property<int>("ListaDestinazioniDestinazioneId")
                        .HasColumnType("int");

                    b.Property<int>("ViaggiPerDestinazioneId")
                        .HasColumnType("int");

                    b.HasKey("ListaDestinazioniDestinazioneId", "ViaggiPerDestinazioneId");

                    b.HasIndex("ViaggiPerDestinazioneId");

                    b.ToTable("DestinazioneViaggio");
                });

            modelBuilder.Entity("bootstrap_travel_agency_MVC.Models.Destinazione", b =>
                {
                    b.Property<int>("DestinazioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinazioneId"));

                    b.Property<string>("CittaArrivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaeseArrivo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinazioneId");

                    b.ToTable("Destinazioni");
                });

            modelBuilder.Entity("bootstrap_travel_agency_MVC.Models.Viaggio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ColorCard")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPartenza")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeViaggio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prezzo")
                        .HasColumnType("float");

                    b.Property<int>("SettimaneViaggio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Viaggi");
                });

            modelBuilder.Entity("DestinazioneViaggio", b =>
                {
                    b.HasOne("bootstrap_travel_agency_MVC.Models.Destinazione", null)
                        .WithMany()
                        .HasForeignKey("ListaDestinazioniDestinazioneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bootstrap_travel_agency_MVC.Models.Viaggio", null)
                        .WithMany()
                        .HasForeignKey("ViaggiPerDestinazioneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
