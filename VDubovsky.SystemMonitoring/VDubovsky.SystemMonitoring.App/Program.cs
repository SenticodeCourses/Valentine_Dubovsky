using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDubovsky.SystemMonitoring.FolderMonitoring;

namespace VDubovsky.SystemMonitoring.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path for the directory you want to monitor:");
            string path = Console.ReadLine();
            Console.WriteLine("Enter interval of monitoring:");
            int intr = Convert.ToInt32(Console.ReadLine());
            FolderMonitor Monitor1 = new FolderMonitor(path, intr);
            //FolderMonitor Monitor1 = new FolderMonitor("D:\test", 7);
            Monitor1.Monitoring();
        }
    }
}
