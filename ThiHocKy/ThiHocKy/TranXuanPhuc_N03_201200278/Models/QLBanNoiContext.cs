using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class QLBanNoiContext : DbContext
    {
        public QLBanNoiContext(DbContextOptions<QLBanNoiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnhChiTietSp> AnhChiTietSps { get; set; } = null!;
        public virtual DbSet<ChiTietDh> ChiTietDhs { get; set; } = null!;
        public virtual DbSet<ChiTietSpban> ChiTietSpbans { get; set; } = null!;
        public virtual DbSet<DonHang> DonHangs { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<PhanLoai> PhanLoais { get; set; } = null!;
        public virtual DbSet<PhanLoaiPhu> PhanLoaiPhus { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SptheoMau> SptheoMaus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnhChiTietSp>(entity =>
            {
                entity.HasKey(e => e.MaAnh);

                entity.ToTable("AnhChiTietSP");

                entity.Property(e => e.MaAnh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaSptheoMau)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaSPTheoMau");

                entity.HasOne(d => d.MaSptheoMauNavigation)
                    .WithMany(p => p.AnhChiTietSps)
                    .HasForeignKey(d => d.MaSptheoMau)
                    .HasConstraintName("FK_AnhChiTietSP_SPtheoMau1");
            });

            modelBuilder.Entity<ChiTietDh>(entity =>
            {
                entity.HasKey(e => new { e.MaDonHang, e.MaChiTietSp });

                entity.ToTable("ChiTietDH");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaChiTietSp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaChiTietSP");

                entity.HasOne(d => d.MaChiTietSpNavigation)
                    .WithMany(p => p.ChiTietDhs)
                    .HasForeignKey(d => d.MaChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDH_ChiTietSPBan");

                entity.HasOne(d => d.MaDonHangNavigation)
                    .WithMany(p => p.ChiTietDhs)
                    .HasForeignKey(d => d.MaDonHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDH_DonHang");
            });

            modelBuilder.Entity<ChiTietSpban>(entity =>
            {
                entity.HasKey(e => e.MaChiTietSp);

                entity.ToTable("ChiTietSPBan");

                entity.Property(e => e.MaChiTietSp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaChiTietSP");

                entity.Property(e => e.KichCo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaSptheoMau)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaSPTheoMau");

                entity.HasOne(d => d.MaSptheoMauNavigation)
                    .WithMany(p => p.ChiTietSpbans)
                    .HasForeignKey(d => d.MaSptheoMau)
                    .HasConstraintName("FK_ChiTietSPBan_SPtheoMau");
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.MaDonHang)
                    .HasName("pk_donhang");

                entity.ToTable("DonHang");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiGiaoHang).HasMaxLength(100);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.MaNguoiDung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayDatHang).HasColumnType("date");

                entity.Property(e => e.PtthanhToan)
                    .HasMaxLength(50)
                    .HasColumnName("PTThanhToan");

                entity.Property(e => e.SoDienThoaiNhanHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenNguoiNhanHang).HasMaxLength(50);

                entity.Property(e => e.TinhTrang).HasMaxLength(50);

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaNguoiDung)
                    .HasConstraintName("FK_DonHang_NguoiDung");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasKey(e => e.MaMau)
                    .HasName("pkmausac");

                entity.ToTable("MauSac");

                entity.Property(e => e.MaMau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenMau).HasMaxLength(20);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.MaNguoiDung)
                    .HasName("pknguoidung");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.MaNguoiDung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TenNguoiDung).HasMaxLength(30);
            });

            modelBuilder.Entity<PhanLoai>(entity =>
            {
                entity.HasKey(e => e.MaPhanLoai)
                    .HasName("pk_phanloai");

                entity.ToTable("PhanLoai");

                entity.Property(e => e.MaPhanLoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhanLoaiChinh).HasMaxLength(50);
            });

            modelBuilder.Entity<PhanLoaiPhu>(entity =>
            {
                entity.HasKey(e => e.MaPhanLoaiPhu)
                    .HasName("pk_phanloaiphu");

                entity.ToTable("PhanLoaiPhu");

                entity.Property(e => e.MaPhanLoaiPhu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhanLoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenPhanLoaiPhu).HasMaxLength(50);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("pk_sanpham");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhanLoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhanLoaiPhu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenSanPham).HasMaxLength(50);

                entity.HasOne(d => d.MaPhanLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaPhanLoai)
                    .HasConstraintName("FK_SanPham_PhanLoai");

                entity.HasOne(d => d.MaPhanLoaiPhuNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaPhanLoaiPhu)
                    .HasConstraintName("FK_SanPham_PhanLoaiPhu");
            });

            modelBuilder.Entity<SptheoMau>(entity =>
            {
                entity.HasKey(e => e.MaSptheoMau)
                    .HasName("pkphanloaimssp");

                entity.ToTable("SPtheoMau");

                entity.Property(e => e.MaSptheoMau)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaSPTheoMau");

                entity.Property(e => e.MaMau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaMauNavigation)
                    .WithMany(p => p.SptheoMaus)
                    .HasForeignKey(d => d.MaMau)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPtheoMau_MauSac");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.SptheoMaus)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPtheoMau_SanPham");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
