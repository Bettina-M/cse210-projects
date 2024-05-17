using System;
using System.ComponentModel.Design;

class Program
{
    
    static void Main(string[] args)
    {
        var userMenu = "";

        do 
        {
            Console.WriteLine("Welcome to the mindfulness program!");
            Console.WriteLine("Select an Activity:");
            Console.WriteLine("1.Start Breathing Activity");
            Console.WriteLine("2.Start Reflecting Activity");
            Console.WriteLine("3.Start Listing Activity");
            Console.WriteLine("4.Quit");

            userMenu = (Console.ReadLine());
            
            if( userMenu == "1")
            {
                BreathingActivity mybreathingActivity = new BreathingActivity();
                mybreathingActivity.Run();

            }

            else if (userMenu == "2")
            {
                ReflectingActivity myreflectingActivity = new ReflectingActivity();
                myreflectingActivity.Run();
            }

            else if (userMenu == "3")
            {
                ListingActivity myListingActivity = new ListingActivity ();
                myListingActivity.Run();

            }

            else if (userMenu == "4")

            {
                Console.WriteLine ("You've exit the program goodbye!");
            }

        } while (userMenu != "4");




    }
}