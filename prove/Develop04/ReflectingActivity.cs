using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;


public class ReflectingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;
  
  
  public List<string> Prompts
  {
    get{return _prompts;}
    set{_prompts = value;}
  }
  public List<string> Questions
  {
    get{return _questions;}
    set{_questions = value;}
  }

  public  ReflectingActivity ()
  {
  
  _name = "Reflecting Activity";
  
  _description = @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
  
  Prompts = new List<string> ();
  
  Prompts =  
   ["Think of a time when you stood up for someone else.",
   "Think of a time when you did something really difficult.",
   "Think of a time when you helped someone in need.",
   "Think of a time when you did something truly selfless."];
    
  Questions = new List<string> ();
  
  Questions = [
  "Why was this experience meaningful to you?",
  "Have you ever done anything like this before?",
  "How did you get started?",
  "How did you feel when it was complete?",
  "What made this time different than other times when you were not as successful?",
  "What is your favorite thing about this experience?",
  "What could you learn from this experience that applies to other situations?",
  "What did you learn about yourself through this experience?",
  "How can you keep this experience in mind in the future?"]; 
  }

  public void Run ()
  {
    DisplayStartingMessage();
    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);

   do
   {
    DisplayPrompt();
    Thread.Sleep(5000);
    Console.Clear();
      
    DisplayQuestions();
    Thread.Sleep(5000);
    ShowSpinner(5);
    break;
        
   } while (DateTime.Now<stopTime);

    DisplayEndingMessage();
    
    ShowSpinner(5);

    Console.Clear();

 }

 public string GetRandomPrompt()
 {
       
  Random random = new Random ();
  var  randomIndex = random.Next(0,_prompts.Count);
  var randomPrompt = Prompts[randomIndex];

  return randomPrompt;
 }
 public string GetRandomQuestion()
  {
  
  Random random = new Random();
  int randomIndex = random.Next (0,_questions.Count);
  string randomQuestion = _questions [randomIndex];
  
  return randomQuestion;
        
 }

 public void DisplayPrompt()
 {
  Console.WriteLine (GetRandomPrompt());


 }

 public void DisplayQuestions()
 {
    string randomPrompt =  GetRandomPrompt();

    foreach (string question in _questions)
    {
      Console.WriteLine(question);
      //Thread.Sleep (5000);
      ShowSpinner(10);
      Console.Clear();
      Console.WriteLine(randomPrompt);
    }
  
 }

} 
