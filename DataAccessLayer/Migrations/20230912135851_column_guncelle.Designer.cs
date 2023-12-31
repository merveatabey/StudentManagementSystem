﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230912135851_column_guncelle")]
    partial class column_guncelle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoursesDepartment", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsDepartmentID")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "DepartmentsDepartmentID");

                    b.HasIndex("DepartmentsDepartmentID");

                    b.ToTable("CoursesDepartment");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Courses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<double>("Exam1")
                        .HasColumnType("float");

                    b.Property<double>("Exam2")
                        .HasColumnType("float");

                    b.Property<int>("StdID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.StudentInfo", b =>
                {
                    b.Property<int>("StdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StdID"));

                    b.Property<int>("AbsentDay")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CoursesId")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StdBirthDay")
                        .HasColumnType("int");

                    b.Property<string>("StdClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StdName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StdNum")
                        .HasColumnType("int");

                    b.Property<string>("StdSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TC")
                        .HasColumnType("int");

                    b.HasKey("StdID");

                    b.HasIndex("CoursesId");

                    b.ToTable("StudentInfos");
                });

            modelBuilder.Entity("CoursesDepartment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Courses", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Concrete.StudentInfo", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Courses", null)
                        .WithMany("StudentInfos")
                        .HasForeignKey("CoursesId");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Courses", b =>
                {
                    b.Navigation("StudentInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
