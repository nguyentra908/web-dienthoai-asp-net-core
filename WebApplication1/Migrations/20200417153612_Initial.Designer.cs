﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace DOAN.Migrations
{
    [DbContext(typeof(WEBContext))]
    [Migration("20200417153612_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Anh", b =>
                {
                    b.Property<int>("Masp")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MASP")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LINK")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Masp", "Link")
                        .HasName("PK__anh__962847F55648893B");

                    b.ToTable("anh");
                });

            modelBuilder.Entity("WebApplication1.Models.Chitiethoadon", b =>
                {
                    b.Property<int>("Mahd")
                        .HasColumnName("MAHD")
                        .HasColumnType("int");

                    b.Property<int>("Masp")
                        .HasColumnName("MASP")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("Gia")
                        .HasColumnName("GIA")
                        .HasColumnType("int");

                    b.Property<int?>("Soluong")
                        .HasColumnName("SOLUONG")
                        .HasColumnType("int");

                    b.Property<int?>("Thanhtien")
                        .HasColumnName("THANHTIEN")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Mahd", "Masp")
                        .HasName("PK__chitieth__563D086DC4FCABF1");

                    b.HasIndex("Masp");

                    b.ToTable("chitiethoadon");
                });

            modelBuilder.Entity("WebApplication1.Models.Hang", b =>
                {
                    b.Property<int>("Mahang")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MAHANG")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tenhang")
                        .IsRequired()
                        .HasColumnName("TENHANG")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Mahang")
                        .HasName("PK__hang__279EA4C28D1DC286");

                    b.ToTable("hang");
                });

            modelBuilder.Entity("WebApplication1.Models.Hoadon", b =>
                {
                    b.Property<int>("Mahd")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MAHD")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Ghichu")
                        .HasColumnName("GHICHU")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("Idkh")
                        .HasColumnName("IDKH")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngayhd")
                        .HasColumnName("NGAYHD")
                        .HasColumnType("date");

                    b.Property<string>("Tinhtrang")
                        .IsRequired()
                        .HasColumnName("TINHTRANG")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("Tongtien")
                        .HasColumnName("TONGTIEN")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Mahd")
                        .HasName("PK__hoadon__603F20CEC9E5564B");

                    b.HasIndex("Idkh");

                    b.ToTable("hoadon");
                });

            modelBuilder.Entity("WebApplication1.Models.Khachhang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Diachi")
                        .HasColumnName("DIACHI")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("EMAIL")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Ghichu")
                        .HasColumnName("GHICHU")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Sdt")
                        .HasColumnName("SDT")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Ten")
                        .HasColumnName("TEN")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Id");

                    b.ToTable("khachhang");
                });

            modelBuilder.Entity("WebApplication1.Models.Magiamgia", b =>
                {
                    b.Property<int>("Magiamgia1")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MAGIAMGIA")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Masp")
                        .HasColumnName("MASP")
                        .HasColumnType("int");

                    b.Property<int>("Phantram")
                        .HasColumnName("PHANTRAM")
                        .HasColumnType("int");

                    b.HasKey("Magiamgia1")
                        .HasName("PK__magiamgi__41C28439899B4FBD");

                    b.HasIndex("Masp");

                    b.ToTable("magiamgia");
                });

            modelBuilder.Entity("WebApplication1.Models.Sanpham", b =>
                {
                    b.Property<int>("Masp")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MASP")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anhdaidien")
                        .HasColumnName("ANHDAIDIEN")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Bonhotrong")
                        .HasColumnName("BONHOTRONG")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Camerasau")
                        .HasColumnName("CAMERASAU")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Cameratruoc")
                        .HasColumnName("CAMERATRUOC")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Cpu")
                        .HasColumnName("CPU")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int?>("Gia")
                        .HasColumnName("GIA")
                        .HasColumnType("int");

                    b.Property<int?>("Giakhuyenmai")
                        .HasColumnName("GIAKHUYENMAI")
                        .HasColumnType("int");

                    b.Property<string>("Gpu")
                        .HasColumnName("GPU")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("Hang")
                        .HasColumnName("HANG")
                        .HasColumnType("int");

                    b.Property<string>("Manhinh")
                        .HasColumnName("MANHINH")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Mota")
                        .HasColumnName("MOTA")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Namsx")
                        .HasColumnName("NAMSX")
                        .HasColumnType("date");

                    b.Property<string>("Os")
                        .HasColumnName("OS")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Pin")
                        .HasColumnName("PIN")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Ram")
                        .HasColumnName("RAM")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Sim")
                        .HasColumnName("SIM")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Tensp")
                        .IsRequired()
                        .HasColumnName("TENSP")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Masp")
                        .HasName("PK__sanpham__60228A32352A54EA");

                    b.HasIndex("Hang");

                    b.ToTable("sanpham");
                });

            modelBuilder.Entity("WebApplication1.Models.Taikhoan", b =>
                {
                    b.Property<string>("Tentk")
                        .HasColumnName("TENTK")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnName("PASS")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Quyen")
                        .IsRequired()
                        .HasColumnName("QUYEN")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("Tentk")
                        .HasName("PK__taikhoan__A58DF1B94EBA7F4C");

                    b.ToTable("taikhoan");
                });

            modelBuilder.Entity("WebApplication1.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);


                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Diachi")
                        .HasColumnName("DIACHI")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .HasColumnName("FULL_NAME")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("RememberToken")
                        .HasColumnName("remember_token")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ROLE")
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("('khach')")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Sdt")
                        .HasColumnName("SDT")
                        .HasColumnType("char(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Id")
                        .HasName("PK__users__3214EC277A7E84E6");

                    b.ToTable("users");
                });

            modelBuilder.Entity("WebApplication1.Models.Anh", b =>
                {
                    b.HasOne("WebApplication1.Models.Sanpham", "MaspNavigation")
                        .WithMany("Anh")
                        .HasForeignKey("Masp")
                        .HasConstraintName("FK_ANH_KH")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Chitiethoadon", b =>
                {
                    b.HasOne("WebApplication1.Models.Sanpham", "MaspNavigation")
                        .WithMany("Chitiethoadon")
                        .HasForeignKey("Masp")
                        .HasConstraintName("FK_CTHD_SP")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Hoadon", b =>
                {
                    b.HasOne("WebApplication1.Models.Khachhang", "IdkhNavigation")
                        .WithMany("Hoadon")
                        .HasForeignKey("Idkh")
                        .HasConstraintName("FK_HD_KH")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Magiamgia", b =>
                {
                    b.HasOne("WebApplication1.Models.Sanpham", "MaspNavigation")
                        .WithMany("Magiamgia")
                        .HasForeignKey("Masp")
                        .HasConstraintName("FK_GIAMGIA_SP")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Sanpham", b =>
                {
                    b.HasOne("WebApplication1.Models.Hang", "HangNavigation")
                        .WithMany("Sanpham")
                        .HasForeignKey("Hang")
                        .HasConstraintName("FK_SP_HANG")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
