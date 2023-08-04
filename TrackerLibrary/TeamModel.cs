using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// The list of persons in the team
        /// </summary>
        public List<Person> TeamMembers { get; set; } = new List<Person>();

        /// <summary>
        /// Represents the name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
