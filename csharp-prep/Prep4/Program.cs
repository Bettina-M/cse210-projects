using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        int userNumber = -1;
        List <int> numList = new List<int>();
        
        while (userNumber!=0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            if (userNumber!=0)
            {            
             
             numList.Add(userNumber);
             
            
            }        
        }

        int sum = 0;
        int max = numList[0];
        int min = numList[0];
        
         

        foreach (int x in numList)
        {
            sum += x;
            if (x>max)
            {
                max = x;
            }

            if (x<min)
            {
                min = x;
            }
        
        }
        int average = sum / numList.Count;
              
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The minimum number is: {min}");
        Console.WriteLine($"The maximum number is: {max}");
        Console.WriteLine($"The average is: {average}");
        
    }
}