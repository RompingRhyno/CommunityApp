﻿// <auto-generated />
using System;
using CommunityApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommunityApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250124100344_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("CommunityApp.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Population")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.HasIndex("ProvinceCode");

                    b.ToTable("Cities", (string)null);

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Calgary",
                            Population = 1336000,
                            ProvinceCode = "AB"
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Edmonton",
                            Population = 981000,
                            ProvinceCode = "AB"
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "Red Deer",
                            Population = 100418,
                            ProvinceCode = "AB"
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Vancouver",
                            Population = 2463431,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Surrey",
                            Population = 517887,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Burnaby",
                            Population = 232755,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 7,
                            CityName = "Richmond",
                            Population = 198309,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 8,
                            CityName = "Winnipeg",
                            Population = 749534,
                            ProvinceCode = "MB"
                        },
                        new
                        {
                            CityId = 9,
                            CityName = "Brandon",
                            Population = 48859,
                            ProvinceCode = "MB"
                        },
                        new
                        {
                            CityId = 10,
                            CityName = "Thompson",
                            Population = 13008,
                            ProvinceCode = "MB"
                        },
                        new
                        {
                            CityId = 11,
                            CityName = "Saint John",
                            Population = 67575,
                            ProvinceCode = "NB"
                        },
                        new
                        {
                            CityId = 12,
                            CityName = "Moncton",
                            Population = 144810,
                            ProvinceCode = "NB"
                        },
                        new
                        {
                            CityId = 13,
                            CityName = "Fredericton",
                            Population = 58206,
                            ProvinceCode = "NB"
                        },
                        new
                        {
                            CityId = 14,
                            CityName = "Labrador City",
                            Population = 9445,
                            ProvinceCode = "NL"
                        },
                        new
                        {
                            CityId = 15,
                            CityName = "St. John's",
                            Population = 108860,
                            ProvinceCode = "NL"
                        },
                        new
                        {
                            CityId = 16,
                            CityName = "Corner Brook",
                            Population = 19504,
                            ProvinceCode = "NL"
                        },
                        new
                        {
                            CityId = 17,
                            CityName = "Halifax",
                            Population = 403131,
                            ProvinceCode = "NS"
                        },
                        new
                        {
                            CityId = 18,
                            CityName = "Sydney",
                            Population = 31686,
                            ProvinceCode = "NS"
                        },
                        new
                        {
                            CityId = 19,
                            CityName = "Truro",
                            Population = 12349,
                            ProvinceCode = "NS"
                        },
                        new
                        {
                            CityId = 20,
                            CityName = "Toronto",
                            Population = 2731571,
                            ProvinceCode = "ON"
                        },
                        new
                        {
                            CityId = 21,
                            CityName = "Ottawa",
                            Population = 934243,
                            ProvinceCode = "ON"
                        },
                        new
                        {
                            CityId = 22,
                            CityName = "Mississauga",
                            Population = 721599,
                            ProvinceCode = "ON"
                        },
                        new
                        {
                            CityId = 23,
                            CityName = "Charlettetown",
                            Population = 36847,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityId = 24,
                            CityName = "Souris",
                            Population = 1279,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityId = 25,
                            CityName = "Summerside",
                            Population = 14857,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityId = 26,
                            CityName = "Quebec City",
                            Population = 531902,
                            ProvinceCode = "QC"
                        },
                        new
                        {
                            CityId = 27,
                            CityName = "Montreal",
                            Population = 1704694,
                            ProvinceCode = "QC"
                        },
                        new
                        {
                            CityId = 28,
                            CityName = "Laval",
                            Population = 422993,
                            ProvinceCode = "QC"
                        },
                        new
                        {
                            CityId = 29,
                            CityName = "Saskatoon",
                            Population = 246376,
                            ProvinceCode = "SK"
                        },
                        new
                        {
                            CityId = 30,
                            CityName = "Regina",
                            Population = 215106,
                            ProvinceCode = "SK"
                        },
                        new
                        {
                            CityId = 31,
                            CityName = "Moose Jaw",
                            Population = 33877,
                            ProvinceCode = "SK"
                        },
                        new
                        {
                            CityId = 32,
                            CityName = "Yellowknife",
                            Population = 19569,
                            ProvinceCode = "NT"
                        },
                        new
                        {
                            CityId = 33,
                            CityName = "Inuvik",
                            Population = 3495,
                            ProvinceCode = "NT"
                        },
                        new
                        {
                            CityId = 34,
                            CityName = "Hay River",
                            Population = 3461,
                            ProvinceCode = "NT"
                        },
                        new
                        {
                            CityId = 35,
                            CityName = "Iqaluit",
                            Population = 6695,
                            ProvinceCode = "NU"
                        },
                        new
                        {
                            CityId = 36,
                            CityName = "Baker Lake",
                            Population = 2058,
                            ProvinceCode = "NU"
                        },
                        new
                        {
                            CityId = 37,
                            CityName = "Rankin Inlet",
                            Population = 2825,
                            ProvinceCode = "NU"
                        },
                        new
                        {
                            CityId = 38,
                            CityName = "Whitehorse",
                            Population = 25085,
                            ProvinceCode = "YT"
                        },
                        new
                        {
                            CityId = 39,
                            CityName = "Dawson City",
                            Population = 1319,
                            ProvinceCode = "YT"
                        },
                        new
                        {
                            CityId = 40,
                            CityName = "Watson Lake",
                            Population = 790,
                            ProvinceCode = "YT"
                        });
                });

            modelBuilder.Entity("CommunityApp.Models.Province", b =>
                {
                    b.Property<string>("ProvinceCode")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProvinceCode");

                    b.ToTable("Provinces", (string)null);

                    b.HasData(
                        new
                        {
                            ProvinceCode = "AB",
                            ProvinceName = "Alberta"
                        },
                        new
                        {
                            ProvinceCode = "BC",
                            ProvinceName = "British Columbia"
                        },
                        new
                        {
                            ProvinceCode = "MB",
                            ProvinceName = "Manitoba"
                        },
                        new
                        {
                            ProvinceCode = "NB",
                            ProvinceName = "New Brunswick"
                        },
                        new
                        {
                            ProvinceCode = "NL",
                            ProvinceName = "Newfoundland and Labrador"
                        },
                        new
                        {
                            ProvinceCode = "NS",
                            ProvinceName = "Nova Scotia"
                        },
                        new
                        {
                            ProvinceCode = "ON",
                            ProvinceName = "Ontario"
                        },
                        new
                        {
                            ProvinceCode = "PE",
                            ProvinceName = "Prince Edward Island"
                        },
                        new
                        {
                            ProvinceCode = "QC",
                            ProvinceName = "Quebec"
                        },
                        new
                        {
                            ProvinceCode = "SK",
                            ProvinceName = "Saskatchewan"
                        },
                        new
                        {
                            ProvinceCode = "NT",
                            ProvinceName = "Northwest Territories"
                        },
                        new
                        {
                            ProvinceCode = "NU",
                            ProvinceName = "Nunavut"
                        },
                        new
                        {
                            ProvinceCode = "YT",
                            ProvinceName = "Yukon"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CommunityApp.Models.City", b =>
                {
                    b.HasOne("CommunityApp.Models.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceCode");

                    b.Navigation("Province");
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

            modelBuilder.Entity("CommunityApp.Models.Province", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
