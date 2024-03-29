﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityApplication.Data;

namespace UniversityApplication.Data.Migrations
{
    [DbContext(typeof(UniversityDataContext))]
    [Migration("20211022141148_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddressStudent", b =>
                {
                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("AddressId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("AddressStudent");
                });

            modelBuilder.Entity("UniversityApplication.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AddressId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Country");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("StreetAddress");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("UniversityApplication.Data.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ExamId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Credits")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("Credits");

                    b.Property<string>("Name")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("ProfessorName")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("UniversityApplication.Data.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StudentId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime")
                        .HasColumnName("Date Of Birth");

                    b.Property<DateTime?>("EnrollmentDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Enrollment Date");

                    b.Property<string>("FirstName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("First Name");

                    b.Property<decimal?>("GPA")
                        .HasColumnType("decimal(3,2)")
                        .HasColumnName("GPA");

                    b.Property<string>("LastName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Last Name");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("E-Mail");

                    b.Property<string>("StudentIndex")
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("Student Index");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversityApplication.Data.Models.Transcript", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExamId")
                        .HasColumnType("int")
                        .HasColumnName("ExamId");

                    b.Property<decimal?>("Points")
                        .HasColumnType("decimal(4)")
                        .HasColumnName("Points");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("Transcripts");
                });

            modelBuilder.Entity("AddressStudent", b =>
                {
                    b.HasOne("UniversityApplication.Data.Models.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityApplication.Data.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniversityApplication.Data.Models.Transcript", b =>
                {
                    b.HasOne("UniversityApplication.Data.Models.Exam", "Exam")
                        .WithMany("Students")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityApplication.Data.Models.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityApplication.Data.Models.Exam", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("UniversityApplication.Data.Models.Student", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
