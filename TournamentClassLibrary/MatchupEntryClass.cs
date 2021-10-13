using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class MatchupEntryClass
    {
        /// <summary>
        /// Specifies the team in this matchup entry.
        /// </summary>
        public TeamClass TeamCompeting { get; set; }
        /// <summary>
        /// Specifies the score of a team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Contains the matchup before the current matchup
        /// </summary>
        public MatchupClass ParentMatchup { get; set; }
    }
}
