﻿// <auto-generated />
using GrpcService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GrpcService.Migrations
{
    [DbContext(typeof(DbApplicationContext))]
    [Migration("20221104100835_readyForHandin")]
    partial class readyForHandin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GrpcService.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("StudyProgrammeId")
                        .HasColumnType("integer");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "sumit",
                            IsAvailable = true,
                            Price = 200.0,
                            StudyProgrammeId = 1,
                            Subject = "How to code",
                            Title = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Author = "christoffer",
                            IsAvailable = true,
                            Price = 300.0,
                            StudyProgrammeId = 1,
                            Subject = "System integration",
                            Title = "Soa"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Author3",
                            IsAvailable = true,
                            Price = 200.0,
                            StudyProgrammeId = 2,
                            Subject = "Development of large systems",
                            Title = "Guide to CI/CD"
                        },
                        new
                        {
                            Id = 4,
                            Author = "TestAuthor4",
                            IsAvailable = true,
                            Price = 350.0,
                            StudyProgrammeId = 2,
                            Subject = "Development of large systems",
                            Title = "Guide to Git flow"
                        });
                });

            modelBuilder.Entity("GrpcService.Models.BookStudentOrder", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.HasKey("StudentId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("BookStudentOrders");
                });

            modelBuilder.Entity("GrpcService.Models.BookStudentOrder", b =>
                {
                    b.HasOne("GrpcService.Models.Book", "Book")
                        .WithMany("BookStudentOrders")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("GrpcService.Models.Book", b =>
                {
                    b.Navigation("BookStudentOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
