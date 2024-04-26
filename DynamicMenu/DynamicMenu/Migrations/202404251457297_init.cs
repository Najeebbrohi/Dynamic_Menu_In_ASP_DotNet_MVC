namespace DynamicMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuText = c.String(),
                        ParentId = c.Int(),
                        MenuUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MenuMasters");
        }
    }
}
