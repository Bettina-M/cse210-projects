using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        
        
        
        Assignment myobj1 = new Assignment("Bettina", "Algebra");

        Console.WriteLine (myobj1.GetSummary());

        MathAssignment myobj2 = new MathAssignment ("Bettina", "Algebra", "Section 7.3", "Problems 8-19");

        Console.WriteLine(myobj2.GetSummary());
        Console.WriteLine(myobj2.GetHomeWorkList());
        
        WritingAssignment myobj3 = new WritingAssignment ("Bettina", "African History", "Our beautiful continent");
        
        Console.WriteLine(myobj3.GetSummary());
        Console.WriteLine(myobj3.GetWritingInformation());
        
        
       

        
    }
}