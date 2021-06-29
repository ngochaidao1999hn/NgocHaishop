﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NgocHaishop.Data.EF;

namespace NgocHaishop.Data.Migrations
{
    [DbContext(typeof(NgocHaiShopDbContext))]
    [Migration("20210629040945_Cart Update")]
    partial class CartUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NgocHaishop.Data.Entities.Account", b =>
                {
                    b.Property<int>("Acc_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Acc_Customer")
                        .HasColumnType("int");

                    b.Property<string>("Acc_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Acc_Status")
                        .HasColumnType("int");

                    b.Property<string>("Acc_UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Acc_Id");

                    b.HasIndex("Acc_Customer");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Brand_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Brand_id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Cart", b =>
                {
                    b.Property<int>("Cart_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cart_Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cart_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cart_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cart_PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Cart_Promo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cart_Status")
                        .HasColumnType("int");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.HasKey("Cart_Id");

                    b.HasIndex("Customer_Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.CartDetail", b =>
                {
                    b.Property<int>("Detail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Detail_Cart")
                        .HasColumnType("int");

                    b.Property<decimal>("Detail_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Detail_Product")
                        .HasColumnType("int");

                    b.Property<int>("Detail_Quantity")
                        .HasColumnType("int");

                    b.HasKey("Detail_Id");

                    b.HasIndex("Detail_Cart");

                    b.HasIndex("Detail_Product");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Category", b =>
                {
                    b.Property<int>("Cate_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cate_Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Cate_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cate_Status")
                        .HasColumnType("int");

                    b.HasKey("Cate_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Cus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cus_Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Cus_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Product", b =>
                {
                    b.Property<int>("Pro_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Pro_Brand")
                        .HasColumnType("int");

                    b.Property<int>("Pro_Category")
                        .HasColumnType("int");

                    b.Property<string>("Pro_Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Pro_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pro_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pro_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Pro_Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Pro_Star")
                        .HasColumnType("int");

                    b.Property<int>("Pro_Status")
                        .HasColumnType("int");

                    b.Property<int>("Pro_VỉewCount")
                        .HasColumnType("int");

                    b.HasKey("Pro_Id");

                    b.HasIndex("Pro_Brand");

                    b.HasIndex("Pro_Category");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Review", b =>
                {
                    b.Property<int>("Review_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Review_Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Review_Customer")
                        .HasColumnType("int");

                    b.Property<int>("Review_Product")
                        .HasColumnType("int");

                    b.Property<int>("Review_Star")
                        .HasColumnType("int");

                    b.HasKey("Review_Id");

                    b.HasIndex("Review_Customer");

                    b.HasIndex("Review_Product");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Account", b =>
                {
                    b.HasOne("NgocHaishop.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Acc_Customer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Cart", b =>
                {
                    b.HasOne("NgocHaishop.Data.Entities.Customer", "Customer")
                        .WithMany("Carts")
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.CartDetail", b =>
                {
                    b.HasOne("NgocHaishop.Data.Entities.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("Detail_Cart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NgocHaishop.Data.Entities.Product", "Product")
                        .WithMany("CartDetails")
                        .HasForeignKey("Detail_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Product", b =>
                {
                    b.HasOne("NgocHaishop.Data.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("Pro_Brand")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NgocHaishop.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Pro_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Review", b =>
                {
                    b.HasOne("NgocHaishop.Data.Entities.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("Review_Customer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NgocHaishop.Data.Entities.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("Review_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Customer", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("NgocHaishop.Data.Entities.Product", b =>
                {
                    b.Navigation("CartDetails");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}