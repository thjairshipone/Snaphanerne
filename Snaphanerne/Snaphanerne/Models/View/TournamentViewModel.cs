namespace Snaphanerne.Models.View
{
    using System.Collections.Generic;
    using Entity;
    
    public class TournamentViewModel
    {
        public Tournament Tournament { get; set; }

        public IEnumerable<Match> Matches { get; set; }

        public Match Match { get; set; }
    }
}