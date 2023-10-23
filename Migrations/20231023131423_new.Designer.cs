﻿// <auto-generated />
using System;
using CollegeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CollegeManagement.Migrations
{
    [DbContext(typeof(CollegeManagementContext))]
    [Migration("20231023131423_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CollegeManagement.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electrical Engineering"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Computer Science"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mechanical Engineering"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Civil Engineering"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chemical Engineering"
                        });
                });

            modelBuilder.Entity("CollegeManagement.Models.CourseSubject", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CourseSubjects");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            CourseId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            CourseId = 1,
                            SubjectId = 6
                        },
                        new
                        {
                            CourseId = 2,
                            SubjectId = 3
                        },
                        new
                        {
                            CourseId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            CourseId = 2,
                            SubjectId = 6
                        },
                        new
                        {
                            CourseId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            CourseId = 3,
                            SubjectId = 4
                        },
                        new
                        {
                            CourseId = 3,
                            SubjectId = 7
                        },
                        new
                        {
                            CourseId = 4,
                            SubjectId = 8
                        },
                        new
                        {
                            CourseId = 4,
                            SubjectId = 6
                        },
                        new
                        {
                            CourseId = 4,
                            SubjectId = 4
                        },
                        new
                        {
                            CourseId = 5,
                            SubjectId = 5
                        },
                        new
                        {
                            CourseId = 5,
                            SubjectId = 7
                        },
                        new
                        {
                            CourseId = 5,
                            SubjectId = 9
                        });
                });

            modelBuilder.Entity("CollegeManagement.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("CollegeManagement.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Professors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 40,
                            Name = "John Smith",
                            Salary = 5000m
                        },
                        new
                        {
                            Id = 2,
                            Age = 45,
                            Name = "Emily Johnson",
                            Salary = 5500m
                        },
                        new
                        {
                            Id = 3,
                            Age = 38,
                            Name = "Michael Williams",
                            Salary = 4800m
                        },
                        new
                        {
                            Id = 4,
                            Age = 50,
                            Name = "Jessica Brown",
                            Salary = 6000m
                        },
                        new
                        {
                            Id = 5,
                            Age = 42,
                            Name = "Daniel Miller",
                            Salary = 5200m
                        },
                        new
                        {
                            Id = 6,
                            Age = 36,
                            Name = "Olivia Davis",
                            Salary = 4700m
                        },
                        new
                        {
                            Id = 7,
                            Age = 48,
                            Name = "David Garcia",
                            Salary = 5800m
                        },
                        new
                        {
                            Id = 8,
                            Age = 44,
                            Name = "Sophia Wilson",
                            Salary = 5300m
                        },
                        new
                        {
                            Id = 9,
                            Age = 39,
                            Name = "Joseph Taylor",
                            Salary = 4900m
                        },
                        new
                        {
                            Id = 10,
                            Age = 37,
                            Name = "Emma Anderson",
                            Salary = 4600m
                        });
                });

            modelBuilder.Entity("CollegeManagement.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId1");

                    b.HasIndex("SubjectId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CollegeManagement.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mathematics",
                            ProfessorId = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Physics",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Computer Science",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mechanics",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chemistry",
                            ProfessorId = 6
                        },
                        new
                        {
                            Id = 6,
                            Name = "Logic Systems",
                            ProfessorId = 7
                        },
                        new
                        {
                            Id = 7,
                            Name = "Termodynamics",
                            ProfessorId = 8
                        },
                        new
                        {
                            Id = 8,
                            Name = "Economy",
                            ProfessorId = 9
                        },
                        new
                        {
                            Id = 9,
                            Name = "Probability",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 10,
                            Name = "Programming",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("CourseSubject", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("CourseSubject");
                });

            modelBuilder.Entity("CollegeManagement.Models.CourseSubject", b =>
                {
                    b.HasOne("CollegeManagement.Models.Course", "Course")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeManagement.Models.Subject", "Subject")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("CollegeManagement.Models.Grade", b =>
                {
                    b.HasOne("CollegeManagement.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeManagement.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("CollegeManagement.Models.Student", b =>
                {
                    b.HasOne("CollegeManagement.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeManagement.Models.Subject", null)
                        .WithMany("Students")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CollegeManagement.Models.Subject", b =>
                {
                    b.HasOne("CollegeManagement.Models.Professor", "Professor")
                        .WithMany("Subjects")
                        .HasForeignKey("ProfessorId");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("CourseSubject", b =>
                {
                    b.HasOne("CollegeManagement.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeManagement.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CollegeManagement.Models.Course", b =>
                {
                    b.Navigation("CourseSubjects");
                });

            modelBuilder.Entity("CollegeManagement.Models.Professor", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("CollegeManagement.Models.Student", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("CollegeManagement.Models.Subject", b =>
                {
                    b.Navigation("CourseSubjects");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
