namespace BAIDA2021.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baidaa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carton_type",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Spec_Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Specifications",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        naemcarton = c.String(nullable: false),
                        website = c.String(),
                        Note = c.String(),
                        pdfd = c.String(),
                        wakilmahalt = c.String(),
                        wakelalami = c.String(),
                        refec = c.String(),
                        contry = c.String(),
                        numpermwasafh = c.String(),
                        Email = c.String(),
                        phone_Supplier = c.String(),
                        company_name = c.String(),
                        numgemshet = c.String(),
                        idtypcoton = c.Int(nullable: false),
                        Carton_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Carton_type", t => t.Carton_type_id)
                .Index(t => t.Carton_type_id);
            
            CreateTable(
                "dbo.Measurements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        grammage = c.String(),
                        Thickness = c.String(),
                        Top_Bright = c.String(),
                        idSpec = c.Int(nullable: false),
                        Specification_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Specifications", t => t.Specification_id)
                .Index(t => t.Specification_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Measurements", "Specification_id", "dbo.Specifications");
            DropForeignKey("dbo.Specifications", "Carton_type_id", "dbo.Carton_type");
            DropIndex("dbo.Measurements", new[] { "Specification_id" });
            DropIndex("dbo.Specifications", new[] { "Carton_type_id" });
            DropTable("dbo.Measurements");
            DropTable("dbo.Specifications");
            DropTable("dbo.Carton_type");
        }
    }
}
