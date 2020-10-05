﻿// <auto-generated />
using System;
using CodeSharpener.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeSharpener.Migrations
{
    [DbContext(typeof(CodeSharpenerContext))]
    [Migration("20200930185830_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeSharpener.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.ToTable("Challenge");
                });

            modelBuilder.Entity("CodeSharpener.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConceptLink")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WalkthruLink")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("CodeSharpener.Models.Solution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("UserId");

                    b.ToTable("Solution");
                });

            modelBuilder.Entity("CodeSharpener.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CodeSharpener.Models.Challenge", b =>
                {
                    b.HasOne("CodeSharpener.Models.Content", "Content")
                        .WithMany("Challenge")
                        .HasForeignKey("ContentId")
                        .HasConstraintName("FK__Challenge__Conte__4F7CD00D");
                });

            modelBuilder.Entity("CodeSharpener.Models.Content", b =>
                {
                    b.HasOne("CodeSharpener.Models.Users", "User")
                        .WithMany("Content")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Content__UserId__4CA06362");
                });

            modelBuilder.Entity("CodeSharpener.Models.Solution", b =>
                {
                    b.HasOne("CodeSharpener.Models.Challenge", "Challenge")
                        .WithMany("Solution")
                        .HasForeignKey("ChallengeId")
                        .HasConstraintName("FK__Solution__Challe__5629CD9C");

                    b.HasOne("CodeSharpener.Models.Users", "User")
                        .WithMany("Solution")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Solution__UserId__571DF1D5");
                });
#pragma warning restore 612, 618
        }
    }
}
