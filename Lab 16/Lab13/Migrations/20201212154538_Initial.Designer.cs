﻿// <auto-generated />
using System;
using Lab13.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab13.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20201212154538_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Lab13.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfHire")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1700, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1750, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Santa",
                            LastName = "Clause",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(1996, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2020, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            LastName = "Doe",
                            ManagerId = 1
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1987, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2001, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            LastName = "Doe",
                            ManagerId = 1
                        });
                });

            modelBuilder.Entity("Lab13.Models.Sales", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double?>("Amount")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("Quarter")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SalesId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Lab13.Models.Sales", b =>
                {
                    b.HasOne("Lab13.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
