
// - interface 'interface' anahtar kelimesi ile tanımlanır.
// - İçinde sadece imza (abstract method, property, indexer, event) bulunur, gövde yazılmaz.
// - Tüm üyeler otomatik olarak public ve abstract kabul edilir.
// - Field (alan) tanımlanamaz, default implementasyon yoktur.
// - Bir sınıf birden fazla interface implement edebilir (çoklu inheritance için kullanılır).
// - Interface'i implement eden concrete class tüm üyeleri tanımlamak zorundadır.
// - Eğer eksik implementasyon varsa, sınıf abstract olarak işaretlenmelidir.
// - Genedle interface isimleri 'I' harfi ile başlar (örneğin: IComparable, IDisposable). Dosya adı ile aynı yazılır. ör :IShape.cs
using System;
using System.Collections.Generic;

// IPayable interface tanımı
public interface IPayable
{
    decimal GetPaymentAmount();
}

// Invoice sınıfı interface'i implement ediyor
public class Invoice : IPayable
{
    public string PartNumber { get; }
    public string PartDescription { get; }
    public int Quantity { get; }
    public decimal PricePerItem { get; }

    public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
    {
        PartNumber = partNumber;
        PartDescription = partDescription;
        Quantity = quantity;
        PricePerItem = pricePerItem;
    }

    public decimal GetPaymentAmount() => Quantity * PricePerItem;

    public override string ToString() =>
        $"invoice:\npart number: {PartNumber} ({PartDescription})\nquantity: {Quantity}\nprice per item: {PricePerItem:C}";
}

// Abstract Employee sınıfı
public abstract class EmployeeI : IPayable
{
    public string FirstName { get; }
    public string LastName { get; }
    public string SocialSecurityNumber { get; }

    public EmployeeI(string firstName, string lastName, string ssn)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = ssn;
    }

    public abstract decimal Earnings();

    public decimal GetPaymentAmount() => Earnings();

    public override string ToString() =>
        $"salaried employee: {FirstName} {LastName}\nsocial security number: {SocialSecurityNumber}";
}

// SalariedEmployee sınıfı
public class SalariedEmployeeI : EmployeeI
{
    public decimal WeeklySalary { get; }

    public SalariedEmployeeI(string firstName, string lastName, string ssn, decimal weeklySalary)
        : base(firstName, lastName, ssn)
    {
        WeeklySalary = weeklySalary;
    }

    public override decimal Earnings() => WeeklySalary;

    public override string ToString() =>
        base.ToString() + $"\nweekly salary: {WeeklySalary:C}";
}

// Test sınıfı
class PayableInterfaceTest
{
    public void test()
    {
        Console.WriteLine("Invoices and Employees processed polymorphically:\n");

        var payableObjects = new List<IPayable>() {
            new Invoice("01234", "seat", 2, 375.00M),
            new Invoice("56789", "tire", 4, 79.95M),
            new SalariedEmployeeI("John", "Smith", "111-11-1111", 800.00M),
            new SalariedEmployeeI("Lisa", "Barnes", "888-88-8888", 1200.00M)
        };

        foreach (var payable in payableObjects)
        {
            Console.WriteLine($"{payable}");
            Console.WriteLine($"payment due: {payable.GetPaymentAmount():C}\n");
        }
    }
}
