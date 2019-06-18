namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarImages",
                c => new
                    {
                        CarImageId = c.Int(nullable: false, identity: true),
                        Image = c.Binary(nullable: false, storeType: "image"),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarImageId)
                .ForeignKey("dbo.CarInformations", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.CarKmPasts",
                c => new
                    {
                        CarKmId = c.Int(nullable: false, identity: true),
                        KmInf = c.Int(),
                        UpdateDate = c.DateTime(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarKmId)
                .ForeignKey("dbo.CarInformations", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarImages", "CarId", "dbo.CarInformations");
            DropForeignKey("dbo.CarKmPasts", "CarId", "dbo.CarInformations");
            DropIndex("dbo.CarKmPasts", new[] { "CarId" });
            DropIndex("dbo.CarImages", new[] { "CarId" });
            DropTable("dbo.CarKmPasts");
            DropTable("dbo.CarImages");
        }
    }
}
