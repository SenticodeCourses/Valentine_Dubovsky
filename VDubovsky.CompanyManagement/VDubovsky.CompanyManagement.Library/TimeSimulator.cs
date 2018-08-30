namespace VDubovsky.CompanyManagement.Library
{
    public class TimeSimulator
    {
        public static int Day { get; private set; } = 1;

        public static void NextDay(Company company)
        {
            Day++;
            foreach (var proj in company.Projects)
            {
                proj.DaysRequired--;
                foreach (var task in proj.Tasks)
                {
                    task.DaysRequired--;
                }
            }
        }
    }
}
