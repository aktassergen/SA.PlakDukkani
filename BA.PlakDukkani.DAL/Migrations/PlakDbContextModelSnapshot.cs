﻿// <auto-generated />
using System;
using BA.PlakDukkani.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BA.PlakDukkani.DAL.Migrations
{
    [DbContext(typeof(PlakDbContext))]
    partial class PlakDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BA.PlakDukkani.Entity.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sanatci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SatistaMi")
                        .HasColumnType("bit");

                    b.Property<int>("YoneticiId")
                        .HasColumnType("int");

                    b.Property<decimal?>("İndirimOrani")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("YoneticiId");

                    b.ToTable("Albumler");
                });

            modelBuilder.Entity("BA.PlakDukkani.Entity.Entities.Yonetici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciAdi")
                        .IsUnique();

                    b.ToTable("Yoneticiler");
                });

            modelBuilder.Entity("BA.PlakDukkani.Entity.Entities.Album", b =>
                {
                    b.HasOne("BA.PlakDukkani.Entity.Entities.Yonetici", "Yonetici")
                        .WithMany("Albumler")
                        .HasForeignKey("YoneticiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yonetici");
                });

            modelBuilder.Entity("BA.PlakDukkani.Entity.Entities.Yonetici", b =>
                {
                    b.Navigation("Albumler");
                });
#pragma warning restore 612, 618
        }
    }
}
