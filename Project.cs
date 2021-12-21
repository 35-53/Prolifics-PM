using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSecond
{
    class Project
    {
        public Project(string id, string name, string sdate, string edate)
        {
                Id = id;
                Name = name;
                Startdate = sdate;
                Enddate = edate;
        }


        public string Id {get; set;}
        public string Name {get; set;}
        public string Startdate {get; set;}
        public string Enddate{get; set;}
    }
}
