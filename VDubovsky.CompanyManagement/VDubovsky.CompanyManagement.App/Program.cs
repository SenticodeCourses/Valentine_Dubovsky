using System;
using System.Collections.Generic;
using System.Linq;
using VDubovsky.CompanyManagement.Library;
using VDubovsky.CompanyManagement.Library.CompanyResources;
using VDubovsky.CompanyManagement.Library.CompanyResources.Staff;

namespace VDubovsky.CompanyManagement.App
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Company company = new Company()
            {
                Employees = new List<Employee>
                {
                    new Head { Name = "Charlie Alvarado", Age = 34, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Senior },
                    new Head { Name = "Jordan Carroll", Age = 31, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Senior },
                    new Head { Name = "Alice Phelps", Age = 32, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Senior },

                    new Specialist { Name = "Javier Mckinney", Age = 30, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Senior },
                    new Specialist { Name = "Bryan Leonard", Age = 29, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Senior },
                    new Specialist { Name = "Colin Weber", Age = 29, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Senior },
                    new Specialist { Name = "Kathryn Freeman", Age = 31, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Senior },
                    new Specialist { Name = "Sonja Yates", Age = 32, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Senior },
                    new Specialist { Name = "Frederick Schmidt", Age = 30, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Senior},
                    new Specialist { Name = "Gary Hughes", Age = 29, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Senior},
                    new Specialist { Name = "Ignacio Warren", Age = 29, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Senior},
                    new Specialist { Name = "Debra Harrison", Age = 30, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Senior},
                    new Specialist { Name = "Sabrina Patton", Age = 30, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Senior},
                    new Specialist { Name = "Otis Bridges", Age = 31, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Senior },
                    new Specialist { Name = "Juan Bass", Age = 32, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Senior },
                    new Specialist { Name = "Armando Wheeler", Age = 30, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Senior },
                    new Specialist { Name = "Sally Bowen", Age = 29, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Senior },
                    new Specialist { Name = "Samantha Briggs", Age = 29, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Senior },

                    new Specialist { Name = "Amos Ortiz", Age = 25, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Brandon Lloyd", Age = 26, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Lonnie	Wise", Age = 27, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Ronnie	Quinn", Age = 25, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Jake Barnett", Age = 26, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Rodney Pearson", Age = 27, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Willis Rios", Age = 24, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Clara Hodges", Age = 25, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Elaine Robertson", Age = 27, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Adrienne Jacobs", Age = 24, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Middle },
                    new Specialist { Name = "Daniel Jimenez", Age = 28, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Aaron Cook", Age = 26, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Ralph Nguyen", Age = 28, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Gilberto Carr", Age = 25, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Arthur	Grant", Age = 24, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Julian	Powell", Age = 26, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Wade Bridges", Age = 27, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Michele Bowman", Age = 25, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Geraldine Hines", Age = 28, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Marie Andrews", Age = 24, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Middle },
                    new Specialist { Name = "Shane Martinez", Age = 25, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Percy Bishop", Age = 26, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Jermaine Rowe", Age = 24, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Mandy Gomez", Age = 27, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Joan Jensen", Age = 25, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Heidi Hunter", Age = 26, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Jody Mills", Age = 24, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Chelsea Lawrence", Age = 23, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Donna Gonzales", Age = 23, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Middle },
                    new Specialist { Name = "Shari Wolfe", Age = 24, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Middle },

                    new Specialist { Name = "Kurt Luna", Age = 20, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Moses Alvarez", Age = 21, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Emanuel Bass", Age = 22, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Trevor Fernandez", Age = 23, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Fred Mcguire", Age = 20, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Martin	Medina", Age = 23, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Pat Ross", Age = 22, Sex = Sex.Male, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Kristi	Morton", Age = 23, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Rebecca Rodriquez", Age = 22, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Lucy Hines", Age = 21, Sex = Sex.Female, Speciality = Speciality.Developer, Level = Level.Junior },
                    new Specialist { Name = "Derek Marshall", Age = 20, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "MaxFranklin", Age = 20, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Jorge Simmons", Age = 21, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Shawn Gill", Age = 21, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Ervin Morton", Age = 22, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Warren Welch", Age = 23, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Raymond Perez", Age = 21, Sex = Sex.Male, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Irma Ortiz", Age = 20, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Annie Reed", Age = 22, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Arlene	Hamilton", Age = 23, Sex = Sex.Female, Speciality = Speciality.DevOps, Level = Level.Junior },
                    new Specialist { Name = "Daniel Flores", Age = 21, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Phillips Clayton", Age = 21, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Bradley Medina", Age = 20, Sex = Sex.Male, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Blanca Ramos", Age = 21, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Amanda Bryan", Age = 22, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Holly Brock", Age = 21, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Mabel Mason", Age = 20, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Jeannette Lynch", Age = 21, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Melanie Smith", Age = 23, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Junior },
                    new Specialist { Name = "Vickie	Phillips", Age = 24, Sex = Sex.Female, Speciality = Speciality.QaEngineer, Level = Level.Junior }
                },
                Hardware = new List<Hardware>(),
                Departments = new List<Department>()
                {
                    new Department() { Speciality = Speciality.Developer },
                    new Department() { Speciality = Speciality.QaEngineer },
                    new Department() { Speciality = Speciality.DevOps }
                },
                Soft = Enumerable.Range(1, 3)
                    .Select(i => new Software())
                    .ToList()
            };
            company.Initialize();


            //Customer c1 = new Customer(company) { Name = "Microsoft" };
            //Customer c2 = new Customer(company) { Name = "Apple" };
            //Customer c3 = new Customer(company) { Name = "Samsung" };
            var c1 = company.AddCustomer("Microsoft");
            var c2 = company.AddCustomer("Apple");
            var c3 = company.AddCustomer("Samsung");
            company.CreateProject(c1, "Microsoft.DesktopApp");
            company.CreateProject(c1, "Microsoft.MobileApp");
            company.CreateProject(c2, "AppleApp");
            company.CreateProject(c3, "SamsungApp");

            Console.WriteLine(TimeSimulator.Day);
            while (true)
            {
                var key = Console.ReadLine();
                if (key == "K" || key == "k")
                    NextDayEvent(company);
            }


            // ReSharper disable once FunctionNeverReturns
        }



        public static void NextDayEvent(Company company)
        {
            TimeSimulator.NextDay(company);
            company.Refresh();
        }
    }
}
