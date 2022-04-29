using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2._3._9
{
	static class Program
	{
		/// <summary>
		/// Główny punkt wejścia dla aplikacji.
		/// </summary>
		static void Main()
		{
			if(Environment.UserInteractive)
            {
				Service1 service = new Service1();
				service.Start();
				Console.ReadLine();
            }
			else
            {
				ServiceBase[] ServicesToRun;
				ServicesToRun = new ServiceBase[]
				{
				new Service1()
				};

				ServiceBase.Run(ServicesToRun);
			}				
		}
	}
}