namespace Snaphanerne.Repositories
{
    using Interfaces;
    using Models.Entity;

    /// <summary>
    /// This is the mirror of the database
    /// </summary>
    /// <author>Lord Ni</author>
    /// <seealso cref="Snaphanerne.Repositories.BaseRepository{Snaphanerne.Models.Entity.Match}" />
    public class MatchRepository : BaseRepository<Match>, IMatchRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public MatchRepository(SnaphanerneContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the snaphanerne context.
        /// </summary>
        /// <value>
        /// The snaphanerne context.
        /// </value>
        private SnaphanerneContext SnaphanerneContext
        {
            get
            {
                return (SnaphanerneContext)this.Context;
            }
        }

        /*
        public IEnumerable<Player> AddPlayersToTeam(IEnumerable<Player> players)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the players to team.
        /// </summary>
        /// <param name="players">The players.</param>
        /// <param name="matchId">The match identifier.</param>
        /// <returns></returns>
        public IEnumerable<Player> AddPlayersToTeam(IEnumerable<Player> players, int matchId)
        {
            Match match = this.Context.Set<Match>().Find(matchId);
            match.Team = players.ToList();
            this.Update(match);
            return players;
        }

        public Player RoosterPlayerAdd(string name, string thLvl, int matchId)
        {
            Player player = new Player { Name = name, THLevel = thLvl };
            Match match = this.Context.Set<Match>().Find(matchId);
            match.Team.Add(player);
            this.Update(match);
            return player;
        }

        public void RoosterPlayerDelete(int playerId, int matchId)
        {
            Player player = this.Context.Set<Player>().Find(playerId);
            Match match = this.Context.Set<Match>().Find(matchId);
            match.Rooster.Remove(player);
            this.Context.Entry(match).State = System.Data.Entity.EntityState.Modified;
        }

        public Player RoosterPlayerUpdate(int playerId, string name, string thLvl, int matchId)
        {
            Player player = this.Context.Set<Player>().Find(playerId);
            Match match = this.Context.Set<Match>().Find(matchId);
            
        }
        */
    }
}