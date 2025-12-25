using System;


namespace C_
{
    internal class Salaried_Employee: Employee
    {
        
        private decimal weeklySalary;
        public Salaried_Employee(string firstName, string lastName, string ssn, decimal weeklySalary): base(firstName, lastName, ssn)
        {
            WeeklySalary = weeklySalary;
        }
       
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value >= 0)
                {
                    weeklySalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(WeeklySalary)}  must be >= 0");
                }
            }
        }
        public override decimal Earnings()
        {
            return (int)WeeklySalary;
        }

        public override string ToString()=> $"Salaried Employee: {base.ToString()}\n" +
                                     $"Weekly Salary: {this.WeeklySalary:C}";
    }
}
