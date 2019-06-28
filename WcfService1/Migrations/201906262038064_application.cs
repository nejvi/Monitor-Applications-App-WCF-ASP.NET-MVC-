namespace WcfService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class application : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        monitorModel = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applications");
        }
    }
}
