using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        DisplayResult();
        
        


    }
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static  string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
            
        
        }
        
        static int SquareNumber ( )
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            int SquareNumber = number * number ;
            return SquareNumber;
        }
        static void DisplayResult ()
        {
            string UserName = PromptUserName();
            int favNumber = SquareNumber();
            
             Console.WriteLine ($"{UserName},the square of your number is {favNumber}");
            
        }
    
    
}