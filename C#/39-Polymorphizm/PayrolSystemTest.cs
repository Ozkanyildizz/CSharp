
using System;
using System.Collections.Generic;


namespace C_
{
    public class PayrolSystemTest
    {
        public void Test()
        {
            // create derived-class objects
            var salariedEmployee = new Salaried_Employee("John", "Smith",
                "111-11-1111", 800.00M);
            var hourlyEmployee = new Hourly_Employee("Karen", "Price",
                "222-22-2222", 16.75M, 40.0M);
            var commissionEmployee = new Commision_Employee("Sue", "Jones",
                "333-33-3333", 10000.00M, .06M);
            var basePlusCommissionEmployee = new BasePlus_Commision_Employee("Bob", "Lewis",
                "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Employees processed individually:\n");

            Console.WriteLine("{0}\n{1:C}\n",
                salariedEmployee, salariedEmployee.Earnings());
            Console.WriteLine("{0}\n{1:C}\n",
                hourlyEmployee, hourlyEmployee.Earnings());
            Console.WriteLine("{0}\n{1:C}\n",
                commissionEmployee, commissionEmployee.Earnings());
            Console.WriteLine("{0}\n{1:C}\n",
                basePlusCommissionEmployee, basePlusCommissionEmployee.Earnings());

            // create List<Employee> and initialize with employee objects
            var employees = new List<Employee>() { salariedEmployee,
            hourlyEmployee, commissionEmployee, basePlusCommissionEmployee };

            Console.WriteLine("Employees processed polymorphically:\n");

            // generically process each element in employees
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee); // invokes ToString

                // determine whether element is a BasePlusCommissionEmployee
                if (currentEmployee is BasePlus_Commision_Employee)
                {
                    // downcast Employee reference to
                    // BasePlusCommissionEmployee reference
                    var employee = (BasePlus_Commision_Employee)currentEmployee;

                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine(
                        "new base salary with 10% increase is: {0:C}",
                        employee.BaseSalary);
                }

                Console.WriteLine(
                    "earned: {0:C}\n", currentEmployee.Earnings());
            }

            // get type name of each object in employees
            for (int j = 0; j < employees.Count; j++)
            {
                Console.WriteLine(
                    "Employee {0} is a {1}",
                    j, employees[j].GetType());
            }
        }

    }
}




