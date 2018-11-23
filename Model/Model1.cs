namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QLCuocDT")
        {
        }

        public virtual DbSet<CuocGoi> CuocGoi { get; set; }
        public virtual DbSet<HoaDonDK> HoaDonDK { get; set; }
        public virtual DbSet<HoaDonThanhToan> HoaDonThanhToan { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<Sim> Sim { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<LoaiCuoc> LoaiCuoc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDonDK>()
                .Property(e => e.ChiPhi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDonThanhToan>()
                .Property(e => e.CuocThueBao)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDonThanhToan>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDonDK)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDonThanhToan)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sim>()
                .HasMany(e => e.CuocGoi)
                .WithRequired(e => e.Sim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sim>()
                .HasMany(e => e.HoaDonDK)
                .WithRequired(e => e.Sim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sim>()
                .HasMany(e => e.HoaDonThanhToan)
                .WithRequired(e => e.Sim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiCuoc>()
                .Property(e => e.GiaCuoc)
                .HasPrecision(18, 0);
        }
    }
}
