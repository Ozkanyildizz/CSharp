using System;
using System.Linq.Expressions;

namespace C_
{
    public class CommissionEmployee
    {
        public string FirstName { get;  }
        public string LastName { get;  }
        public string SocialSecurityNumber { get;  }
        private decimal grossSales; // gross weekly sales
        private decimal commissionRate; // commission percentage
        // five-parameter constructor
        public CommissionEmployee(string firstName, string lastName,
           string socialSecurityNumber, decimal grossSales,
           decimal commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(GrossSales)} must be >= 0");
                }
                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                }
                commissionRate = value;
            }
        }
        // calculate earnings
        public virtual decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }
        // return string representation of CommissionEmployee object
        public override string ToString()
        {
            return $"commission employee: {FirstName} {LastName}\n" +
               $"social security number: {SocialSecurityNumber}\n" +
               $"gross sales: {GrossSales:C}\n" +
               $"commission rate: {CommissionRate:F2}";
        }
    }

    public class  CommissionEmployeeTest
    {
        public void test()
        {
            var employee = new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00m, .06m);
            Console.WriteLine("Employee information obtained by properties and methods:");
            Console.WriteLine($"First name is {employee.FirstName}");
            Console.WriteLine($"Last name is {employee.LastName}");
            Console.WriteLine($"Social security number is {employee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales is {employee.GrossSales:C}");
            Console.WriteLine($"Commission rate is {employee.CommissionRate:F2}");
            Console.WriteLine($"Earnings is {employee.Earnings():C}");
            employee.GrossSales = 5000.00m;
            employee.CommissionRate = .1m;
            Console.WriteLine("\nUpdated employee information obtained by ToString:");
            Console.WriteLine(employee.ToString());
            Console.WriteLine($"Earnings is {employee.Earnings():C}");
            Console.WriteLine();

            
            try{
                CommissionEmployee employee1 = new CommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00m, 2m);
                Console.WriteLine("\nEmployee information obtained by ToString:");
                Console.WriteLine(employee1.ToString());
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

        }
        
    }
}
