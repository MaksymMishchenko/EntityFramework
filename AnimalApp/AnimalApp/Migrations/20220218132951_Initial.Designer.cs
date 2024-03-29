﻿// <auto-generated />
using AnimalApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalApp.Migrations
{
    [DbContext(typeof(AnimalDb))]
    [Migration("20220218132951_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnimalApp.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("AnimalApp.Models.Animal", b =>
                {
                    b.OwnsOne("AnimalApp.Models.FoodInformation", "FeedInformation", b1 =>
                        {
                            b1.Property<int>("AnimalId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.HasKey("AnimalId");

                            b1.ToTable("Animals");

                            b1.WithOwner()
                                .HasForeignKey("AnimalId");

                            b1.OwnsOne("AnimalApp.Models.Food", "Key", b2 =>
                                {
                                    b2.Property<int>("FoodInformationAnimalId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                                    b2.Property<string>("Feed")
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Kind")
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("FoodInformationAnimalId");

                                    b2.ToTable("Animals");

                                    b2.WithOwner()
                                        .HasForeignKey("FoodInformationAnimalId");
                                });

                            b1.OwnsOne("AnimalApp.Models.Food", "Value", b2 =>
                                {
                                    b2.Property<int>("FoodInformationAnimalId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                                    b2.Property<string>("Feed")
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Kind")
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("FoodInformationAnimalId");

                                    b2.ToTable("Animals");

                                    b2.WithOwner()
                                        .HasForeignKey("FoodInformationAnimalId");
                                });

                            b1.Navigation("Key");

                            b1.Navigation("Value");
                        });

                    b.Navigation("FeedInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
