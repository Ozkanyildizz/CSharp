using account;
using intro;
using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // İntrodustion.cs 
            İntroduction introObj = new İntroduction();
            introObj.introduction();

            // Acount.cs
            Account myAccount = new Account();
            myAccount.SetName("Özkan");
            Console.WriteLine(myAccount.GetName());

            // Account2 
            Account2 myAccount2 = new Account2();
            myAccount2.Name = "Yıldız";
            Console.WriteLine(myAccount2.Name);

            // Account3
            Account3 myAccount3 = new Account3("CustomName");
            Console.WriteLine(myAccount3.AccountName3);

        }
    }
}
// This is a comment 
/*
 This is also a comment
 */