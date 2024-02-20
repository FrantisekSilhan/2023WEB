﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ef_pages.Data;

#nullable disable

namespace ef_pages.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240220081409_add mento")]
    partial class addmento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("ef_pages.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("ef_pages.Models.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("ef_pages.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectShortName")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.HasKey("SubjectId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("ef_pages.Models.SubjectOnClass", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectOnClassId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("ClassId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("SubjectOnClassId")
                        .IsUnique();

                    b.HasIndex("TeacherId");

                    b.ToTable("subjectOnClasses");
                });

            modelBuilder.Entity("ef_pages.Models.Teacher", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MentorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("TeacherId");

                    b.HasIndex("MentorId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ef_pages.Models.Student", b =>
                {
                    b.HasOne("ef_pages.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("ef_pages.Models.SubjectOnClass", b =>
                {
                    b.HasOne("ef_pages.Models.Class", "Class")
                        .WithMany("subjectOnClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ef_pages.Models.Subject", "Subject")
                        .WithMany("subjectOnClasses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ef_pages.Models.Teacher", null)
                        .WithMany("subjectOnClasses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ef_pages.Models.Teacher", b =>
                {
                    b.HasOne("ef_pages.Models.Teacher", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("ef_pages.Models.Class", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("subjectOnClasses");
                });

            modelBuilder.Entity("ef_pages.Models.Subject", b =>
                {
                    b.Navigation("subjectOnClasses");
                });

            modelBuilder.Entity("ef_pages.Models.Teacher", b =>
                {
                    b.Navigation("subjectOnClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
