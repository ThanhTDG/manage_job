namespace DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initital : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChiTietCVs", "moTa", c => c.String());
            AddColumn("dbo.CongViecs", "MoTa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CongViecs", "MoTa");
            DropColumn("dbo.ChiTietCVs", "moTa");
        }
    }
}
