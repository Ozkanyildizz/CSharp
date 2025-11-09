using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Program program = new Program();
             program.SampleMethod();

             //SampleMethod(); // This will cause an error because SampleMethod is not static

            // İntrodustion.cs 
            İntroduction introObj = new İntroduction();
            introObj.introduction();

            // Acount.cs
            Account myAccount = new Account();
            Console.WriteLine(myAccount.GetName());
            myAccount.SetName("Özkan");

            // Account2 
            Account2 myAccount2 = new Account2();
            myAccount2.Name = "Yıldız";
            Console.WriteLine(myAccount2.Name);

            // Account3
            Account3 myAccount3 = new Account3("CustomName",150.0m);
            Account3 myAccount3_1 = new Account3("CustomName2", -150.0m);
            Console.WriteLine(myAccount3.AccountName3);
            Console.WriteLine($"{myAccount3.Balance:C}"); // :C currency format
            Console.WriteLine(myAccount3_1.AccountName3);
            Console.WriteLine($"{myAccount3_1.Balance:C}");
            // myAccount3.Balance = 100.50m; // This will not change the balance due to private setter

            // FormatSpecifier.cs
            Format_specifier formatObj = new Format_specifier();
            formatObj.specifier();

            // StudentGrade.cs
            StudentGrade firstStudent = new StudentGrade("Özkan", 95);
            Console.WriteLine($"{firstStudent.Name}'s grade is {firstStudent.Grade} which is a {firstStudent.LetterGrade}");

            StudentGrade SecondStudent = new StudentGrade("Yıldız", 50);
            Console.WriteLine($"{SecondStudent.Name}'s grade is {SecondStudent.Grade} which is a {SecondStudent.LetterGrade}");
            
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the student's grade: ");
            int grade = int.Parse(Console.ReadLine());

            StudentGrade thirdStudent = new StudentGrade(name, grade);
            Console.WriteLine($"{thirdStudent.Name}'s grade is {thirdStudent.Grade} which is a {thirdStudent.LetterGrade}");

            // WhileLoop.cs
            whileLoop whileObj = new whileLoop();
            whileObj.avarage();
            whileObj.analysis();

            // TypeConversion.cs
            TypeConversion typeConversionObj = new TypeConversion();
            typeConversionObj.typeConversion();

             // ControlFlow.cs
            ControlFlow controlFlowObj = new ControlFlow();
            controlFlowObj.forLoop();
            controlFlowObj.doWhileLoop();
            StudentGrade letterGradesObj = new StudentGrade();
            Console.WriteLine(letterGradesObj.LetterGrade);

            // LogicalOperators.cs
            LogicalOperatorsTable.logicalOp();
            
            // RandomNumbers.cs
            RandomNumbers.frequencyOFDie();

          // Craps.cs
            CrapsGame.Play();
          

            */
            // SquareTest.cs
            Console.WriteLine(SquareTest.OptionalTest());
            Console.WriteLine(SquareTest.Test(5));
            Console.WriteLine(SquareTest.Test(5.5));

            TimeSetter t = new TimeSetter();
            t.SetTime(2, 0, 22); // Çıktı: Time: 12:00:22
            t.SetTime(hour: 12, second: 22); // minute belirtilmedi → default 0 // Çıktı: Time: 12:00:22 
            t.SetTime(second: 22, hour: 12); // sıra önemli değil Çıktı: Time: 12:00:22
                                            





        }
        void SampleMethod()
        {
            
            Console.WriteLine("Sample Method Executed");
        }
    }
}
// This is a comment 
/*
 This is also a comment
 */