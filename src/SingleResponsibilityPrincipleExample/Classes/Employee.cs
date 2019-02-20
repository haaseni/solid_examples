using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibilityPrincipleExample
{
    public class Employee
    {
        public Employee()
        {
            Employers = new List<Employer>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Ssn { get; set; }

        public List<Employer> Employers { get; set; }

        public void Resign(Employer employer)
        {
            var employee = employer.Employees.FirstOrDefault(e => e.Ssn == Ssn);
            
            if (employee != null)
                employer.Employees.Remove(employee); // Remove employee from employer

            if (Employers.Any(e => e.Id == employer.Id))
                Employers.Remove(employer); // Remove employer from employee
        }
    }
}
