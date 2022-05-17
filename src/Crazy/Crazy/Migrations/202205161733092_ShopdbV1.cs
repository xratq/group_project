namespace Crazy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopdbV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.additional_characteristics",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        characteristic = c.String(),
                        meaning = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.audiences",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        number = c.Int(nullable: false),
                        frame = c.String(),
                        floor = c.Int(nullable: false),
                        audiencetype = c.String(),
                        audienceowner = c.String(),
                        square = c.Int(nullable: false),
                        number_of_seats = c.Int(nullable: false),
                        category = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.educational_buildings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        short_name = c.String(),
                        adress = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.equiment_lists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        inventory_number = c.Int(nullable: false),
                        serial_number = c.Int(nullable: false),
                        date_of_purchase = c.Int(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Int(nullable: false),
                        where_used = c.String(),
                        category = c.String(),
                        in_the_audience_is = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.software_lists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        manufacturer = c.String(),
                        license = c.Int(nullable: false),
                        date_of_purchase = c.Int(nullable: false),
                        license_expiration_date = c.Int(nullable: false),
                        in_which_classrooms = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.software_lists");
            DropTable("public.equiment_lists");
            DropTable("public.educational_buildings");
            DropTable("public.audiences");
            DropTable("public.additional_characteristics");
        }
    }
}
