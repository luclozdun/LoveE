﻿// <auto-generated />
using System;
using AngetPet.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngetPet.Infraestructure.Migrations
{
    [DbContext(typeof(AngetpetDbContext))]
    partial class AngetpetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AngetPet.Domain.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ADMIM"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AnimalId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Image");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Animals", (string)null);
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GenderId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Genders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Macho"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hembra"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sin Especificar"
                        });
                });

            modelBuilder.Entity("AngetPet.Domain.Models.PersonGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PersonGenderId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("PersonGenders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Masculino"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Femenino"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Prefiero no decir"
                        });
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PetId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int")
                        .HasColumnName("AnimalId");

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BackgroundColor");

                    b.Property<string>("BackgroundColorIcon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BackgroundColorIcon");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Birthdate");

                    b.Property<string>("Characteristic")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Characteristic");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created");

                    b.Property<DateTime?>("DateAntiparasiticVaccine")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateAntiparasiticVaccine");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<int>("GenderId")
                        .HasColumnType("int")
                        .HasColumnName("GenderId");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Image");

                    b.Property<bool>("IsAntiparasiticVaccine")
                        .HasColumnType("bit")
                        .HasColumnName("IsAntiparasiticVaccine");

                    b.Property<bool>("IsSterilized")
                        .HasColumnType("bit")
                        .HasColumnName("IsSterilized");

                    b.Property<bool>("IsTrained")
                        .HasColumnType("bit")
                        .HasColumnName("IsTrained");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("SizeId")
                        .HasColumnType("int")
                        .HasColumnName("SizeId");

                    b.Property<string>("SubDescription")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SubDescription");

                    b.Property<string>("TextColor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TextColor");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("GenderId");

                    b.HasIndex("SizeId");

                    b.ToTable("Pets", (string)null);
                });

            modelBuilder.Entity("AngetPet.Domain.Models.PetSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("SkillId");

                    b.ToTable("PetsSkill");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SizeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Sizes", null, t =>
                        {
                            t.Property("Description")
                                .HasColumnName("Description1");
                        });
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SkillId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icon");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Skills", null, t =>
                        {
                            t.Property("Description")
                                .HasColumnName("Description1");
                        });
                });

            modelBuilder.Entity("AngetPet.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeRecover")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CodeRecover");

                    b.Property<string>("CodeVerify")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CodeVerify");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created");

                    b.Property<DateTime?>("DateVerify")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateVerify");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<DateTime?>("ExpiredCodeRecover")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpiredCodeRecover");

                    b.Property<DateTime?>("ExpiredVerifyCode")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpiredVerifyCode");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Image");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<int>("PersonGenderId")
                        .HasColumnType("int")
                        .HasColumnName("PersonGenderId");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated");

                    b.HasKey("Id");

                    b.HasIndex("PersonGenderId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("AngetPet.Domain.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserRoleId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Pet", b =>
                {
                    b.HasOne("AngetPet.Domain.Models.Animal", "Animal")
                        .WithMany("Pets")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngetPet.Domain.Models.Gender", "Gender")
                        .WithMany("Pets")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngetPet.Domain.Models.Size", "Size")
                        .WithMany("Pets")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Gender");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.PetSkill", b =>
                {
                    b.HasOne("AngetPet.Domain.Models.Pet", "Pet")
                        .WithMany("PetSkills")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngetPet.Domain.Models.Skill", "Skill")
                        .WithMany("PetSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.User", b =>
                {
                    b.HasOne("AngetPet.Domain.Models.PersonGender", "PersonGender")
                        .WithMany("Users")
                        .HasForeignKey("PersonGenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonGender");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.UserRole", b =>
                {
                    b.HasOne("AngetPet.Domain.Model.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngetPet.Domain.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AngetPet.Domain.Model.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Animal", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Gender", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.PersonGender", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Pet", b =>
                {
                    b.Navigation("PetSkills");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Size", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.Skill", b =>
                {
                    b.Navigation("PetSkills");
                });

            modelBuilder.Entity("AngetPet.Domain.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
