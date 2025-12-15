using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class LINQtoArrayOfObjects
    {
        public void Exercise()
        {
            var employees = new[] {
                new EmployeeInfo("Jason", "Red", 5000M),
                new EmployeeInfo("Ashley", "Green", 7600M),
                new EmployeeInfo("Matthew", "Indigo", 3587.5M),
                new EmployeeInfo("James", "Indigo", 4700.77M),
                new EmployeeInfo("Luke", "Indigo", 6200M),
                new EmployeeInfo("Jason", "Blue", 3200M),
                new EmployeeInfo("Wendy", "Brown", 4236.4M)
            };


            Console.WriteLine("Original array:");
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }


            var between4K6K =
                from e in employees
                where e.MonthlySalary >= 4000M && e.MonthlySalary <= 6000M
                select e;

            Console.WriteLine("\nEmployees earning in the range $4000-$6000 per month:");
            foreach (var element in between4K6K)
            {
                Console.WriteLine(element);
            }


            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            Console.WriteLine("\nFirst employee when sorted by name:");
            if (nameSorted.Any()) // check if sequence is not empty empyt = false , not empyt = true
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("not found");
            }


            var lastNames =
                from e in employees
                select e.LastName;

            Console.WriteLine("\nUnique employee last names:");
            foreach (var element in lastNames.Distinct()) // Distinct to get unique last names
            {
                Console.WriteLine(element);
            }


            var names =
                from e in employees
                select new { e.FirstName, e.LastName };

            Console.WriteLine("\nNames only:");
            foreach (var element in names)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine(lastNames.GetType().Name);
        }
    }


    class EmployeeInfo
    {
        public string FirstName { get; }
        public string LastName { get; }
        private decimal monthlySalary;


        public EmployeeInfo(string firstName, string lastName, decimal monthlySalary)
        {
            
            if (monthlySalary < 0M)
            {
                throw new ArgumentOutOfRangeException(nameof(monthlySalary), "Monthly salary must be non-negative.");
            }

            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }


        public decimal MonthlySalary
        {
            get { return monthlySalary; }
            set
            {
                if (value < 0M)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Monthly salary must be non-negative.");
                }

                monthlySalary = value;
            }
        }


        public override string ToString() =>
            $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    }
}