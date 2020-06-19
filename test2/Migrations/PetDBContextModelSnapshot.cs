﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test2.Models;

namespace test2.Migrations
{
    [DbContext(typeof(PetDBContext))]
    partial class PetDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("test2.Models.BreedType", b =>
                {
                    b.Property<int>("idBreedType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("idBreedType");

                    b.ToTable("BreedType");
                });

            modelBuilder.Entity("test2.Models.Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AdoptedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ApprocimateDateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("date");

                    b.Property<int>("IdBreedType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isMale")
                        .HasColumnType("bit");

                    b.HasKey("IdPet");

                    b.HasIndex("IdBreedType");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("test2.Models.Volunteer", b =>
                {
                    b.Property<int>("IdVolunteer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int?>("IdSupervisor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("date");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("IdVolunteer");

                    b.HasIndex("IdSupervisor");

                    b.ToTable("Volunteer");
                });

            modelBuilder.Entity("test2.Models.Volunteer_Pet", b =>
                {
                    b.Property<int>("IdVolunteer")
                        .HasColumnType("int");

                    b.Property<int>("IdPet")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAccepted")
                        .HasColumnType("date");

                    b.Property<int?>("PetIdPet")
                        .HasColumnType("int");

                    b.Property<int?>("VolunteerIdVolunteer")
                        .HasColumnType("int");

                    b.HasKey("IdVolunteer", "IdPet");

                    b.HasIndex("PetIdPet");

                    b.HasIndex("VolunteerIdVolunteer");

                    b.ToTable("Volunteer_Pet");
                });

            modelBuilder.Entity("test2.Models.Pet", b =>
                {
                    b.HasOne("test2.Models.BreedType", "BreedType")
                        .WithMany("Pets")
                        .HasForeignKey("IdBreedType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("test2.Models.Volunteer", b =>
                {
                    b.HasOne("test2.Models.Volunteer", "Supervisor")
                        .WithMany("Volunteers")
                        .HasForeignKey("IdSupervisor");
                });

            modelBuilder.Entity("test2.Models.Volunteer_Pet", b =>
                {
                    b.HasOne("test2.Models.Pet", null)
                        .WithMany("Volunteer_Pets")
                        .HasForeignKey("PetIdPet");

                    b.HasOne("test2.Models.Volunteer", null)
                        .WithMany("Volunteer_Pets")
                        .HasForeignKey("VolunteerIdVolunteer");
                });
#pragma warning restore 612, 618
        }
    }
}
