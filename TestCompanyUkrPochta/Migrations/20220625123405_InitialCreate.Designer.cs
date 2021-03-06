// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestCompanyUkrPochta.db;

#nullable disable

namespace TestCompanyUkrPochta.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20220625123405_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("TestCompanyUkrPochta.db.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameDepartment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("NameDepartment")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TestCompanyUkrPochta.db.KPI", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Surcharge")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("KPI");
                });

            modelBuilder.Entity("TestCompanyUkrPochta.db.Position", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamePosition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("NamePosition")
                        .IsUnique();

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("TestCompanyUkrPochta.db.Worker", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Employee_number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fatherland")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("KPIid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PositionId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Salary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Employee_number")
                        .IsUnique();

                    b.HasIndex("KPIid");

                    b.HasIndex("PositionId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("TestCompanyUkrPochta.db.Worker", b =>
                {
                    b.HasOne("TestCompanyUkrPochta.db.Department", "Department")
                        .WithMany("Worker")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("TestCompanyUkrPochta.db.KPI", "KPI")
                        .WithMany()
                        .HasForeignKey("KPIid");

                    b.HasOne("TestCompanyUkrPochta.db.Position", "Position")
                        .WithMany("Worker")
                        .HasForeignKey("PositionId");

                    b.Navigation("Department");

                    b.Navigation("KPI");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("TestCompanyUkrPochta.db.Department", b =>
                {
                    b.Navigation("Worker");
                });

            modelBuilder.Entity("TestCompanyUkrPochta.db.Position", b =>
                {
                    b.Navigation("Worker");
                });
#pragma warning restore 612, 618
        }
    }
}
