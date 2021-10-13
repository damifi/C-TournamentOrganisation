using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class TournamentClass
    {
        /// <summary>
        /// Title of the tournament
        /// </summary>
        public string TournamentTitle { get; set; }
        /// <summary>
        /// Represents the cost to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List containing all the teams that are participating in the tournament.
        /// </summary>
        public List<TeamClass> ParticipatingTeams { get; set; } = new List<TeamClass>();
        /// <summary>
        /// List containing all the prizes of the tournament.
        /// </summary>
        public List<PrizeClass> Prizes { get; set; } = new List<PrizeClass>();
        /// <summary>
        /// List containing all the Rounds of the tournament.
        /// </summary>
        public List<List<MatchupClass>> Rounds { get; set; } = new List<List<MatchupClass>>();
    }
}
