using System;
using System.IO;


namespace C_
{
    internal class SomeOperators
    {
        public static void nullConditionalOperator()
        {
            var reader = new StreamReader("veri.txt");
            if (reader != null)
            {
                reader.Dispose();
            }
            reader?.Dispose(); // Null-conditional operator kullanımı önceki kodla aynı işi yapar

        }
   
    public static void asOperator()
        {
            //Employee currentEmployee = new BasePlusCommissionEmployee("","","",0M,0M,0M);  
            // BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee)currentEmployee; // error BasePlusCommissionEmployee  Employee ye dönüştürülemiyor

            //var employee = currentEmployee as BasePlusCommissionEmployee;

            // Eğer currentEmployee gerçekten BasePlusCommissionEmployee ise → employee dolu olur.
            // Değilse → employee = null.

            // if (employee != null)
            //employee?.BaseSalary *= 1.10M;

        }
     public static void NullableTypeOperator()
        {
            int? nullableInt = null; // Nullable int türü
            nullableInt = nullableInt ?? -1; //  sol taraf Null ise → sağdaki alternatif değeri döner.-1 atanır  null değilse sol taraf döner
            Console.WriteLine(nullableInt?.ToString()); // -1 döner
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Value: {nullableInt.Value}");
                Console.WriteLine(nullableInt.GetValueOrDefault());
            }
            else
            {
                Console.WriteLine("nullableInt has no value.");
                Console.WriteLine(nullableInt.GetValueOrDefault());
                Console.WriteLine(nullableInt.GetValueOrDefault(100));

            }
            // Null-coalescing operator kullanımı
            int result = nullableInt ?? 0; // Eğer nullableInt null ise 0 kullanılır
            Console.WriteLine($"Result: {result}");
        }
    }   
}
