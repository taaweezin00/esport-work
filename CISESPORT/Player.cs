using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CISESPORT
{
    public class Player
    {
        public string Name { get; set; }
        public string Lname { get; set; }
        public string ID { get; set; }
        public string Field { get; set; }
        public string Gname { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }
        public Player(string name, string lname, string id, string field, string gname, string mail, string tel, int age)
        {
            Name = name;
            Lname = lname;
            ID = id;
            Field = field;
            Gname = gname;
            Mail = mail;
            Tel = tel;
            Age = age;
        }

    }
}
