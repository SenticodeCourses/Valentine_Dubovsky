using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDubovsky.CompanyManagement.Library.CompanyResources;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.Library
{
    public class Team
    {
        public Team()
        {
            Members = new List<Employee>();
            Managers = new List<Employee>();
        }
        public List<Employee> Members { get; set; }
        public List<Employee> Managers { get; set; }
    }
}
