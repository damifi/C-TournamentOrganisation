using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class PrizeClass
    {
        /// <summary>
        /// Placement of the prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name that comes along the prize.
        /// </summary>
        public string PlaceTitle { get; set; }
        /// <summary>
        /// Amount of money of the prize.
        /// </summary>
        public decimal PrizeMoney { get; set; }
        /// <summary>
        /// Percentage of the total prize money.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
