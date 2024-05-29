using System.ComponentModel;

public abstract class Goal
{

 protected string _shortName;
 protected string _description;
 protected  int _points;

public string Name { get; set;}
public string Description {get; set;}
public string Points {get;set;}
 public Goal(string name, string description, int points)
 {
    _shortName = name;
    _description = description;
    _points = points;

 }

 public abstract int RecordEvent();
 

 public abstract bool IsComplete();
 

 public string GetDetailsString()
 {
   
   return $"Goal,{_shortName},{_description},{_points}";

 }


 public abstract string GetStringRepresentation();
 




}