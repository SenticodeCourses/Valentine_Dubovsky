using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDubovsky.CompanyManagement.Library.CompanyResources;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.Library
{
    public class Project
    {
        private static Random rand = new Random();
        public Project()
        {
            Tasks = Enumerable.Range(1, rand.Next(2, 7))
                .Select(i => new Task())
                .ToList();
            Team = new Team();
            List<int> daysArray = new List<int>();
            foreach (var task in Tasks)
            {
                daysArray.Add(task.DaysRequired);
            }
            DaysRequired = daysArray.Max();
        }

        public Customer Customer { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public Team Team { get; set; }
        public int DaysRequired { get; set; }
    }
}
