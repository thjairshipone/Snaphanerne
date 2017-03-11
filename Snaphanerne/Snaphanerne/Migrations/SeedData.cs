using System;
namespace Snaphanerne.Migrations
{
    using System.Data.Entity.Migrations;
    using Models.Entity;
    using Models.StaticData;

    /// <summary>
    /// Data for the database to test it out with
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class SeedData
    {
        public void Seed(SnaphanerneContext context)
        {
            context.Tournaments.AddOrUpdate(
                tournament => tournament.Name,
                new Tournament {
                    Name = "Danish Liga"
                }
            );

            context.Matches.AddOrUpdate(
                match => match.Name,
                new Match {
                    Name = "Snaphanerne",
                    Opponent = "Kongeriet",
                    Start = new DateTime(2017, 03, 11, 21, 0, 0),
                    End = new DateTime(2017, 03, 12, 21, 0, 0),
                    Tournament = context.Tournaments.Find(1)
                }
            );

            context.Players.AddOrUpdate(
                player => player.ID,
                    new Player { Name = "Lord Ni", Match = context.Matches.Find(1), THLevel = Level.levels[4] }
                    
            );
 
            context.SaveChanges();
        }
    }
}