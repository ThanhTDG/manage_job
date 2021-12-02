namespace DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietCVs",
                c => new
                    {
                        iD = c.Int(nullable: false, identity: true),
                        iDCongviec = c.Int(nullable: false),
                        ten = c.String(),
                        trangThai = c.Int(nullable: false),
                        ThoiGianDukien = c.DateTime(nullable: false),
                        ThoiGianThucTe = c.DateTime(nullable: false),
                        mucDo = c.Int(nullable: false),
                        iDChiTietCV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.iD)
                .ForeignKey("dbo.ChiTietCVs", t => t.iDChiTietCV)
                .ForeignKey("dbo.CongViecs", t => t.iDCongviec, cascadeDelete: true)
                .Index(t => t.iDCongviec)
                .Index(t => t.iDChiTietCV);
            
            CreateTable(
                "dbo.CongViecs",
                c => new
                    {
                        iD = c.Int(nullable: false, identity: true),
                        ten = c.String(),
                        thoiGianBD = c.DateTime(nullable: false),
                        thoiGianKT = c.DateTime(nullable: false),
                        trangThai = c.String(),
                        tienDo = c.Int(nullable: false),
                        mucDo = c.Int(nullable: false),
                        IDChuDe = c.Int(nullable: false),
                        Email = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.iD)
                .ForeignKey("dbo.ChuDes", t => t.IDChuDe, cascadeDelete: true)
                .ForeignKey("dbo.NguoiDungs", t => t.Email)
                .Index(t => t.IDChuDe)
                .Index(t => t.Email);
            
            CreateTable(
                "dbo.ChuDes",
                c => new
                    {
                        iD = c.Int(nullable: false, identity: true),
                        ten = c.String(),
                    })
                .PrimaryKey(t => t.iD);
            
            CreateTable(
                "dbo.NguoiDungs",
                c => new
                    {
                        email = c.String(nullable: false, maxLength: 128),
                        banQuyen = c.String(),
                        tenND = c.String(),
                    })
                .PrimaryKey(t => t.email);
            
            CreateTable(
                "dbo.DieuKiens",
                c => new
                    {
                        iDCon = c.Int(nullable: false, identity: true),
                        iDCha = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.iDCon, t.iDCha });
            
            CreateTable(
                "dbo.GhiChuNhanhs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TieuDe = c.String(),
                        NoiDung = c.String(),
                        ThoiGianBD = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietCVs", "iDCongviec", "dbo.CongViecs");
            DropForeignKey("dbo.CongViecs", "Email", "dbo.NguoiDungs");
            DropForeignKey("dbo.CongViecs", "IDChuDe", "dbo.ChuDes");
            DropForeignKey("dbo.ChiTietCVs", "iDChiTietCV", "dbo.ChiTietCVs");
            DropIndex("dbo.CongViecs", new[] { "Email" });
            DropIndex("dbo.CongViecs", new[] { "IDChuDe" });
            DropIndex("dbo.ChiTietCVs", new[] { "iDChiTietCV" });
            DropIndex("dbo.ChiTietCVs", new[] { "iDCongviec" });
            DropTable("dbo.GhiChuNhanhs");
            DropTable("dbo.DieuKiens");
            DropTable("dbo.NguoiDungs");
            DropTable("dbo.ChuDes");
            DropTable("dbo.CongViecs");
            DropTable("dbo.ChiTietCVs");
        }
    }
}
