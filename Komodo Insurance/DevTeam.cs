using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Komodo_Insurance
{
    //THIS IS THE POCO SETUP
    //POCO = PLAIN OLD C# OBJECTS
    //A PERSON WITH NO ATTRIBUTES LIKE A STICK FIGURE





    public enum TeamType
    {
        Pluralsight = 1,
        NonPluralsight,

    }
    [TestClass]
    public class DevTeam
    {
        public string TeamsMembers { get; set; }
        public string TeamNames { get; set; }
        public int TeamID { get; set; }
        public TeamType TypeOfTeam { get; set; }
        
        public DevTeam () { }

        public DevTeam(string teamsMembers, string teamNames, int teamID, TeamType team)
        {
            TeamsMembers = teamsMembers;
            TeamNames = teamNames;
            TeamID = teamID;
            TypeOfTeam = team;
        }
    }
}
