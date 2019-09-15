﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_testing;

namespace Test_testing.Migrations
{
    [DbContext(typeof(DBcontext))]
    [Migration("20190915055356_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test_testing.Models.Athlete", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Athletes");
                });

            modelBuilder.Entity("Test_testing.Models.Test", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AthleteID");

                    b.Property<string>("TestName");

                    b.HasKey("ID");

                    b.HasIndex("AthleteID");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Test_testing.Models.Test", b =>
                {
                    b.HasOne("Test_testing.Models.Athlete", "Athlete")
                        .WithMany("Test")
                        .HasForeignKey("AthleteID");
                });
#pragma warning restore 612, 618
        }
    }
}