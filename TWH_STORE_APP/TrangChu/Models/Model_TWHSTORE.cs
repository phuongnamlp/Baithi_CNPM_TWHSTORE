using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TrangChu.Models
{
    public partial class Model_TWHSTORE : DbContext
    {
        public Model_TWHSTORE()
            : base("name=Model_TWHSTORE8")
        {
        }

        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<DANHSACH_NVL> DANHSACH_NVL { get; set; }
        public virtual DbSet<DANHSACHCANNHAP_NVL> DANHSACHCANNHAP_NVL { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<PHIDICHVU> PHIDICHVUs { get; set; }
        public virtual DbSet<PHIPHATSINH> PHIPHATSINHs { get; set; }
        public virtual DbSet<QUYEN> QUYENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THONGTIN_NHACUNGCAP> THONGTIN_NHACUNGCAP { get; set; }
        public virtual DbSet<THONGTIN_NHANVIEN> THONGTIN_NHANVIEN { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.MABANGLUONG)
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.TIENLUONG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.LUONGTHUONG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.TONGLUONG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DANHSACH_NVL>()
                .Property(e => e.MANVL)
                .IsUnicode(false);

            modelBuilder.Entity<DANHSACH_NVL>()
                .HasMany(e => e.DANHSACHCANNHAP_NVL)
                .WithRequired(e => e.DANHSACH_NVL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANHSACHCANNHAP_NVL>()
                .Property(e => e.MANVL)
                .IsUnicode(false);

            modelBuilder.Entity<DANHSACHCANNHAP_NVL>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.SOBAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIDICHVU>()
                .Property(e => e.MAPHIEUDV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIPHATSINH>()
                .Property(e => e.MAPHIEU)
                .IsUnicode(false);

            modelBuilder.Entity<QUYEN>()
                .Property(e => e.TENQUYEN)
                .IsUnicode(false);

            modelBuilder.Entity<QUYEN>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.QUYEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MAMON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONGTIN_NHACUNGCAP>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<THONGTIN_NHACUNGCAP>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<THONGTIN_NHACUNGCAP>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<THONGTIN_NHACUNGCAP>()
                .HasMany(e => e.DANHSACHCANNHAP_NVL)
                .WithRequired(e => e.THONGTIN_NHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THONGTIN_NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<THONGTIN_NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<THONGTIN_NHANVIEN>()
                .HasMany(e => e.BANGLUONGs)
                .WithRequired(e => e.THONGTIN_NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THONGTIN_NHANVIEN>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.THONGTIN_NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.TAIKHOAN)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.MANV)
                .IsUnicode(false);
        }
    }
}
