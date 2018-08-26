using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDubovsky.CompanyManagement.Library.CompanyResources;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.Library
{
    public class Task
    {
        private static Random r = new Random();

        public Task()
        {
            HardnessLevel = (Level)r.Next(0, 2);
            Speciality = (Speciality)r.Next(0, 3);
            DaysRequired = r.Next(1, 6);
        }

        public Level HardnessLevel { get; set; }
        public Speciality Speciality { get; set;}
        public int DaysRequired { get; set; }
        public Specialist Performer { get; set; }
    }
}
