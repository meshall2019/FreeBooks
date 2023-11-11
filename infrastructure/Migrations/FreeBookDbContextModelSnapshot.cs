﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using infrastructure.Data;

namespace infrastructure.Migrations
{
    [DbContext(typeof(FreeBookDbContext))]
    partial class FreeBookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domin.Entity.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Auther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CatergoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentStaut")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Publish")
                        .HasColumnType("bit");

                    b.Property<Guid>("SubCatergoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CatergoryId");

                    b.HasIndex("SubCatergoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Domin.Entity.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentStaut")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domin.Entity.LogBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("LogBooks");
                });

            modelBuilder.Entity("Domin.Entity.LogCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CatergoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SubCatergoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CatergoryId");

                    b.ToTable("LogCategories");
                });

            modelBuilder.Entity("Domin.Entity.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CatergoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentStaut")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatergoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Domin.Entity.SubLogCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SubCatergoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubCatergoryId");

                    b.ToTable("subLogCategories");
                });

            modelBuilder.Entity("Domin.Entity.Book", b =>
                {
                    b.HasOne("Domin.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CatergoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domin.Entity.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCatergoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Domin.Entity.LogBook", b =>
                {
                    b.HasOne("Domin.Entity.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Domin.Entity.LogCategory", b =>
                {
                    b.HasOne("Domin.Entity.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("CatergoryId");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Domin.Entity.SubCategory", b =>
                {
                    b.HasOne("Domin.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CatergoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domin.Entity.SubLogCategory", b =>
                {
                    b.HasOne("Domin.Entity.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCatergoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
