using System;
using System.Formats.Asn1;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        

        var scriptureVerse = "Trust in the LORD with all thine heart; and lean not unto thine own understanding ";
        
        Reference myreference = new Reference ("Proverbs",3,5);
        
        Scripture myScripture = new  Scripture (myreference,scriptureVerse );
        
        Console.WriteLine(myScripture.GetDisplayText());
        
        Console.WriteLine ("Press enter to hide a word or Quit to exit");

       
        while (true)
        {

            if (Console.ReadLine() == "Quit")
            break;
            
            Console.Clear();
            
            myScripture.HideRandomWords(1);
            Console.WriteLine(myScripture.GetDisplayText());

            if (myScripture.IsCompletelyHidden())
            {

                Console.WriteLine ("You've finished memorizing scripture");
                    break;       
            }

            
        }
         

                 

        
    }
}