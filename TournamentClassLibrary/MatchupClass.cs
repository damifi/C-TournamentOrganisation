using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class MatchupClass
    {
        /// <summary>
        /// List of entries in a matchup.
        /// </summary>
        public List<MatchupEntryClass> Entries { get; set; } = new List<MatchupEntryClass>();
        /// <summary>
        /// Team that won the matchup.
        /// </summary>
        public TeamClass Winner { get; set; }
        /// <summary>
        /// Number of the matchup round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
