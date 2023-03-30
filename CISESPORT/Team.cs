using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    public class Team
    {
        public string _Team { get; set; }
        public string Name1 { get; set; }
        public string Gname1 { get; set; }
        public string Name2 { get; set; }
        public string Gname2 { get; set; }
        public string Name3 { get; set; }
        public string Gname3 { get; set; }
        public string Name4 { get; set; }
        public string Gname4 { get; set; }
        public string Name5 { get; set; }
        public string Gname5 { get; set; }

        public Team(string team, string name1, string gname1, string name2, string gname2, string name3, string gname3, string name4, string gname4, string name5, string gname5)
        {
            _Team = team;
            Name1 = name1;
            Gname1 = gname1;
            Name2 = name2;
            Gname2 = gname2;
            Name3 = name3;
            Gname3 = gname3;
            Name4 = name4;
            Gname4 = gname4;
            Name5 = name5;
            Gname5 = gname5;
        }
    }
}
