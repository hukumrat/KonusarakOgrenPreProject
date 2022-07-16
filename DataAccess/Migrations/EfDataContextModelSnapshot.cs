﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(EfDataContext))]
    partial class EfDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KonusarakOgrenPreProject.Areas.Admin.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Vestibulum convallis aptent massa mollis aliquam conubia enim purus rutrum orci facilisis aenean dignissim habitasse venenatis phasellus consectetur nascetur sapien",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fames aliquet si tellus lorem eleifend orci nisi netus massa parturient curae sit urna vitae congue risus eros id senectus",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Quis justo mollis duis mattis sapien dis si quisque nunc metus class volutpat tempor lectus a nisl hendrerit etiam massa",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Maximus aptent cras consequat tristique proin rhoncus urna maecenas a si bibendum egestas augue adipiscing vehicula mus iaculis ultricies quam",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "Bibendum feugiat viverra nullam interdum mauris venenatis eleifend condimentum augue eu tempor vitae finibus luctus tellus pede nibh egestas facilisis",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "Metus erat fermentum vivamus scelerisque mollis condimentum nunc tristique nisl nascetur hac egestas blandit phasellus suscipit auctor class consectetur consequat",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            Description = "Consectetuer nullam sollicitudin letius torquent finibus in tincidunt accumsan maximus volutpat ad adipiscing curabitur commodo ut eget nibh suspendisse lacus",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            Description = "Rutrum nullam dictumst habitasse facilisi sit placerat praesent libero felis mauris fringilla porttitor tempor vestibulum bibendum amet nam class est",
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            Description = "Molestie odio dictumst rutrum condimentum imperdiet aliquet vel massa accumsan dictum per netus inceptos lacus justo ultricies purus lorem enim",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            Description = "Enim cubilia sodales ligula ornare luctus sapien ut neque dictum laoreet aptent malesuada porta faucibus fames posuere consectetuer pretium adipiscing",
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("KonusarakOgrenPreProject.Areas.Admin.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Path = "/Images/Lamp/1.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Path = "/Images/Bicycle/1.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            Path = "/Images/Table/1.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            Path = "/Images/Monitor/1.jpg",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            Path = "/Images/Wardrobe/1.jpg",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            Path = "/Images/Vacuum Cleaner/1.jpg",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            Path = "/Images/Fridge/1.jpg",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            Path = "/Images/Television/1.jpg",
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            Path = "/Images/Bed/1.jpg",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            Path = "/Images/Washing Machine/1.jpg",
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("KonusarakOgrenPreProject.Areas.Admin.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Philips",
                            Color = "White",
                            Description = "Mauris nullam consectetuer placerat vulputate eu metus suspendisse natoque cras dis accumsan primis donec fusce si nascetur nisi litora odio",
                            Name = "Lamp",
                            Quantity = 100,
                            Weight = 11.5
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Sedona",
                            Color = "Black",
                            Description = "In velit per rutrum adipiscing nisi ante facilisi cursus montes accumsan suspendisse pulvinar leo tellus mollis metus fusce quis faucibus",
                            Name = "Bicycle",
                            Quantity = 90,
                            Weight = 23.800000000000001
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Bellona",
                            Color = "Green",
                            Description = "Pulvinar tincidunt potenti velit taciti aptent augue conubia gravida odio volutpat rhoncus ipsum inceptos facilisis adipiscing primis dis elit ullamcorper",
                            Name = "Table",
                            Quantity = 80,
                            Weight = 35.899999999999999
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Asus",
                            Color = "Blue",
                            Description = "Lorem maximus condimentum est nunc urna purus sem arcu in sit mauris fusce tincidunt tristique maecenas iaculis nec mollis ad",
                            Name = "Monitor",
                            Quantity = 70,
                            Weight = 42.399999999999999
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Bellona",
                            Color = "Red",
                            Description = "Ipsum tristique nunc condimentum fusce ante consectetur litora platea ultricies congue etiam eros vivamus pharetra venenatis fringilla maximus integer conubia",
                            Name = "Wardrobe",
                            Quantity = 60,
                            Weight = 56.799999999999997
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Fakir",
                            Color = "Orange",
                            Description = "Proin scelerisque phasellus augue netus nascetur ante purus lorem neque mauris commodo nam quisque finibus vivamus imperdiet nec himenaeos cursus",
                            Name = "Vacuum Cleaner",
                            Quantity = 50,
                            Weight = 68.400000000000006
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Arçelik",
                            Color = "White",
                            Description = "Eros mauris primis lobortis tellus netus potenti sapien consectetur dui eu magnis dictum gravida parturient est massa non felis sagittis",
                            Name = "Fridge",
                            Quantity = 40,
                            Weight = 74.799999999999997
                        },
                        new
                        {
                            Id = 8,
                            Brand = "LG",
                            Color = "Black",
                            Description = "Feugiat curae quisque pede accumsan sed dis sodales ante convallis parturient cursus lectus platea duis maecenas non netus fermentum maximus",
                            Name = "Television",
                            Quantity = 30,
                            Weight = 89.5
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Bellona",
                            Color = "Brown",
                            Description = "Quam leo platea vehicula posuere iaculis adipiscing morbi cursus sollicitudin feugiat dapibus dolor eu tellus tortor accumsan nec tempor hendrerit",
                            Name = "Bed",
                            Quantity = 20,
                            Weight = 91.5
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Arçelik",
                            Color = "White",
                            Description = "Scelerisque pulvinar dapibus aptent sodales habitant erat dictum luctus mollis faucibus porttitor augue diam magna hendrerit volutpat quam venenatis velit",
                            Name = "Washing Machine",
                            Quantity = 10,
                            Weight = 100.09999999999999
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("KonusarakOgrenPreProject.Areas.Admin.Models.Comment", b =>
                {
                    b.HasOne("KonusarakOgrenPreProject.Areas.Admin.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("KonusarakOgrenPreProject.Areas.Admin.Models.Photo", b =>
                {
                    b.HasOne("KonusarakOgrenPreProject.Areas.Admin.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KonusarakOgrenPreProject.Areas.Admin.Models.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
