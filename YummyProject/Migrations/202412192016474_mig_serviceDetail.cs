namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_serviceDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceDetails",
                c => new
                    {
                        ServiceDetailId = c.Int(nullable: false, identity: true),
                        DetailTitle = c.String(),
                        DetailDescription = c.String(),
                        DetailIcon = c.String(),
                    })
                .PrimaryKey(t => t.ServiceDetailId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceDetails");
        }
    }
}
