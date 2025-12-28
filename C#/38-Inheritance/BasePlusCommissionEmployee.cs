using System;

namespace C_
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;
        public BasePlusCommissionEmployee(
            string firstName,
            string lastName,
            string socialSecurityNumber,
            decimal grossSales,
            decimal commissionRate,
            decimal baseSalary)
            : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(BaseSalary)} must be >= 0");
                }
                baseSalary = value;
            }
        }

        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }
        public override string ToString()
        {
            return $"base-salaried {base.ToString()}\n" +
                   $"base salary: {BaseSalary:C}";
        }
    }

    public class BasePlusCommissionEmployeeTest
    {
        public void test()
        {
            BasePlusCommissionEmployee employee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);
            Console.WriteLine("Employee information obtained by ToString:\n");                  
            Console.WriteLine(employee.ToString());
        }
    }
} 