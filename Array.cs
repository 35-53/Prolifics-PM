using System;

namespace accessing_array_value
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string[] project = new string[10];			
			string[] emp=new string[10];			
			string[] role=new string[10];
		
			int tproj=0;
			int temp=0;
			int trole=0;
			
			int n;
			Console.Write("Enter number of attempts:");
			n=Convert.ToInt32(Console.ReadLine());
			while(n>=1)
		
		{
			Console.WriteLine("                  1.Add project:                  ");
			Console.WriteLine("                  2.View project:                 ");
			Console.WriteLine("                  3.Add employee:                  ");
			Console.WriteLine("                  4.View employee:                 ");
			Console.WriteLine("                  5.Add Role:                       ");
			Console.WriteLine("                  6.View Role:                      ");
			Console.WriteLine("Choose anyone option:");
			int opt=Convert.ToInt32(Console.ReadLine());
			switch(opt)
			{
				case 1:
						{
							
							Console.WriteLine("Enter number of projects:");
							int npro=Convert.ToInt32(Console.ReadLine());
							for(int k=1;k<=npro;k++)
							{
								Console.WriteLine("Enter ur project name:");
								project[tproj++]=Console.ReadLine();
			
							}
							Console.WriteLine("Successfully Added:");
						}
						goto default;
						break;

				case 2:
								Console.WriteLine("Added projects:");
								for(int k=0;k<=tproj;k++)
								{
									Console.WriteLine(project[k]);
								}
								
								goto default;
								break;
				
				case 3:
							{
								Console.WriteLine("Enter number of Employess:");
								
								int ne=Convert.ToInt32(Console.ReadLine());
								for(int k=1;k<=ne;k++)
								{
									Console.WriteLine("Enter employee name:");
									emp[temp++]=(Console.ReadLine());
			
								}
								Console.WriteLine("Successfully entered employee details:");
							}
							goto default;
							break;
				
				case 4:
								Console.WriteLine("Added Employees:");
								
								for(int k=0;k<=temp;k++)
							{
								Console.WriteLine(emp[k]);
							}
								
							goto default;
							break;
				case 5:
						{
							
							Console.WriteLine("Enter number of roles:");
							int nro=Convert.ToInt32(Console.ReadLine());
							for(int k=1;k<=nro;k++)
							{
								Console.WriteLine("Enter ur role name:");
								role[trole++]=Console.ReadLine();
			
							}
							Console.WriteLine("Successfully Added:");
						}
						goto default;
						break;

				case 6:
								Console.WriteLine("Added roles:");

									for(int k=0;k<=trole;k++)
								{
									Console.WriteLine(role[k]);
								}
								
								goto default;
								break;
				
				
				default:
					Console.WriteLine("Press any key to exit:");
					break;
		
			}
				n--;
		}
			Console.ReadLine();
	
					
									  
			 }
		 
		}								  
}
