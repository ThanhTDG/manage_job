using DAO.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class ManageJobContext : DbContext
    {
        public ManageJobContext() : base("JobManagement")
        {
            //  this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<ChuDe> chuDe { get; set; }
        public DbSet<NguoiDung> nguoiDung { get; set; }
        public DbSet<CongViec> congViec { get; set; }
        public DbSet<ChiTietCV> chiTietCV { get; set; }
        public DbSet<GhiChuNhanh> ghiChuNhanh { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuDe>();
            modelBuilder.Entity<NguoiDung>();
            modelBuilder.Entity<CongViec>();
            modelBuilder.Entity<ChiTietCV>();
            modelBuilder.Entity<GhiChuNhanh>();
        }
    }
}
