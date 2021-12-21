using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSecond
{
    class Home
    {
        private List< Project> _projects{ get; set; } = new List< Project>();

        private void DispalyProjectDetails(Project project)
            {
               Console.WriteLine($"Project: {project.Id}, {project.Name}, {project.Startdate}, {project.Enddate}");   

            }

        private void  DispalyProjectDetails(List< Project> projects)
        {
                foreach (var project in projects)
                   {
                       DispalyProjectDetails(project);
                    }

        }



        public void AddProject(Project project)
            {
                _projects.Add(project);
            }

     

            public void DisplayAllProject()
            {
                DispalyProjectDetails(_projects);
            }


    }



}
