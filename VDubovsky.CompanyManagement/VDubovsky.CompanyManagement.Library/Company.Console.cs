using System;

namespace VDubovsky.CompanyManagement.Library
{
    public partial class Company
    {
		public void PrintImpossible()
        {
            Console.WriteLine("Impossible to start a new project. There is a lack of workers or managers, required for a current project right now.");
        }
    }
}
