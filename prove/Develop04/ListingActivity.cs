
using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    protected List <string> _userListing = new List<string> ();
    private string _userAnswer;

    public List <string> Prompts
    {
        get{return _prompts;}
        set{_prompts = value;}
    }

    public int Count
    {
        get{return _count;}
        set{_count= value;}
    }

    public string UserAnswer
    {
        get{return _userAnswer;}
        set{_userAnswer = value;}
    }
    
    public ListingActivity ()
    {
    _name = "Listing Activity";
    _description = @"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
    Prompts = new List<string>();
    Prompts = 
    [@"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
     "Who are some of your personal heroes?"];    
    }

    
    public void Run()
    {
    
    DisplayStartingMessage();
    Console.Clear();

    Console.WriteLine(GetRandomPrompt());
    Thread.Sleep (5000);
    
    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);

    do
    {
        GetListingFromUser();
    
    }while (DateTime.Now<stopTime);

    Console.Clear();
    
    int count =0;
    
    foreach(string entry in _userListing)
        {
            count ++;        
        }
    
    ShowSpinner(5);
    
    Console.WriteLine($"You have listed {count} items!");
    
    Thread.Sleep (2000);
    
    DisplayEndingMessage();

    ShowSpinner(5);

    Console.Clear();
    
    }

    
    public string GetRandomPrompt ()
    {
    
     Random random = new Random();
     int promptIndex = random.Next(0, Prompts.Count);
     string randomquiz = Prompts[promptIndex];

     return randomquiz;
    
    }


    public List<string> GetListingFromUser()
    {

    UserAnswer = Console.ReadLine();

    _userListing.Add(UserAnswer);

    return _userListing;
    
    }


}