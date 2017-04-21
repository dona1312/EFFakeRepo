namespace FakeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FakeUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FakeUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FakeDate = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FakeUsers");
        }
    }
}
