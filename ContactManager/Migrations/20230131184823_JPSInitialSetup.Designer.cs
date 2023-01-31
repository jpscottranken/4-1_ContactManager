﻿// <auto-generated />
using System;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactManager.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20230131184823_JPSInitialSetup")]
    partial class JPSInitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactManager.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 1, 31, 12, 48, 23, 9, DateTimeKind.Local).AddTicks(3677),
                            Email = "MaryEllen@yahoo.com",
                            Firstname = "Mary Ellen",
                            Lastname = "Walton",
                            Phone = "555-123-4567"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = 2,
                            DateAdded = new DateTime(2023, 1, 31, 12, 48, 23, 12, DateTimeKind.Local).AddTicks(3704),
                            Email = "delores@hotmail.com",
                            Firstname = "Delores",
                            Lastname = "Del Rio",
                            Phone = "555-987-6543"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = 3,
                            DateAdded = new DateTime(2023, 1, 31, 12, 48, 23, 12, DateTimeKind.Local).AddTicks(3749),
                            Email = "efren@aol.com",
                            Firstname = "Efren",
                            Lastname = "Herrera",
                            Phone = "555-456-7890"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.HasOne("ContactManager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
