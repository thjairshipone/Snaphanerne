namespace Snaphanerne.Models.View
{
    using System.Collections.Generic;
    using Entity;
    using StaticData;

    public class MatchViewModel
    {
        public Match Match { get; set; }

        public IEnumerable<Tournament> Tournaments { get; set; }

        public Tournament Tournament { get; set; }

        public Player Player { get; set; }

        public IEnumerable<Player> Rooster { get; set; }

        public IEnumerable<Player> Team { get; set; }
    }
}