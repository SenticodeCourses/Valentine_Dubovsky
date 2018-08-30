using System.Collections.Generic;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.Library.CompanyResources
{
    public class Department
    {
        public Department()
        {
            Workers = new List<Employee>();
        }

        public List<Employee> Workers { get; set; }
        public Speciality Speciality { get; set; }
        public Head Head { get; set; }
        public List<Employee> FreeWorkers { get; set; }
    }
}
