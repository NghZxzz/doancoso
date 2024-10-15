﻿// <auto-generated />
using System;
using DoAnCoSo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoAnCoSo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240513083622_themluongthang2")]
    partial class themluongthang2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoAnCoSo.Models.ApplicationUser", b =>
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("MaNhanVien")
                        .HasColumnType("int");

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

                    b.HasIndex("MaNhanVien");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DoAnCoSo.Models.BangLuong", b =>
                {
                    b.Property<int>("LId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LId"));

                    b.Property<int>("LuongThoaThuan")
                        .HasColumnType("int");

                    b.Property<int?>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<DateOnly>("NgayQD")
                        .HasColumnType("date");

                    b.HasKey("LId");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("bangLuongs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.ChucVu", b =>
                {
                    b.Property<int>("MaChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChucVu"));

                    b.Property<string>("MoTa")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaChucVu");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("DoAnCoSo.Models.KhenThuong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KTId")
                        .HasColumnType("int");

                    b.Property<string>("LyDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<DateOnly>("NgayQD")
                        .HasColumnType("date");

                    b.Property<int>("SoTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KTId");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("KhenThuongs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.KyLuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KLId")
                        .HasColumnType("int");

                    b.Property<string>("LyDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<DateOnly>("NgayQD")
                        .HasColumnType("date");

                    b.Property<int>("SoTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KLId");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("KyLuats");
                });

            modelBuilder.Entity("DoAnCoSo.Models.LoaiKhenThuong", b =>
                {
                    b.Property<int>("KTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KTId"));

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KTId");

                    b.ToTable("LoaiKhenThuongs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.LoaiKyLuat", b =>
                {
                    b.Property<int>("KLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KLId"));

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KLId");

                    b.ToTable("LoaiKyLuats");
                });

            modelBuilder.Entity("DoAnCoSo.Models.LuongThang", b =>
                {
                    b.Property<int>("LTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LTId"));

                    b.Property<int?>("KhenThuong")
                        .HasColumnType("int");

                    b.Property<int?>("KyLuat")
                        .HasColumnType("int");

                    b.Property<int>("LId")
                        .HasColumnType("int");

                    b.Property<int>("LuongThoaThuan")
                        .HasColumnType("int");

                    b.Property<int?>("NgayNghiCoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("NgayNghiKhongLuong")
                        .HasColumnType("int");

                    b.Property<DateOnly>("NgayTL")
                        .HasColumnType("date");

                    b.Property<int?>("PhuCap")
                        .HasColumnType("int");

                    b.Property<int?>("ThucLanh")
                        .HasColumnType("int");

                    b.Property<int?>("UngTruoc")
                        .HasColumnType("int");

                    b.HasKey("LTId");

                    b.HasIndex("LId");

                    b.ToTable("luongThangs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.NghiPhep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LoaiNghi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LyDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<DateOnly>("NgayBatDau")
                        .HasColumnType("date");

                    b.Property<DateOnly>("NgayKetThuc")
                        .HasColumnType("date");

                    b.Property<DateOnly>("NgayTao")
                        .HasColumnType("date");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("NghiPheps");
                });

            modelBuilder.Entity("DoAnCoSo.Models.NhanVien", b =>
                {
                    b.Property<int>("MaNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNhanVien"));

                    b.Property<string>("CCCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaChucVu")
                        .HasColumnType("int");

                    b.Property<DateOnly>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("QueQuan")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaNhanVien");

                    b.HasIndex("MaChucVu");

                    b.ToTable("NhanViens");
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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("DoAnCoSo.Models.ApplicationUser", b =>
                {
                    b.HasOne("DoAnCoSo.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("MaNhanVien");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("DoAnCoSo.Models.BangLuong", b =>
                {
                    b.HasOne("DoAnCoSo.Models.NhanVien", "NhanViens")
                        .WithMany()
                        .HasForeignKey("MaNhanVien");

                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("DoAnCoSo.Models.KhenThuong", b =>
                {
                    b.HasOne("DoAnCoSo.Models.LoaiKhenThuong", "loaiKhenThuongs")
                        .WithMany("khenThuongs")
                        .HasForeignKey("KTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnCoSo.Models.NhanVien", "NhanViens")
                        .WithMany()
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanViens");

                    b.Navigation("loaiKhenThuongs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.KyLuat", b =>
                {
                    b.HasOne("DoAnCoSo.Models.LoaiKyLuat", "loaiKyLuats")
                        .WithMany("KyLuats")
                        .HasForeignKey("KLId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnCoSo.Models.NhanVien", "NhanViens")
                        .WithMany()
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanViens");

                    b.Navigation("loaiKyLuats");
                });

            modelBuilder.Entity("DoAnCoSo.Models.LuongThang", b =>
                {
                    b.HasOne("DoAnCoSo.Models.BangLuong", "bangLuongs")
                        .WithMany("luongThangs")
                        .HasForeignKey("LId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bangLuongs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.NghiPhep", b =>
                {
                    b.HasOne("DoAnCoSo.Models.NhanVien", "NhanViens")
                        .WithMany()
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("DoAnCoSo.Models.NhanVien", b =>
                {
                    b.HasOne("DoAnCoSo.Models.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("MaChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
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
                    b.HasOne("DoAnCoSo.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DoAnCoSo.Models.ApplicationUser", null)
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

                    b.HasOne("DoAnCoSo.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DoAnCoSo.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoAnCoSo.Models.BangLuong", b =>
                {
                    b.Navigation("luongThangs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("DoAnCoSo.Models.LoaiKhenThuong", b =>
                {
                    b.Navigation("khenThuongs");
                });

            modelBuilder.Entity("DoAnCoSo.Models.LoaiKyLuat", b =>
                {
                    b.Navigation("KyLuats");
                });
#pragma warning restore 612, 618
        }
    }
}
