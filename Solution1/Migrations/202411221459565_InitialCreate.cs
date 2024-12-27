namespace Solution1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NomClient = c.String(),
                        AdresseClient = c.String(),
                        TelClient = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.reservations",
                c => new
                    {
                        CodeReservation = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Pensioncomplete = c.String(),
                        IdClient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodeReservation)
                .ForeignKey("dbo.clients", t => t.IdClient, cascadeDelete: true)
                .Index(t => t.IdClient);
            
            CreateTable(
                "dbo.sejours",
                c => new
                    {
                        Numsejour = c.Int(nullable: false, identity: true),
                        DateSejour = c.DateTime(nullable: false),
                        TypeSejour = c.String(),
                        DureeSejour = c.String(),
                        CodeReservation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Numsejour)
                .ForeignKey("dbo.reservations", t => t.CodeReservation, cascadeDelete: true)
                .Index(t => t.CodeReservation);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sejours", "CodeReservation", "dbo.reservations");
            DropForeignKey("dbo.reservations", "IdClient", "dbo.clients");
            DropIndex("dbo.sejours", new[] { "CodeReservation" });
            DropIndex("dbo.reservations", new[] { "IdClient" });
            DropTable("dbo.sejours");
            DropTable("dbo.reservations");
            DropTable("dbo.clients");
        }
    }
}
