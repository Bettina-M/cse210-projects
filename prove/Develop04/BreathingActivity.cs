
using System.ComponentModel.DataAnnotations;

public class BreathingActivity : Activity
{

public BreathingActivity()
{
   _name = "Breathing Activity!";

   _description = @"This activity will help you relax by walking you through your breathing in and out slowly. 
   Clear your mind and focus on your breathing";

}


public void Run()
{
    DisplayStartingMessage();

    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);

do{
    Console.Clear();
    Console.WriteLine("Breath In...");
    ShowCountDown(5);
    Console.Clear();
    
    Console.WriteLine("Breathe Out...");
    ShowCountDown(5);
    Console.Clear();

} while (DateTime.Now < stopTime);

    DisplayEndingMessage();
    ShowSpinner(5);
    Console.Clear();

}

}