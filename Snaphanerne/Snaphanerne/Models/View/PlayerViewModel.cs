using Snaphanerne.Models.Entity;
using Snaphanerne.Models.StaticData;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Snaphanerne.Models.View
{
    public class PlayerViewModel
    {
        public Player Player { get; set; }

        public IEnumerable<Match> Matches { get; set; }

        public IEnumerable<string> THLevels { get; set; }
        
        public Calendar Calendar { get; set; }
    }
}