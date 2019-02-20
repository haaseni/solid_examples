using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mock up some employers with employees
            var acme    = new Employer { Id = 1, Name = "ACME, Inc." };
            var widgets = new Employer { Id = 2, Name = "Widgets, LLC." };

            var john    = new Employee { Ssn = "238495949", FirstName = "John", LastName = "Miller", Employers = new List<Employer>{ acme } };
            var jane    = new Employee { Ssn = "549028378", FirstName = "Jane", LastName = "Brown", Employers = new List<Employer> { acme } };
            var mike    = new Employee { Ssn = "372643007", FirstName = "Mike", LastName = "Smith", Employers = new List<Employer> { acme } };

            var mary    = new Employee { Ssn = "876287634", FirstName = "Mary", LastName = "Jones", Employers = new List<Employer> { widgets } };
            var steve   = new Employee { Ssn = "127348676", FirstName = "Steve", LastName = "Wright", Employers = new List<Employer> { widgets } };

            var nancy   = new Employee { Ssn = "728378873", FirstName = "Nancy", LastName = "Williams" };
            var mark    = new Employee { Ssn = "878278378", FirstName = "Mark", LastName = "Johnson" };
            
            acme.Employees = new List<Employee> { john, jane, mike };
            widgets.Employees = new List<Employee> { mary, steve };

            var employers = new List<Employer> { acme, widgets };

            // Illustrating the Single Responsibility Principle,
            // the employer can only do things that are the ability
            // of the employer like terminate or hire employees. 
            // The employee can only do things that are the ability
            // of the employee like resign.
            
            Console.WriteLine("BEFORE");
            PrintData(employers);

            // Jane unfortunately needed to be terminated by ACME, Inc., but 
            // then ACME, Inc. hired Nancy to fill that empty position
            acme.Terminate(jane); 
            acme.Hire(nancy);

            // John found another position with Widgets, LLC. so he
            // resigned from ACME, Inc.
            john.Resign(acme);
            widgets.Hire(john);

            // Widgets, LLC. is expanding, so they hire Mark.
            widgets.Hire(mark);

            Console.WriteLine("\nAFTER");
            PrintData(employers);

            Console.ReadKey();
        }

        static void PrintData(List<Employer> employers)
        {
            Console.WriteLine(new string('-', 77));

            employers.ForEach(emp =>
            {
                Console.WriteLine($"Employer: {emp.Name}");
                Console.WriteLine(new string('-', 77));

                Console.WriteLine("Name             SSN");
                emp.Employees.ForEach(e =>
                {
                    var name = $"{e.FirstName} {e.LastName}";
                    var offset = 17 - name.Length;
                    Console.WriteLine($"{e.FirstName} {e.LastName}{new string(' ', offset)}{e.Ssn.Insert(5, "-").Insert(3, "-")}");
                });
                Console.WriteLine(new string('-', 77));
            });
        }
    }
}
