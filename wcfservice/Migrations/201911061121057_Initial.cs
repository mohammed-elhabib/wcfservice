namespace wcfservice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(unicode: false),
                        job = c.String(unicode: false),
                        Pay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FirstMidName = c.String(unicode: false),
                        BirthDayDate = c.DateTime(nullable: false, precision: 0),
                        Date_At = c.DateTime(nullable: false, precision: 0),
                        Date_Up = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Usename = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        FirstMidName = c.String(unicode: false),
                        BirthDayDate = c.DateTime(nullable: false, precision: 0),
                        Date_At = c.DateTime(nullable: false, precision: 0),
                        Date_Up = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Employees");
        }
    }
}
