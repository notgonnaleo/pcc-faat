﻿// <auto-generated />
using System;
using Backend.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Infrastructure.Migrations.AppDbMigrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("Backend.Domain.Entities.Addresses.Address", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("AddressTypeId")
                        .HasColumnType("integer");

                    b.Property<Guid>("AgentId")
                        .HasColumnType("uuid");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("CityName")
                        .HasColumnType("text");

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("CountryName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<bool?>("Primary")
                        .HasColumnType("boolean");

                    b.Property<string>("Reference")
                        .HasColumnType("text");

                    b.Property<int?>("StateId")
                        .HasColumnType("integer");

                    b.Property<string>("StateName")
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .HasColumnType("text");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = new Guid("6ac52fbb-db9b-4210-9160-aac4a39285c3"),
                            Active = true,
                            AddressTypeId = 1,
                            AgentId = new Guid("ca7f59ef-02aa-45f0-af27-91da78da253f"),
                            CityId = 1,
                            CityName = "Atibaia",
                            CountryId = 1,
                            CountryName = "Brazil",
                            PostalCode = "12947320",
                            Primary = true,
                            Reference = "1350",
                            StateId = 1,
                            StateName = "Sao Paulo",
                            StreetName = "Avenida Paulista",
                            StreetNumber = "1337",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Agents.Agent", b =>
                {
                    b.Property<Guid>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("AgentTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("AgentId");

                    b.HasIndex("AgentTypeId");

                    b.ToTable("Agent");

                    b.HasData(
                        new
                        {
                            AgentId = new Guid("ca7f59ef-02aa-45f0-af27-91da78da253f"),
                            Active = true,
                            AgentTypeId = 2,
                            Name = "Olheiras Clinica Oftalmologica",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        },
                        new
                        {
                            AgentId = new Guid("4c223cf3-a4ee-4bc3-82a0-763a73673114"),
                            Active = true,
                            AgentTypeId = 2,
                            Name = "Fastcar AutoParts",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        },
                        new
                        {
                            AgentId = new Guid("a5c4423a-4e92-4f3d-a4eb-89f1cd1a03d7"),
                            Active = true,
                            AgentTypeId = 2,
                            Name = "Speed Turbo Mecanica e Performance",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Agents.AgentType", b =>
                {
                    b.Property<int>("AgentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("AgentTypeId"));

                    b.Property<string>("AgentTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AgentTypeId");

                    b.ToTable("AgentType");

                    b.HasData(
                        new
                        {
                            AgentTypeId = 1,
                            AgentTypeName = "Company"
                        },
                        new
                        {
                            AgentTypeId = 2,
                            AgentTypeName = "Customer"
                        },
                        new
                        {
                            AgentTypeId = 3,
                            AgentTypeName = "Employee"
                        },
                        new
                        {
                            AgentTypeId = 4,
                            AgentTypeName = "Vendor"
                        },
                        new
                        {
                            AgentTypeId = 5,
                            AgentTypeName = "Physical Store"
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Active = true,
                            CategoryName = "Eletronic",
                            Created = new DateTime(2024, 3, 29, 4, 32, 14, 633, DateTimeKind.Utc).AddTicks(5844),
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Contacts.Email", b =>
                {
                    b.Property<Guid>("EmailAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid>("AgentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<bool?>("Primary")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("EmailAddressId");

                    b.HasIndex("AgentId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            EmailAddressId = new Guid("5f26a4d5-e05f-4d07-ba3d-25324b567b00"),
                            Active = false,
                            AgentId = new Guid("ca7f59ef-02aa-45f0-af27-91da78da253f"),
                            EmailAddress = "lbruni10@gmail.com",
                            Primary = true,
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        },
                        new
                        {
                            EmailAddressId = new Guid("709d8de8-bdb0-4703-81d0-e8d3764ed263"),
                            Active = false,
                            AgentId = new Guid("ca7f59ef-02aa-45f0-af27-91da78da253f"),
                            EmailAddress = "leo.bruni130@gmail.com",
                            Primary = false,
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Contacts.Phone", b =>
                {
                    b.Property<Guid>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid>("AgentId")
                        .HasColumnType("uuid");

                    b.Property<string>("AreaCode")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("Primary")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("PhoneId");

                    b.HasIndex("AgentId");

                    b.ToTable("Phones");

                    b.HasData(
                        new
                        {
                            PhoneId = new Guid("7c6a7504-6747-4a5d-b2df-c43484371138"),
                            Active = false,
                            AgentId = new Guid("ca7f59ef-02aa-45f0-af27-91da78da253f"),
                            AreaCode = "55",
                            PhoneNumber = "11955506737",
                            Primary = true,
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.ProductTypes.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Description = "Crafting material",
                            Name = "Feedstock"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Description = "Intermediate Product/Crafting material",
                            Name = "Intermediate Component"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Description = "Final Product",
                            Name = "Product"
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("ColorName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("GTIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("LiquidWeight")
                        .HasColumnType("double precision");

                    b.Property<string>("MetricUnitName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("SubCategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<double?>("TotalWeight")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("21d0406c-d7cc-434a-abb0-35bdfef54202"),
                            Active = true,
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            ColorName = "Preto",
                            Created = new DateTime(2024, 3, 29, 4, 32, 14, 633, DateTimeKind.Utc).AddTicks(5981),
                            Description = "Produto de teste gerado na migration - Aurora",
                            GTIN = "012345678910111213",
                            LiquidWeight = 0.13,
                            MetricUnitName = "G",
                            Name = "Samsung Galaxy S4",
                            ProductTypeId = 3,
                            SKU = "202401",
                            SubCategoryId = new Guid("cb1dd75f-6cf2-4c6e-b050-ee80444ad1c6"),
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5"),
                            TotalWeight = 0.13,
                            Value = 604.99000000000001
                        },
                        new
                        {
                            ProductId = new Guid("a4508f34-761c-4b22-9ca0-d9fc8d5ac644"),
                            Active = true,
                            ColorName = "Azul-Marinho",
                            Created = new DateTime(2024, 3, 29, 4, 32, 14, 633, DateTimeKind.Utc).AddTicks(5988),
                            Description = "Produto de teste gerado na migration - SampleCompany",
                            GTIN = "012345678910111213",
                            LiquidWeight = 0.0,
                            MetricUnitName = "G",
                            Name = "Motorola Moto E",
                            ProductTypeId = 3,
                            SKU = "202401",
                            TenantId = new Guid("ae100414-8fbb-4286-839a-5bafc51a84fb"),
                            TotalWeight = 0.0,
                            Value = 100.0
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.ProductMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<int>("MediaType")
                        .HasColumnType("integer");

                    b.Property<string>("MediaURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Priority")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductMedia");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.ProductVariant", b =>
                {
                    b.Property<Guid>("VariantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("ColorName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("GTIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("LiquidWeight")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("OverwriteValue")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<double?>("TotalWeight")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<double?>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("VariantId");

                    b.ToTable("ProductVariants");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Profiles.Profile", b =>
                {
                    b.Property<Guid>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("AgentId")
                        .HasColumnType("uuid");

                    b.Property<string>("CNAE")
                        .HasColumnType("text");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("ProfileId");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            ProfileId = new Guid("bf489dd5-c2d6-444d-a761-4184b6471b96"),
                            Active = true,
                            AgentId = new Guid("4c223cf3-a4ee-4bc3-82a0-763a73673114"),
                            CNPJ = "1234556789",
                            CPF = "9876544321",
                            DisplayName = "Leonardo B.",
                            FirstName = "Leonardo",
                            LastName = "Bruni",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Stocks.Stock", b =>
                {
                    b.Property<Guid>("StockMovementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid>("AgentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("MovementDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("MovementType")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("VariantId")
                        .HasColumnType("uuid");

                    b.HasKey("StockMovementId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Backend.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.Property<Guid>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");

                    b.HasData(
                        new
                        {
                            SubCategoryId = new Guid("cb1dd75f-6cf2-4c6e-b050-ee80444ad1c6"),
                            Active = true,
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Created = new DateTime(2024, 3, 29, 4, 32, 14, 633, DateTimeKind.Utc).AddTicks(5940),
                            SubCategoryName = "Smartphone",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Agents.Agent", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Agents.AgentType", "AgentType")
                        .WithMany()
                        .HasForeignKey("AgentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgentType");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Contacts.Email", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Agents.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Contacts.Phone", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Agents.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Backend.Domain.Entities.ProductTypes.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Domain.Entities.SubCategories.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.Navigation("Category");

                    b.Navigation("ProductType");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.ProductMedia", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Backend.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
