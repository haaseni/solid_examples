using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace SingleResponsibilityPrincipleExample
{
    public class Employer
    {
        public Employer()
        {
            Employees = new List<Employee>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

        public void Hire(Employee employee)
        {
            employee.Employers.Add(this);
            Employees.Add(employee);
        }

        public void Terminate(Employee employee)
        {
            var employer = employee.Employers.FirstOrDefault(e => e.Id == Id);

            if (employer != null)
                employee.Employers.Remove(employer); // Remove employer from employee

            if (Employees.Any(e => e.Ssn == employee.Ssn))
                Employees.Remove(employee); // Remove employee from employer
        }
    }
}
