using System;
using System.Formats.Asn1;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random ();
        int magicNumber = randomGenerator.Next(1,100);
        
        int guessNumber = -1;
        
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
        

            if (guessNumber<magicNumber)
            {    
                Console.WriteLine("Guess Higher");
               
                
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Guess Lower");
                
            }
            else
            {
                Console.WriteLine("You Guessed It!");
                              
            }
            
        
        }
        
    }
}