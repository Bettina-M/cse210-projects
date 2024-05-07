using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction myFraction1 = new Fraction();

        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction1.GetDecimalValue());

        Fraction myFraction2 = new Fraction(5);

        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());

        Fraction myFraction3 = new Fraction(10,20);

        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetDecimalValue());

        Fraction myFraction4 = new Fraction(1,2);

        Console.WriteLine(myFraction4.GetFractionString());
        Console.WriteLine(myFraction4.GetDecimalValue());
    


    }
}