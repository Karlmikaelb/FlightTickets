namespace FlightTickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Airplane_Gate_Crew_Employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AirPlanes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightNumber = c.Int(nullable: false),
                        Crew_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Crews", t => t.Crew_Id)
                .Index(t => t.Crew_Id);
            
            CreateTable(
                "dbo.Crews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CrewRole = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                        Crew_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Crews", t => t.Crew_Id)
                .Index(t => t.Crew_Id);
            
            CreateTable(
                "dbo.Gates",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GateNumber = c.Int(nullable: false),
                        Crew_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AirPlanes", t => t.Id)
                .ForeignKey("dbo.Crews", t => t.Crew_Id)
                .Index(t => t.Id)
                .Index(t => t.Crew_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gates", "Crew_Id", "dbo.Crews");
            DropForeignKey("dbo.Gates", "Id", "dbo.AirPlanes");
            DropForeignKey("dbo.Employees", "Crew_Id", "dbo.Crews");
            DropForeignKey("dbo.AirPlanes", "Crew_Id", "dbo.Crews");
            DropIndex("dbo.Gates", new[] { "Crew_Id" });
            DropIndex("dbo.Gates", new[] { "Id" });
            DropIndex("dbo.Employees", new[] { "Crew_Id" });
            DropIndex("dbo.AirPlanes", new[] { "Crew_Id" });
            DropTable("dbo.Gates");
            DropTable("dbo.Employees");
            DropTable("dbo.Crews");
            DropTable("dbo.AirPlanes");
        }
    }
}
