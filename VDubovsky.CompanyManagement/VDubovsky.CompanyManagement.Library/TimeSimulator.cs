using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDubovsky.CompanyManagement.Library
{
    public class TimeSimulator
    {
        private static int day = 1;
        public static int Day { get { return day; } }
        public static void NextDay(Company company)
        {
            day++;
            foreach (var proj in company.Projects)
            {
                proj.DaysRequired--;
                foreach (var task in proj.Tasks)
                {
                    task.DaysRequired--;
                }
            }
        }
    }
}
