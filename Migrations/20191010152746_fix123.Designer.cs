﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using a101_backend.Models;

namespace a101_backend.Migrations
{
    [DbContext(typeof(Models.AppContext))]
    [Migration("20191010152746_fix123")]
    partial class fix123
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("a101_backend.Models.DataBase.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.HasKey("CityID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("a101_backend.Models.DataBase.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactPersonCompanyState");

                    b.Property<string>("ContactPersonFullName");

                    b.Property<string>("ContactPersonPhoneNumber");

                    b.Property<int>("PartnerInfoID");

                    b.Property<int>("Status");

                    b.HasKey("CompanyID");

                    b.HasIndex("CityID");

                    b.HasIndex("PartnerInfoID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("a101_backend.Models.DataBase.Document", b =>
                {
                    b.Property<int>("DocumentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyID");

                    b.Property<string>("DocumentName");

                    b.Property<int>("DocumentStatus");

                    b.Property<int>("PartnerInfoID");

                    b.HasKey("DocumentID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("a101_backend.Models.DataBase.PartnerInfo", b =>
                {
                    b.Property<int>("PartnerInfoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityID");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyState");

                    b.Property<string>("FullName");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("UserID");

                    b.HasKey("PartnerInfoID");

                    b.HasIndex("CityID");

                    b.HasIndex("UserID");

                    b.ToTable("PartnerInfo");
                });

            modelBuilder.Entity("a101_backend.Models.DataBase.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PasswordHash");

                    b.Property<int>("Role");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("a101_backend.Models.DataBase.Company", b =>
                {
                    b.HasOne("a101_backend.Models.DataBase.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("a101_backend.Models.DataBase.PartnerInfo", "PartnerInfo")
                        .WithMany()
                        .HasForeignKey("PartnerInfoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("a101_backend.Models.DataBase.PartnerInfo", b =>
                {
                    b.HasOne("a101_backend.Models.DataBase.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("a101_backend.Models.DataBase.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
