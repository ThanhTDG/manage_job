using DAO.Modules;
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
        public DbSet<DieuKien> dieuKien { get; set; }
        public DbSet<GhiChuNhanh> ghiChuNhanh { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ChuDe>();
            modelBuilder.Entity<NguoiDung>();
            modelBuilder.Entity<CongViec>();
            //.HasRequired(x => n)
            //.WithMany()
            //.HasForeignKey(x => new { x.IDChuDe, x.Email })
            //.WillCascadeOnDelete(true);
            /*  modelBuilder.Entity<CongViec>()
                 .HasRequired(x => x.nguoiDung)
                 .WithMany()
                 .HasForeignKey(x => x.Email)
                 .WillCascadeOnDelete(true);*/
            modelBuilder.Entity<ChiTietCV>();
            //.HasRequired(x => new { x.congViec, x.chiTietCV })
            //.WithMany()
            //.HasForeignKey(x => new { x.iDCongviec, x.iDChiTietCV })
            //.WillCascadeOnDelete(true);
            /*     modelBuilder.Entity<ChiTietCV>()
                   .HasRequired(x => x.chiTietCV)
                   .WithMany()
                   .HasForeignKey(x => x.iDChiTietCV)
                   .WillCascadeOnDelete(true);*/
            modelBuilder.Entity<DieuKien>();
            //    .HasRequired(x => x.CVCon)
            //     .WithMany()
            //    .HasForeignKey(x => x.iDCon)
            //    .WillCascadeOnDelete(true);
            modelBuilder.Entity<DieuKien>();
            //    .HasRequired(x => x.CVCha)
            //    .WithMany()
            //    .HasForeignKey(x => x.iDCha)
            //    .WillCascadeOnDelete(true);
            modelBuilder.Entity<GhiChuNhanh>();


        }


    }
}
