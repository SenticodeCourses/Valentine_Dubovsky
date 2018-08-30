using System;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.Library
{
    public class Task
    {
        private static readonly Random Rand = new Random();

        public Task()
        {
            HardnessLevel = (Level)Rand.Next(0, 2);
            Speciality = (Speciality)Rand.Next(0, 3);
            DaysRequired = Rand.Next(1, 6);
        }

        public Level HardnessLevel { get; set; }
        public Speciality Speciality { get; set;}
        public int DaysRequired { get; set; }
        public Specialist Performer { get; set; }
    }
}
