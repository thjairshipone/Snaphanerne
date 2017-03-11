namespace Snaphanerne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Opponent = c.String(unicode: false),
                        Prepare = c.Boolean(nullable: false),
                        OtherInformation = c.String(unicode: false),
                        Start = c.DateTime(nullable: false, precision: 0),
                        End = c.DateTime(nullable: false, precision: 0),
                        Tournament_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_ID)
                .Index(t => t.Tournament_ID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        THLevel = c.String(unicode: false),
                        Match_ID = c.Int(),
                        Match_ID1 = c.Int(),
                        Match_ID2 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Matches", t => t.Match_ID)
                .ForeignKey("dbo.Matches", t => t.Match_ID1)
                .ForeignKey("dbo.Matches", t => t.Match_ID2)
                .Index(t => t.Match_ID)
                .Index(t => t.Match_ID1)
                .Index(t => t.Match_ID2);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Tournament_ID", "dbo.Tournaments");
            DropForeignKey("dbo.Players", "Match_ID2", "dbo.Matches");
            DropForeignKey("dbo.Players", "Match_ID1", "dbo.Matches");
            DropForeignKey("dbo.Players", "Match_ID", "dbo.Matches");
            DropIndex("dbo.Players", new[] { "Match_ID2" });
            DropIndex("dbo.Players", new[] { "Match_ID1" });
            DropIndex("dbo.Players", new[] { "Match_ID" });
            DropIndex("dbo.Matches", new[] { "Tournament_ID" });
            DropTable("dbo.Tournaments");
            DropTable("dbo.Players");
            DropTable("dbo.Matches");
        }
    }
}
