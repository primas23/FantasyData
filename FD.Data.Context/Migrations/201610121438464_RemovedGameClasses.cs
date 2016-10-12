namespace FD.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedGameClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DeadlineTime = c.DateTime(nullable: false),
                        AverageEntryScore = c.Int(nullable: false),
                        Finished = c.Boolean(nullable: false),
                        DataChecked = c.Boolean(nullable: false),
                        HighestScoringEntry = c.Int(),
                        DeadlineTimeEpoch = c.Int(nullable: false),
                        DeadlineTimeGameOffset = c.Int(nullable: false),
                        DeadlineTimeFormatted = c.String(),
                        HighestScore = c.Int(),
                        IsPrevious = c.Boolean(nullable: false),
                        IsCurrent = c.Boolean(nullable: false),
                        IsNext = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartEvent = c.Int(nullable: false),
                        StopEvent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        WebName = c.String(),
                        TeamCode = c.Int(nullable: false),
                        Status = c.String(),
                        Code = c.Int(nullable: false),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        SquadNumber = c.Int(),
                        News = c.String(),
                        NowCost = c.Int(nullable: false),
                        ChanceOfPlayingThisRound = c.Int(),
                        ChanceOfPlayingNextRound = c.Int(),
                        ValueForm = c.String(),
                        ValueSeason = c.String(),
                        CostChangeStart = c.Int(nullable: false),
                        CostChangeEvent = c.Int(nullable: false),
                        CostChangeStartFall = c.Int(nullable: false),
                        CostChangeEventFall = c.Int(nullable: false),
                        InDreamteam = c.Boolean(nullable: false),
                        DreamteamCount = c.Int(nullable: false),
                        SelectedByPercent = c.String(),
                        Form = c.String(),
                        TransfersOut = c.Int(nullable: false),
                        TransfersIn = c.Int(nullable: false),
                        TransfersOutEvent = c.Int(nullable: false),
                        TransfersInEvent = c.Int(nullable: false),
                        LoansIn = c.Int(nullable: false),
                        LoansOut = c.Int(nullable: false),
                        LoanedIn = c.Int(nullable: false),
                        LoanedOut = c.Int(nullable: false),
                        TotalPoints = c.Int(nullable: false),
                        EventPoints = c.Int(nullable: false),
                        PointsPerGame = c.String(),
                        EpThis = c.String(),
                        EpNext = c.String(),
                        Special = c.Boolean(nullable: false),
                        Minutes = c.Int(nullable: false),
                        GoalsScored = c.Int(nullable: false),
                        Assists = c.Int(nullable: false),
                        CleanSheets = c.Int(nullable: false),
                        GoalsConceded = c.Int(nullable: false),
                        OwnGoals = c.Int(nullable: false),
                        PenaltiesSaved = c.Int(nullable: false),
                        PenaltiesMissed = c.Int(nullable: false),
                        YellowCards = c.Int(nullable: false),
                        RedCards = c.Int(nullable: false),
                        Saves = c.Int(nullable: false),
                        Bonus = c.Int(nullable: false),
                        Bps = c.Int(nullable: false),
                        Influence = c.String(),
                        Creativity = c.String(),
                        Threat = c.String(),
                        IctIndex = c.String(),
                        EaIndex = c.Int(nullable: false),
                        ElementType = c.Int(nullable: false),
                        Team = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SingularName = c.String(),
                        SingularNameShort = c.String(),
                        PluralName = c.String(),
                        PluralNameShort = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        ShortName = c.String(),
                        Unavailable = c.Boolean(nullable: false),
                        Strength = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Played = c.Int(nullable: false),
                        Win = c.Int(nullable: false),
                        Loss = c.Int(nullable: false),
                        Draw = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        LinkUrl = c.String(),
                        StrengthOverallHome = c.Int(nullable: false),
                        StrengthOverallAway = c.Int(nullable: false),
                        StrengthAttackHome = c.Int(nullable: false),
                        StrengthAttackAway = c.Int(nullable: false),
                        StrengthDefenceHome = c.Int(nullable: false),
                        StrengthDefenceAway = c.Int(nullable: false),
                        TeamDivision = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CurrentEventFixtures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsHome = c.Boolean(nullable: false),
                        Day = c.Int(nullable: false),
                        EventDay = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Opponent = c.Int(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.NextEventFixtures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsHome = c.Boolean(nullable: false),
                        Day = c.Int(nullable: false),
                        EventDay = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Opponent = c.Int(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NextEventFixtures", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.CurrentEventFixtures", "Team_Id", "dbo.Teams");
            DropIndex("dbo.NextEventFixtures", new[] { "Team_Id" });
            DropIndex("dbo.CurrentEventFixtures", new[] { "Team_Id" });
            DropTable("dbo.NextEventFixtures");
            DropTable("dbo.CurrentEventFixtures");
            DropTable("dbo.Teams");
            DropTable("dbo.PlayerTypes");
            DropTable("dbo.Players");
            DropTable("dbo.Phases");
            DropTable("dbo.Events");
        }
    }
}
