﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDubovsky.CompanyManagement.Library.CompanyResources.Staff
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Speciality Speciality { get; set; }
        public Sex Sex { get; set; }
        public Level Level { get; set; }
        public bool isInTeam = false;
    }
}
