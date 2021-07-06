using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    class DevTeamRepo
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void MyTestMethod()
        {
            DevTeam team = new DevTeam();

            team.TeamNames = "Team One";

            string expected = "Team One";
            string actual = team.TeamNames;

            Assert.AreEqual(expected, actual);

        }
    }
}
