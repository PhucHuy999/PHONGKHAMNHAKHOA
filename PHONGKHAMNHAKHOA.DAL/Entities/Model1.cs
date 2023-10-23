using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CHUANDOAN_DIEUTRI> CHUANDOAN_DIEUTRI { get; set; }
        public virtual DbSet<DONTHUOC> DONTHUOC { get; set; }
        public virtual DbSet<LOAIDIEUTRI> LOAIDIEUTRI { get; set; }
        public virtual DbSet<LOAITHUOC> LOAITHUOC { get; set; }
        public virtual DbSet<NHAPXUAT_DCVLNK> NHAPXUAT_DCVLNK { get; set; }
        public virtual DbSet<tb_User> tb_User { get; set; }
        public virtual DbSet<THANHTOAN> THANHTOAN { get; set; }
        public virtual DbSet<THONGTINBENHNHAN> THONGTINBENHNHAN { get; set; }
        public virtual DbSet<THONGTINCANLAMSANG> THONGTINCANLAMSANG { get; set; }
        public virtual DbSet<THONGTINLAMSANG> THONGTINLAMSANG { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUANDOAN_DIEUTRI>()
                .Property(e => e.SOLUONG)
                .IsFixedLength();

            modelBuilder.Entity<CHUANDOAN_DIEUTRI>()
                .HasMany(e => e.THANHTOAN)
                .WithRequired(e => e.CHUANDOAN_DIEUTRI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONTHUOC>()
                .Property(e => e.SOLUONG)
                .IsFixedLength();

            modelBuilder.Entity<NHAPXUAT_DCVLNK>()
                .Property(e => e.SOLUONG)
                .IsFixedLength();

            modelBuilder.Entity<THONGTINBENHNHAN>()
                .Property(e => e.DIENTHOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONGTINBENHNHAN>()
                .HasMany(e => e.THANHTOAN)
                .WithRequired(e => e.THONGTINBENHNHAN)
                .WillCascadeOnDelete(false);
        }
    }
}
