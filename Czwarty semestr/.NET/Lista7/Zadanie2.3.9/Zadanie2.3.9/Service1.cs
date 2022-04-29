using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2._3._9
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        public void Start()
        {
            this.OnStart(null);
        }

        System.Timers.Timer timer;

        protected override void OnStart(string[] args)
        {
            timer = new System.Timers.Timer(1000 * 60);
            timer.Elapsed += (s, e) =>
            {
                try
                {
                    timer.Stop();

                    Process[] proces = Process.GetProcesses();
                    StreamWriter streamWriter = new StreamWriter("C:/Users/gpiot/DesktopDane.txt", append: true);
                    StreamWriter writer = streamWriter;
                    
                        writer.WriteLine(DateTime.Now);
                        foreach (var item in proces)
                        {
                            writer.WriteLine(item);
                        }
                        writer.WriteLine();
                    writer.Dispose();
                }
                finally
                {
                    timer.Start();
                }
            };
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }
    }
}
