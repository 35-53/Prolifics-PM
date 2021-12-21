using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSecond
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello from the Prolifics Project Manager portal:");
                Console.WriteLine("Select Operation");
                Console.WriteLine(" 1.Add Project");
                Console.WriteLine(" 2.View all Projects");
                Console.WriteLine("4.Quit");
                var userInput = Convert.ToInt32(Console.ReadLine());
                
                var home= new Home();
                while (true)
                {
                 switch (userInput)
                {
                    case 1:
                            Console.WriteLine("Project Id:");
                            var id = Console.ReadLine();
                            Console.WriteLine("Project Name");
                            var name=Console.ReadLine();
                            Console.WriteLine("Project Startdate:");
                            var sdate = Console.ReadLine();
                            Console.WriteLine("Project Enddate:");
                            var edate=Console.ReadLine();
                            
                            var newProject  = new Project(id,name,sdate,edate);
                            home.AddProject(newProject);
                
                            break;
                    case 2:
                            home.DisplayAllProject();
                            break;
                    case 4:
                            return;
                    default:
                            Console.WriteLine("Select valid option");
                            break;



                   }
                        Console.WriteLine("Select option:");
                        userInput = Convert.ToInt32(Console.ReadLine());
                
                  }
                            Console.ReadLine();
                    
        }
    }
}
