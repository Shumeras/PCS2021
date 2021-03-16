﻿//// <auto-generated />
//using System;
//using EFDemo.DataAccess;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

//namespace EFDemo.Migrations.Old
//{
//    [DbContext(typeof(ShopContext))]
//    [Migration("20210304122712_UpdatedDB")]
//    partial class UpdatedDB
//    {
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("Relational:MaxIdentifierLength", 128)
//                .HasAnnotation("ProductVersion", "5.0.3")
//                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//            modelBuilder.Entity("EFDemo.Models.Customer", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<string>("Address")
//                        .HasMaxLength(256)
//                        .HasColumnType("nvarchar(256)");

//                    b.Property<string>("FirstName")
//                        .IsRequired()
//                        .HasMaxLength(64)
//                        .HasColumnType("nvarchar(64)");

//                    b.Property<string>("LastName")
//                        .IsRequired()
//                        .HasMaxLength(64)
//                        .HasColumnType("nvarchar(64)");

//                    b.HasKey("Id");

//                    b.ToTable("Customers");
//                });

//            modelBuilder.Entity("EFDemo.Models.Order", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int>("CustomerId")
//                        .HasColumnType("int");

//                    b.Property<DateTime>("Date")
//                        .HasColumnType("datetime2");

//                    b.HasKey("Id");

//                    b.HasIndex("CustomerId");

//                    b.ToTable("Orders");
//                });

//            modelBuilder.Entity("EFDemo.Models.OrderProduct", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int?>("OrderId")
//                        .HasColumnType("int");

//                    b.Property<int?>("ProductId")
//                        .HasColumnType("int");

//                    b.Property<int>("Quantity")
//                        .HasColumnType("int");

//                    b.HasKey("Id");

//                    b.HasIndex("OrderId");

//                    b.HasIndex("ProductId");

//                    b.ToTable("OrderProducts");
//                });

//            modelBuilder.Entity("EFDemo.Models.Product", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasMaxLength(64)
//                        .HasColumnType("nvarchar(64)");

//                    b.Property<float>("Price")
//                        .HasColumnType("real");

//                    b.HasKey("Id");

//                    b.ToTable("Products");
//                });

//            modelBuilder.Entity("EFDemo.Models.Order", b =>
//                {
//                    b.HasOne("EFDemo.Models.Customer", "Customer")
//                        .WithMany("Orders")
//                        .HasForeignKey("CustomerId")
//                        .OnDelete(DeleteBehavior.Cascade)
//                        .IsRequired();

//                    b.Navigation("Customer");
//                });

//            modelBuilder.Entity("EFDemo.Models.OrderProduct", b =>
//                {
//                    b.HasOne("EFDemo.Models.Order", "Order")
//                        .WithMany("OrderProducts")
//                        .HasForeignKey("OrderId");

//                    b.HasOne("EFDemo.Models.Product", "Product")
//                        .WithMany("OrderProducts")
//                        .HasForeignKey("ProductId");

//                    b.Navigation("Order");

//                    b.Navigation("Product");
//                });

//            modelBuilder.Entity("EFDemo.Models.Customer", b =>
//                {
//                    b.Navigation("Orders");
//                });

//            modelBuilder.Entity("EFDemo.Models.Order", b =>
//                {
//                    b.Navigation("OrderProducts");
//                });

//            modelBuilder.Entity("EFDemo.Models.Product", b =>
//                {
//                    b.Navigation("OrderProducts");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}
