using System;
using System.Collections.Generic;
using System.Linq;
using VDubovsky.CompanyManagement.Library.CompanyResources;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.Library
{
    public partial class Company
    {
        private bool _lackOfManagers;
        private bool _lackOfWorkers;

        public List<Employee> Employees = new List<Employee>();
        public List<Hardware> Hardware = new List<Hardware>();
        public List<Software> Soft = new List<Software>();
        public List<Department> Departments = new List<Department>();
        public List<Project> Projects = new List<Project>();
        public Dictionary<Customer, List<Project>> CustomersProjectsDict = new Dictionary<Customer, List<Project>>();

        public void Initialize()
        {
            foreach (var emp in Employees)
            {
                foreach (var dept in Departments)
                {
                    if (emp.GetType() == typeof(Head) && emp.Speciality == dept.Speciality)
                        dept.Head = (Head)emp;
                    if (emp.Speciality == dept.Speciality)
                        dept.Workers.Add(emp);
                }
            }
            foreach (var dept in Departments)
                dept.FreeWorkers = dept.Workers
                    .Skip(1).ToList();
        }
        public Customer AddCustomer(string name)
        {
            var customer = new Customer() { Name = name.Trim() };
            CustomersProjectsDict.Add(customer, new List<Project>());
            return customer;
        }
        private void HireManagerToProject()
        {
            foreach (var dpt in Departments)
            {
                var managersCount = Projects.Last().Team.Managers.Count;
                foreach (var fwrk in dpt.FreeWorkers)
                {
                    if (fwrk.Level == Level.Senior)
                    {
                        Projects.Last().Team.Managers.Add(fwrk);
                        fwrk.IsInTeam = true;
                        dpt.FreeWorkers.Remove(fwrk);
                        break;
                    }
                }
                if (Projects.Last().Team.Managers.Count == managersCount)
                {
                    _lackOfManagers = true;
                    break;
                }
            }
        }
        private void HireWorkersToProject()
        {
            foreach (var task in Projects.Last().Tasks)
            {
                foreach (var dpt in Departments)
                {
                    if (dpt.Speciality == task.Speciality)
                        foreach (var fwrk in dpt.FreeWorkers)
                        {
                            if (fwrk.Level == task.HardnessLevel)
                            {
                                Projects.Last().Team.Members.Add(fwrk);
                                fwrk.IsInTeam = true;
                                dpt.FreeWorkers.Remove(fwrk);
                                task.Performer = (Specialist)fwrk;
                                break;
                            }
                        }
                }
                if (task.Performer == null)
                    _lackOfWorkers = true;
            }
        }
        public void CreateProject(Customer customer, string name)
        {
            Projects.Add(new Project { Customer = customer, Name = name.Trim() });
            CustomersProjectsDict[customer].Add(Projects.Last());
            HireManagerToProject();
            HireWorkersToProject();
            if (_lackOfManagers || _lackOfWorkers)
            {
                Projects.Remove(Projects.Last());
                PrintImpossible();
            }
        }
        public void Refresh()
        {
            for (int i = 0; i < Projects.Count; i++) 
            {
                for (int j = 0; j < Projects[i].Tasks.Count; j++) 
                {
                    if (Projects[i].Tasks[j].DaysRequired == 0)
                        for (int k = 0; k <= Departments.Count; k++)
                        {
                            if ( Projects[i].Tasks[j].Performer.Speciality == Departments[k].Speciality)
                            {
                                Projects[i].Tasks[j].Performer.IsInTeam = false;
                                Departments[k].FreeWorkers.Add(Projects[i].Tasks[j].Performer);
                                Projects[i].Team.Members.Remove(Projects[i].Tasks[j].Performer);
                                Projects[i].Tasks.Remove(Projects[i].Tasks[j]);
                                break;
                            }
                        }
                }
                if (Projects[i].DaysRequired == 0)
                {
                    Projects.Remove(Projects[i]);
                    CustomersProjectsDict[Projects[i].Customer].Remove(Projects[i]);
                    Console.WriteLine($"Project for {Projects[i].Customer.Name} is finished.");
                }
            }
            var tempCustomersProjectsDict = new Dictionary<Customer, List<Project>>();
            foreach (var kv in CustomersProjectsDict)
            {
                if (kv.Value.Count != 0)
                {
                    tempCustomersProjectsDict.Add(kv.Key, kv.Value);
                }
            }
            CustomersProjectsDict = tempCustomersProjectsDict;
        }
    }
}












//public void Reresh()
//{
//    foreach (var proj in Projects)
//    {
//        foreach (var task in proj.Tasks)
//        {
//            if (task.DaysRequired == 0)
//                foreach (var dept in Departments)
//                {
//                    if (task.Performer.Speciality == dept.Speciality)
//                    {
//                        task.Performer.isInTeam = false;
//                        dept.FreeWorkers.Add(task.Performer);
//                        proj.Team.Members.Remove(task.Performer);
//                        proj.Tasks.Remove(task);
//                        break;
//                    }
//                }
//        }
//        if (proj.DaysRequired == 0)
//        {
//            Projects.Remove(proj);
//            Console.WriteLine($"Project for {proj.Customer.Name} is finished.");
//        }
//    }
//}