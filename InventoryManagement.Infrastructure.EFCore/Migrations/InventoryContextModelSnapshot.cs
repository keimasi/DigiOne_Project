﻿// <auto-generated />
using System;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryManagement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryManagement.Domain.Inventory.InventoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("InventoryManagement.Domain.Inventory.InventoryEntity", b =>
                {
                    b.OwnsMany("InventoryManagement.Domain.Inventory.OperationInventory", "OperationInventories", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Count")
                                .HasColumnType("int");

                            b1.Property<int>("CurrentCount")
                                .HasColumnType("int");

                            b1.Property<string>("Description")
                                .HasMaxLength(500)
                                .HasColumnType("nvarchar(500)");

                            b1.Property<int>("InventoryId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("OperationDate")
                                .HasColumnType("datetime2");

                            b1.Property<bool>("OperationType")
                                .HasColumnType("bit");

                            b1.Property<int>("OperatorId")
                                .HasColumnType("int");

                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.HasKey("Id");

                            b1.HasIndex("InventoryId");

                            b1.ToTable("OperationInventory");

                            b1.WithOwner("Inventory")
                                .HasForeignKey("InventoryId");

                            b1.Navigation("Inventory");
                        });

                    b.Navigation("OperationInventories");
                });
#pragma warning restore 612, 618
        }
    }
}
