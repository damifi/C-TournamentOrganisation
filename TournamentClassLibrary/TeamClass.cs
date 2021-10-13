using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class TeamClass
    {
        /// <summary>
        /// List containing all the teammembers of the team.
        /// </summary>
        public List<PersonClass> TeamMembers { get; set; } = new List<PersonClass>();
        /// <summary>
        /// Title of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
