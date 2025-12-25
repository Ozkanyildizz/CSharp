using System;


namespace C_
{
    internal class Hourly_Employee: Employee
    {
        public decimal wage;
        public decimal hour;
        public Hourly_Employee(string firstName, string lastName, string ssn, decimal wage, decimal hour): base(firstName, lastName, ssn)
        {
            Wage = wage;
            Hour = hour;
        }
        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value >= 0)
                {
                    wage = (int)value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Wage)} must be >= 0");
                }
            }
        }
        public decimal Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value <= 168)
                {
                    hour = (int)value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Hour)} must be >= 0 and <= 168");
                }
            }
        }
        public override decimal Earnings()
        {
            if (hour <= 40)
            {
                return wage * hour;
            }
            else
            {
                return (wage * 40) + ((hour - 40) * wage * 1.5M);
            }
        }
            public override string ToString()=> $"Hourly Employee: {base.ToString()}\n" +
                                         $"Hourly Wage: {this.Wage:C}\n" +
                                         $"Hours Worked: {this.Hour:F2}";
    }
    
}
