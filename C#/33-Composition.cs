using System;

/*
 Composition Nedir?
 Bir sınıfın içinde başka sınıflardan nesneler veya değer türleri barındırmasıdır.*/

public class Date
{
    private int month; // 1-12
    private int day;   // 1-31 (ay ve yıla bağlı)
    public int Year { get; private set; } // sadece okunabilir auto-implemented property

    // Constructor: ay, gün ve yıl değerlerini doğrular
    public Date(int monthValue, int dayValue, int yearValue)
    {
        Month = monthValue; // ay doğrulaması
        Year = yearValue;   // yıl atanması
        Day = dayValue;     // gün doğrulaması
        Console.WriteLine($"Date object constructor for date {this}");
    }

    // Ay property’si: hem getter hem private setter
    public int Month
    {
        get => month;
        private set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value), value, $"{nameof(Month)} must be 1-12");
            }
            month = value;
        }
    }

    // Gün property’si: hem getter hem private setter
    public int Day
    {
        get => day;
        private set
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Şubat ve artık yıl kontrolü
            if (Month == 2 && value == 29 &&
                (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
            {
                day = value; // geçerli artık yıl
                return;
            }

            // Gün aralığı kontrolü
            if (value < 1 || value > daysPerMonth[Month])
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value), value, $"{nameof(Day)} out of range for current month/year");
            }

            day = value;
        }
    }

    // Tarihi string olarak döndürür: "MM/DD/YYYY"
    public override string ToString() => $"{Month}/{Day}/{Year}";
}




public class Employee
{
    public static int EmployeeCount { get; private set; } // Toplam çalışan sayısı objeye değil sınıfa aittir static olanlar 
    public string FirstName { get; }
    public string LastName { get; }
    public Date BirthDate { get; }
    public Date HireDate { get; }

    public Employee(string firstName, string lastName, Date birthDate, Date hireDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        HireDate = hireDate;
        EmployeeCount++;
    }

}

class EmployeeTest
{
    public void test()
    {
        var birthDate = new Date(6, 15, 1985);
        var hireDate = new Date(8, 1, 2010);

        // Employee nesnesi oluşturma
        Employee employee = new Employee(
            "Jane", "Doe",
            birthDate,  // Doğum tarihi
            hireDate   // İşe başlama tarihi
        );
        // Çalışan bilgilerini yazdırma
        Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
        Console.WriteLine($"Birth Date: {employee.BirthDate}");
        Console.WriteLine($"Hire Date: {employee.HireDate}");
        Console.WriteLine("Total Employees: " + Employee.EmployeeCount);
    }
}