using System;


namespace account
{
    class Account
    {
        private string accountName;

        public void SetName(string name) { accountName = name; }
        public string GetName(){ return accountName; }

    }
    class Account2
    {
         private string accountName2;
        
        public string Name
        {
            get { return accountName2; }
            set { accountName2 = value; }
        }
    }

    class Account3
    {
        // Auto-implemented property
        public string AccountName3 { get; set; }
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0.0m)
                {
                    balance = value;
                }
            }
        }
        public Account3(string name = "Default", decimal InitialBalance = 0.0m)
        {
            AccountName3 = name;
            Balance = InitialBalance;
        }


    }
}
