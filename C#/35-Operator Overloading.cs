using System;

public struct ComplexNumber
{
    // operatorler public ve static olmalı
    //  Salt okunur özellikler: Gerçek ve sanal kısımlar
    public double Real { get; }
    public double Imaginary { get; }

    // 🏗Yapıcı metot (constructor)
    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    //  Karmaşık sayıyı string olarak döndürür
    public override string ToString() =>
        $"{Real} {(Imaginary < 0 ? "–" : "+")} {Math.Abs(Imaginary)}i";

    // Toplama operatörü aşırı yükleme
    public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
    {
        return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
    }

    //  Çıkarma operatörü aşırı yükleme
    public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
    {
        return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
    }

    //  Çarpma operatörü aşırı yükleme
    public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
    {
        return new ComplexNumber(
            x.Real * y.Real - x.Imaginary * y.Imaginary,
            x.Real * y.Imaginary + y.Real * x.Imaginary
        );
    }
}
// ComplexNumber.operator+(c1, c2);
