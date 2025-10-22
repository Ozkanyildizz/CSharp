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
        public Account3(string name="Default")
        {
            AccountName3 = name;
        }
    }
}
