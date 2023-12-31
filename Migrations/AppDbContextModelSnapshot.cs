﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace awsbootcamptest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API.Student", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("age");

                    b.Property<string>("ClassNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("class_number");

                    b.Property<string>("FirstGrade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_grade");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("ProfessorName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("professor_name");

                    b.Property<string>("SecondGrade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("second_grade");

                    b.HasKey("Id");

                    b.ToTable("student");
                });
#pragma warning restore 612, 618
        }
    }
}
