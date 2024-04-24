using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        string letter = " ";

        
    
        if (grade>= 90)
        {
           letter = "A";
        }
        else if (grade>= 80)
        {
            letter = "B";
        }
        else if (grade>= 70)
        {
            letter = "C";
        }
        else if (grade>= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if ((grade % 10 >=7) && (letter!= "A") && (letter!="F"))
        {
            letter +=  "+";
        }
        else if ((grade % 10 <= 3) && (letter!= "F") && (letter!= "A"))
        {
            letter += "-";
        }
        
        Console.WriteLine($"Your grade is {letter}");
        
        if (grade>= 70)
            {

                Console.WriteLine("Congratulations you have passed");
            }
        else
            { Console.WriteLine("Sorry Do better next time");
                
            }
    }

}