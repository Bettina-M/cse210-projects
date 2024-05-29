
using System.ComponentModel.Design;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;
using System.Runtime;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private  int _score;

    public int Score { get; set; }

    public List<Goal> Goals
    {
        get { return _goals; }
        set { _goals = value; }
    }

    public GoalManager()
    {
       _goals = new List<Goal>();
       _score = 0;

    }
    public void Start()
   {
        DisplayPlayerInfo();
        while (true)
        {
            
            Console.WriteLine("Menu Options ");
            Console. WriteLine("1.Create New Goal ");
            Console. WriteLine("2.List Goals ");
            Console. WriteLine("3.Save Goals ");
            Console. WriteLine("4.Load Goals ");
            Console. WriteLine("5.Record Event ");
            Console. WriteLine("6.Quit ");
            Console.Write("Select a choice from the menu: ");
            string Choice = Console.ReadLine();

            
            
            if (Choice == "1")
            {
                CreateGoal();
            }

            else if (Choice == "2")
            {
                ListGoalNames();
            }

            else if (Choice == "3")
            {
                SaveGoals();
            }

            else if (Choice == "4")
            {
                LoadGoals();
            }

            else if (Choice == "5")
            {
                RecordEvent();
            }

            else if (Choice == "6")
            {
                Console.WriteLine("You've exited the program, Goodbye!");
                break;
            }
            
        }
    }

   public void AddGoal(Goal goal)
   {
        _goals.Add(goal);
        


   }

    public void DisplayPlayerInfo()
    {
       
        Console.WriteLine($"You have {_score}");
            
    }

    public void ListGoalNames() 
    {
        foreach (var goal in _goals)
        {
           Console.WriteLine(goal);
        }
    }

    public void CreateGoal( )
    {
        
        
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine ("1.Simple Goal");
        Console.WriteLine("2.Checklist Goal");
        Console.WriteLine("3.Eternal Goal");
        
        string choice = Console.ReadLine();
        Console.WriteLine("What is the name of the goal?" );
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("How many points do you want associated with your goal?");
        int points = int.Parse(Console.ReadLine());
        
        

        Goal goal= null;

        if (choice == "Simple Goal")
        {
            goal = new SimpleGoal (name, description, points);
        
        }
        else if (choice == "CheckListGoal ")
        {
            Console.WriteLine("Enter the completions for your goal");
            
            int target= int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the amount you've completed so far? ");
            
            int amountCompleted = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the bonus for this goal: ");
            
            int bonus = int.Parse(Console.ReadLine());
            
            goal = new ChecklistGoal (name, description, points, target, amountCompleted, bonus);
        }
        else if (choice == "Eternal Goal")
        {
            goal = new EternalGoal (name, description, points);
        }

        AddGoal(goal);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        
        Console.Write("Which goal have you completed? ");
        string name = Console.ReadLine();
        
        foreach (var goal in _goals)
        {
            if (name== goal.Name)
            {
                goal.RecordEvent();

                _score+= int.Parse(goal.Points);
            }
        }

        Console.WriteLine($"You have a total of {_score} points");
    }

    public void SaveGoals()
    {
        Console.Write("Ín which file would you want to save your goals? " );

        var filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            
    
            foreach (var goal in _goals)
            {
                if (goal!= null)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            }
        }
    }

    public void LoadGoals()
    {
    
    Goal goal = null;
    Console.WriteLine("From which file will you like to read your goals");
    string file = Console.ReadLine();
    string [] lines = System.IO.File.ReadAllLines(file);

    foreach (var line in lines)
    {
        string [] parts = line.Split(",");

        string goalName  = parts[0];
        string name = parts [1];
        string description = parts[2];
        int  points = int.Parse(parts[3]);
        string checkbox = parts [4];

        if (name == "Simple Goal")
        {
            goal = new SimpleGoal ( name, description, points);

           
        }
        else if (name == "Eternal Goal")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (name == "Checklist Goal")
        {
            int target = int.Parse(parts [5]);
            int AmountCompleted = int.Parse(parts[6]);
            int bonus = int.Parse(parts[7]);
            
            goal = new ChecklistGoal(name, description, points, target,AmountCompleted, bonus);


        }


         _goals.Add(goal);

         Console.WriteLine($"{name}, {description}, {points}, {checkbox}");

    }
    
    }




}