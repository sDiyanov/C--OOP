using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class ExceptionMessages
    {
        public const string NameCannotBeEmpty =
            "A name should not be empty.";
        public const string StatsShouldBeInTheRange =
            "{0} should be between 0 and 100.";
        public const string RemoveMissingPlayer =
            "Player {0} is not in {1} team.";
        public const string MissingTeam =
            "Team {0} does not exist.";
    }
}
