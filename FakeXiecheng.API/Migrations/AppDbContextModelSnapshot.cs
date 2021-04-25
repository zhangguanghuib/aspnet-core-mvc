﻿// <auto-generated />
using System;
using FakeXiecheng.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FakeXiecheng.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FakeXiecheng.API.Models.TouristRoute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1500)")
                        .HasMaxLength(1500);

                    b.Property<double?>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fees")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TouristRoutes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("106e9a23-681c-4206-a197-c14d58221409"),
                            CreatedTime = new DateTime(2021, 4, 25, 5, 10, 30, 768, DateTimeKind.Utc).AddTicks(9466),
                            Description = "黄山真好玩",
                            Features = "<p>吃住行娱乐购买</p>",
                            Fees = "<p>交通费用自理</p>",
                            Notes = "<p>小心危险</p>",
                            OriginalPrice = 1299m,
                            Title = "黄山"
                        },
                        new
                        {
                            Id = new Guid("5aee5daf-378f-422c-a9fd-c1f99d009dc0"),
                            CreatedTime = new DateTime(2021, 4, 25, 5, 10, 30, 768, DateTimeKind.Utc).AddTicks(9931),
                            Description = "华山真好玩",
                            Features = "<p>吃住行娱乐购买</p>",
                            Fees = "<p>交通费用自理</p>",
                            Notes = "<p>小心危险</p>",
                            OriginalPrice = 1299m,
                            Title = "华山"
                        });
                });

            modelBuilder.Entity("FakeXiecheng.API.Models.TouristRoutePicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("TouristRouteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("TouristRouteId");

                    b.ToTable("TouristRoutePictures");
                });

            modelBuilder.Entity("FakeXiecheng.API.Models.TouristRoutePicture", b =>
                {
                    b.HasOne("FakeXiecheng.API.Models.TouristRoute", "TouristRoute")
                        .WithMany("TouristRoutePictures")
                        .HasForeignKey("TouristRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
