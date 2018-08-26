using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDubovsky.CompanyManagement.Library.CompanyResources;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.Library
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
