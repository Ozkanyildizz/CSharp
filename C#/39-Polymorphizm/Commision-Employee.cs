using System;



namespace C_
{
    internal class Commision_Employee: Employee
    {
        public decimal grossSales;
        public decimal commissionRate;
        public Commision_Employee(string firstName, string lastName, string ssn, decimal grossSales, decimal commissionRate)
            : base(firstName, lastName, ssn)
        {
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
                if (value >= 0)
                {
                    grossSales = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(GrossSales)} must be >= 0");
                }
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
                if (value > 0 && value < 1)
                {
                    commissionRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(CommissionRate)} must be > 0 and < 1");
                }
            }
        }
        public override string ToString()
        {
            return $"Commission Employee: {FirstName} {LastName}\n" +
                   $"Social Security Number: {SSN}\n" +
                   $"Gross Sales: {this.GrossSales:C}\n" +
                   $"Commission Rate: {this.CommissionRate:F2}";
        }
        public override decimal Earnings()
        {
            return (GrossSales * CommissionRate);
        }

    }
}
