﻿// <auto-generated />
using System;
using Funemployment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Funemployment.Migrations
{
    [DbContext(typeof(FunemploymentDbContext))]
    [Migration("20180702191754_Models")]
    partial class Models
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Funemployment.Models.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int>("PID");

                    b.Property<int?>("PlayerID");

                    b.Property<int>("QID");

                    b.HasKey("ID");

                    b.HasIndex("PlayerID");

                    b.ToTable("AnswersTable");
                });

            modelBuilder.Entity("Funemployment.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<string>("Location");

                    b.Property<int>("Points");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("PlayerTable");
                });

            modelBuilder.Entity("Funemployment.Models.Answer", b =>
                {
                    b.HasOne("Funemployment.Models.Player")
                        .WithMany("MyAnswers")
                        .HasForeignKey("PlayerID");
                });
#pragma warning restore 612, 618
        }
    }
}
