namespace VDubovsky.CompanyManagement.Library.CompanyResources.Staff
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Speciality Speciality { get; set; }
        public Sex Sex { get; set; }
        public Level Level { get; set; }
        public bool IsInTeam = false;
    }
}
