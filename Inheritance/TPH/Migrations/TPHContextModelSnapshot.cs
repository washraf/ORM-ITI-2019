﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPH;

namespace TPH.Migrations
{
    [DbContext(typeof(TPHContext))]
    partial class TPHContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TPH.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<float>("Price");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Course");
                });

            modelBuilder.Entity("TPH.LabCourse", b =>
                {
                    b.HasBaseType("TPH.Course");

                    b.Property<string>("Location");

                    b.HasDiscriminator().HasValue("LabCourse");
                });

            modelBuilder.Entity("TPH.OnlineCourse", b =>
                {
                    b.HasBaseType("TPH.Course");

                    b.Property<bool>("SelfPaced");

                    b.HasDiscriminator().HasValue("OnlineCourse");
                });
#pragma warning restore 612, 618
        }
    }
}
