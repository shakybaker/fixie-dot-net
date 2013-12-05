namespace Fixie.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        ComplexityLevelTemplate_Id = c.Int(),
                        PriorityLevelTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ComplexityLevelTemplates", t => t.ComplexityLevelTemplate_Id)
                .ForeignKey("dbo.PriorityLevelTemplates", t => t.PriorityLevelTemplate_Id)
                .Index(t => t.ComplexityLevelTemplate_Id)
                .Index(t => t.PriorityLevelTemplate_Id);
            
            CreateTable(
                "dbo.ComplexityLevelTemplates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DisplayName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComplexityLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sequence = c.Int(nullable: false),
                        Name = c.String(),
                        ComplexityLevelTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ComplexityLevelTemplates", t => t.ComplexityLevelTemplate_Id)
                .Index(t => t.ComplexityLevelTemplate_Id);
            
            CreateTable(
                "dbo.Lanes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sequence = c.Int(nullable: false),
                        Name = c.String(),
                        Board_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Boards", t => t.Board_Id)
                .Index(t => t.Board_Id);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        Complexity_Id = c.Int(),
                        Priority_Id = c.Int(),
                        SprintGoal_Id = c.Int(),
                        Lane_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ComplexityLevels", t => t.Complexity_Id)
                .ForeignKey("dbo.PriorityLevels", t => t.Priority_Id)
                .ForeignKey("dbo.SprintGoals", t => t.SprintGoal_Id)
                .ForeignKey("dbo.Lanes", t => t.Lane_Id)
                .Index(t => t.Complexity_Id)
                .Index(t => t.Priority_Id)
                .Index(t => t.SprintGoal_Id)
                .Index(t => t.Lane_Id);
            
            CreateTable(
                "dbo.Blockers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Card_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.Card_Id)
                .Index(t => t.Card_Id);
            
            CreateTable(
                "dbo.Bugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Card_Id = c.Int(),
                        Scenario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.Card_Id)
                .ForeignKey("dbo.Scenarios", t => t.Scenario_Id)
                .Index(t => t.Card_Id)
                .Index(t => t.Scenario_Id);
            
            CreateTable(
                "dbo.PriorityLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(),
                        CreatedBy = c.Int(nullable: false),
                        Modified = c.DateTime(),
                        ModifiedBy = c.Int(nullable: false),
                        Sequence = c.Int(nullable: false),
                        Name = c.String(),
                        PriorityLevelTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PriorityLevelTemplates", t => t.PriorityLevelTemplate_Id)
                .Index(t => t.PriorityLevelTemplate_Id);
            
            CreateTable(
                "dbo.Scenarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Card_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.Card_Id)
                .Index(t => t.Card_Id);
            
            CreateTable(
                "dbo.SprintGoals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GoalMet = c.Boolean(nullable: false),
                        WhyNotMet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Card_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.Card_Id)
                .Index(t => t.Card_Id);
            
            CreateTable(
                "dbo.UserLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LinkType = c.Int(nullable: false),
                        User_Id = c.Int(),
                        Card_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Cards", t => t.Card_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Card_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PriorityLevelTemplates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DisplayName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Boards", "PriorityLevelTemplate_Id", "dbo.PriorityLevelTemplates");
            DropForeignKey("dbo.PriorityLevels", "PriorityLevelTemplate_Id", "dbo.PriorityLevelTemplates");
            DropForeignKey("dbo.Lanes", "Board_Id", "dbo.Boards");
            DropForeignKey("dbo.Cards", "Lane_Id", "dbo.Lanes");
            DropForeignKey("dbo.UserLinks", "Card_Id", "dbo.Cards");
            DropForeignKey("dbo.UserLinks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Tasks", "Card_Id", "dbo.Cards");
            DropForeignKey("dbo.Cards", "SprintGoal_Id", "dbo.SprintGoals");
            DropForeignKey("dbo.Scenarios", "Card_Id", "dbo.Cards");
            DropForeignKey("dbo.Bugs", "Scenario_Id", "dbo.Scenarios");
            DropForeignKey("dbo.Cards", "Priority_Id", "dbo.PriorityLevels");
            DropForeignKey("dbo.Cards", "Complexity_Id", "dbo.ComplexityLevels");
            DropForeignKey("dbo.Bugs", "Card_Id", "dbo.Cards");
            DropForeignKey("dbo.Blockers", "Card_Id", "dbo.Cards");
            DropForeignKey("dbo.Boards", "ComplexityLevelTemplate_Id", "dbo.ComplexityLevelTemplates");
            DropForeignKey("dbo.ComplexityLevels", "ComplexityLevelTemplate_Id", "dbo.ComplexityLevelTemplates");
            DropIndex("dbo.Boards", new[] { "PriorityLevelTemplate_Id" });
            DropIndex("dbo.PriorityLevels", new[] { "PriorityLevelTemplate_Id" });
            DropIndex("dbo.Lanes", new[] { "Board_Id" });
            DropIndex("dbo.Cards", new[] { "Lane_Id" });
            DropIndex("dbo.UserLinks", new[] { "Card_Id" });
            DropIndex("dbo.UserLinks", new[] { "User_Id" });
            DropIndex("dbo.Tasks", new[] { "Card_Id" });
            DropIndex("dbo.Cards", new[] { "SprintGoal_Id" });
            DropIndex("dbo.Scenarios", new[] { "Card_Id" });
            DropIndex("dbo.Bugs", new[] { "Scenario_Id" });
            DropIndex("dbo.Cards", new[] { "Priority_Id" });
            DropIndex("dbo.Cards", new[] { "Complexity_Id" });
            DropIndex("dbo.Bugs", new[] { "Card_Id" });
            DropIndex("dbo.Blockers", new[] { "Card_Id" });
            DropIndex("dbo.Boards", new[] { "ComplexityLevelTemplate_Id" });
            DropIndex("dbo.ComplexityLevels", new[] { "ComplexityLevelTemplate_Id" });
            DropTable("dbo.PriorityLevelTemplates");
            DropTable("dbo.Users");
            DropTable("dbo.UserLinks");
            DropTable("dbo.Tasks");
            DropTable("dbo.SprintGoals");
            DropTable("dbo.Scenarios");
            DropTable("dbo.PriorityLevels");
            DropTable("dbo.Bugs");
            DropTable("dbo.Blockers");
            DropTable("dbo.Cards");
            DropTable("dbo.Lanes");
            DropTable("dbo.ComplexityLevels");
            DropTable("dbo.ComplexityLevelTemplates");
            DropTable("dbo.Boards");
        }
    }
}
