using System;

public class Activity
{
 protected string _name;
 protected string _description;
 protected int _duration;



public  Activity ()
{
   _name = "";

   _description = "";

   _duration = 0;
}

public void  DisplayStartingMessage()
{
    Console.Clear();
    Console.WriteLine ($"Welcome to the {_name}.");
    Console.WriteLine ( _description);
    Thread.Sleep(10000);
    Console.Clear();
    Console.Write("Select the duration (seconds) you would like for your session: ");
    _duration = int.Parse(Console.ReadLine());
    
}

public void DisplayEndingMessage()
{
    Console.WriteLine("Well done!");
    Console.WriteLine($"You have completed another {_duration} seconds of {_name}!");

}

public void ShowSpinner(int seconds)
{

    int i =0;
    do{ 
    Console.Write ("-");
    Thread.Sleep(1000);

    Console.Write("\b \b");
    Console.Write(" ");
    
    i++;
    }
    while (i<= seconds); 

}

public void ShowCountDown(int seconds)
{
 for (int i=1; i<=seconds; i++)
    {
        Console.WriteLine (i);
    
        Thread.Sleep(1000);
        Console.Clear();
    }

}

}