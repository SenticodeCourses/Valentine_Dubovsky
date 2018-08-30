using System;
using VDubovsky.SystemMonitoring.FolderMonitoring;
using System.Threading;

namespace VDubovsky.SystemMonitoring.App
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            //string control;
            Console.WriteLine("Enter path for the directory you want to monitor:");
            var path = Console.ReadLine();
            Console.WriteLine("Enter interval of monitoring:");
            var intr = Convert.ToInt32(Console.ReadLine());
            var monitor1 = new FolderMonitor(path, intr);
            var thread = new Thread(monitor1.Monitoring);
            thread.Start();
            while (true)
            {
                Console.ReadLine();
                monitor1.IsActive = !monitor1.IsActive;
                Console.WriteLine(!monitor1.IsActive ? "Monitoring paused." : "Monitoring resumed.");
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}
