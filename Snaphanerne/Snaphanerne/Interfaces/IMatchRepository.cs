namespace Snaphanerne.Interfaces
{
    using System.Collections.Generic;
    using Models.Entity;

    /// <summary>
    /// The interface of the match repository
    /// </summary>
    public interface IMatchRepository: IBaseRepository<Match>
    {
        /*
        /// <summary>
        /// Adds the range.
        /// </summary>
        /// <param name="matches">The matches.</param>
        /// <returns></returns>
        IEnumerable<Player> AddPlayersToTeam(IEnumerable<Player> players);

        /// <summary>
        /// Adds the player to rooster.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="thlvl">The THLVL.</param>
        /// <returns></returns>
        Player RoosterPlayerAdd(string name, string thLvl);

        /// <summary>
        /// Roosters the player update.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="thLvl">The th level.</param>
        /// <returns></returns>
        Player RoosterPlayerUpdate(string name, string thLvl);

        /// <summary>
        /// Roosters the player delete.
        /// </summary>
        /// <param name="name">The name.</param>
        void RoosterPlayerDelete(string name);
        */
    }
}
