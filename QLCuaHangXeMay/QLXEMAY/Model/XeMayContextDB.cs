using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLXEMAY.Model
{
    public partial class XeMayContextDB : DbContext
    {
        public XeMayContextDB()
            : base("name=XeMayContextDB")
        {
        }

        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIXE> LOAIXEs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<XEMAY> XEMAYs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.MAXE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.SOLUONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.DONGIA)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIXE>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIXE>()
                .HasMany(e => e.XEMAYs)
                .WithRequired(e => e.LOAIXE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MANCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.XEMAYs)
                .WithRequired(e => e.NHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.USERNAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XEMAY>()
                .Property(e => e.MAXE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XEMAY>()
                .Property(e => e.GIABAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<XEMAY>()
                .Property(e => e.DUNGTICH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XEMAY>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XEMAY>()
                .Property(e => e.MANCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XEMAY>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.XEMAY)
                .WillCascadeOnDelete(false);
        }
    }
}
