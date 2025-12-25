using System;


namespace C_
{
    abstract class Employee
    {
        public virtual string FirstName { get;  }
        public string LastName { get;  }
        public string SSN;
        public Employee(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}\nSocial Security Number: {2}", FirstName, LastName, SSN);
        }
        public abstract decimal Earnings();


    }
}
