using System;


namespace C_
{
     class BasePlus_Commision_Employee: Commision_Employee
    {
        public decimal baseSalary;
       
        public BasePlus_Commision_Employee(string firstName, string lastName, string ssn, decimal grossSales, decimal commissionRate, decimal baseSalary): base(firstName, lastName, ssn,  grossSales,  commissionRate)
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
                if (value >= 0)
                {
                    baseSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(BaseSalary)} must be >= 0");
                }
            }
        }
        public override string ToString()
        {
            return 
                   $"Base-salaried: {base.ToString()}\nbase salary {BaseSalary:C}";
        }
        public override decimal Earnings()
        {
            return (BaseSalary + base.Earnings());
        }
    }
}
