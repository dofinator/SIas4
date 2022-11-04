﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using schoolAPI.Contexts;

#nullable disable

namespace schoolAPI.Migrations
{
    [DbContext(typeof(DbApplicationContext))]
    [Migration("20221104095530_final")]
    partial class final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("schoolAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Phillip@gmail.com",
                            Name = "Phillip"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Sumit@gmail.com",
                            Name = "Sumit"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Lukas@gmail.com",
                            Name = "Lukas"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Christoffer@gmail.com",
                            Name = "Christoffer"
                        });
                });

            modelBuilder.Entity("schoolAPI.Models.StudentStudyProgramme", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int>("StudyProgrammeId")
                        .HasColumnType("integer");

                    b.HasKey("StudentId", "StudyProgrammeId");

                    b.HasIndex("StudyProgrammeId");

                    b.ToTable("StudentStudyProgrammes");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            StudyProgrammeId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            StudyProgrammeId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            StudyProgrammeId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            StudyProgrammeId = 1
                        });
                });

            modelBuilder.Entity("schoolAPI.Models.StudyProgramme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StudyProgrammes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "System Integration"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Development of Large Systems"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Test"
                        });
                });

            modelBuilder.Entity("schoolAPI.Models.StudentStudyProgramme", b =>
                {
                    b.HasOne("schoolAPI.Models.Student", "Student")
                        .WithMany("StudentStudyProgramme")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("schoolAPI.Models.StudyProgramme", "StudyProgramme")
                        .WithMany("StudentStudyProgramme")
                        .HasForeignKey("StudyProgrammeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("StudyProgramme");
                });

            modelBuilder.Entity("schoolAPI.Models.Student", b =>
                {
                    b.Navigation("StudentStudyProgramme");
                });

            modelBuilder.Entity("schoolAPI.Models.StudyProgramme", b =>
                {
                    b.Navigation("StudentStudyProgramme");
                });
#pragma warning restore 612, 618
        }
    }
}
