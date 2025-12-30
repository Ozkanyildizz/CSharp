using C_;
using StudentmanagerApp;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
           Program program = new Program();
           //program.SampleMethod();

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

           // SquareTest.cs
          Console.WriteLine(SquareTest.OptionalTest());
          Console.WriteLine(SquareTest.Test(5));
          Console.WriteLine(SquareTest.Test(5.5));

          TimeSetter t = new TimeSetter();
          t.SetTime(2, 0, 22); // Çıktı: Time: 12:00:22
          t.SetTime(hour: 12, second: 22); // minute belirtilmedi → default 0 // Çıktı: Time: 12:00:22 
          t.SetTime(second: 22, hour: 12); // sıra önemli değil Çıktı: Time: 12:00:22

          // ExpressionBodiedMethod.cs
          Console.WriteLine(ExpressionBodiedMethod.Cube(3));
          Console.WriteLine(ExpressionBodiedMethod.IsNaFaultState); 

          // RecursiveFactorial.cs
          RecursiveFactorialTest.Factorial();

          // Reference.cs
          ParameterTypes.Reference();

           // Arrays.cs
           Arrays.arrays();
           Arrays.rollDie();

           // ErrorHandling.cs
           ErrorsHandling obj = new ErrorsHandling();
           obj.studentPull();

           // Card.cs
           var c = new Card("Ace", "Spades");
           Console.WriteLine(c.ToString());





           // DeckOfCards.cs
           var myDeck = new DeckOfCards();

           myDeck.Shuffle();

           // 52 kartı sırayla yazdır; her 4 kartta bir yeni satıra geç
           for (int i = 0; i < 52; i++)
           {
               Card c = myDeck.DealCard();
               if (c != null)
               {
                   Console.Write($"{c,-20}"); // -20 ile sütun hizalaması
               }
               else
               {
                   Console.Write($"{"null",-20}");
               }

               if ((i + 1) % 4 == 0)
                   Console.WriteLine();

           }

            // passArray.cs
           PassArray.pass();

            //GradeBook.cs
           GradeBook gradeBookobj = new GradeBook();
           gradeBookobj.gradeBook();

           // MultiDimensionalArrays.cs
           MultiDimensionalArrays multiDimensionalArraysObj = new MultiDimensionalArrays();
           multiDimensionalArraysObj.multiDimensionalArrays();

           //MultiDimensionalArraysExercises.cs
           GradeBookExercise.Test();

           //Param.cs
           ParamArrayTest.Test();


           // StudentManagerApp
           GradeManager student = new GradeManager(3,3);
           student.InputGrades();
           student.DisplayReport();

           // LING with simple arrays
           _25_LINQWithSimpleTypeArray obj = new _25_LINQWithSimpleTypeArray();
           obj.LINQWithSimpleTypeArray();



           // 26-LINQ Exercise WithArray 
           LINQtoArrayOfObjects obj = new LINQtoArrayOfObjects();
           obj.Exercise();



           // 27-ListCollections.cs
           _27_ListCollections listCollectionsObj = new _27_ListCollections();
           listCollectionsObj.Collection();


           // 28-LINQWithListCollection.cs
           _28_LINQWithListCollection lINQWithListCollectionObj = new _28_LINQWithListCollection();
           lINQWithListCollectionObj.LINQListCollection();

           // 29-Time.cs
           Time1Test time = new Time1Test();
           time.test();


           // 30-DateTime.cs
           DateTimeTest dateTimeTestObj = new DateTimeTest();
           dateTimeTestObj.time();


           // 31-ThisTest.cs
           ThisTest thisTestObj = new ThisTest();
           thisTestObj.test();

           //32-Time2.cs
           Time2Test time2TestObj = new Time2Test();
           time2TestObj.test();



           // 33-Composition.cs
           EmployeeTest obj = new EmployeeTest();
           obj.test();


           // 35-Operator Overloading.cs
           ComplexNumber c1 = new ComplexNumber(2.0, 3.0);
           ComplexNumber c2 = new ComplexNumber(4.0, 5.0);
           ComplexNumber sum = c1 + c2;
           ComplexNumber difference = c1 - c2;
           ComplexNumber product = c1 * c2;
           Console.WriteLine($"c1: {c1}");
           Console.WriteLine($"c2: {c2}");
           Console.WriteLine($"Sum: {sum}");
           Console.WriteLine($"Difference: {difference}");
           Console.WriteLine($"Product: {product}");



           // 36-Struct.cs
           StrustTest structTestObj = new StrustTest();
           structTestObj.test();


           // 37-Extension Methods.cs
           TimeExtensionsTest timeExtensionsTestObj = new TimeExtensionsTest();
           timeExtensionsTestObj.test();
           


            // 38-Inheritance.cs
            CommissionEmployeeTest commissionEmployeeTestObj = new CommissionEmployeeTest();
           commissionEmployeeTestObj.test();
           BasePlusCommissionEmployeeTest basePlusCommissionEmployeeTestObj = new BasePlusCommissionEmployeeTest();
           basePlusCommissionEmployeeTestObj.test();

             

            // 39-Polymorphizm.cs
            PayrolSystemTest polymorphizmTestObj = new PayrolSystemTest();
            polymorphizmTestObj.Test();

            
            // 40-Interface.cs
            PayableInterfaceTest payableInterfaceTestObj = new PayableInterfaceTest();
            payableInterfaceTestObj.test();

            
            //Exception Handling
            DividedByZeroExceptionHandling obj = new DividedByZeroExceptionHandling();
            obj.test2();
            obj.InnerExceptionExample();
            obj.HelpLinkTargetSiteExample();
            SquareRootTest.test();

              
            //some Operators
            SomeOperators.NullableTypeOperator();

            */
            // Exception Filters
            ExceptionFilters.TestExceptionFilters();
        }
    }
}
