using System.ComponentModel;

public abstract class Goal
{

 protected string _name;
 protected string _description;
 protected  int _points;


public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }
 public Goal(string name, string description, int points)
 {
    _name = name;
    _description = description;
    _points = points;
   Name = name;
   Description = description;
   Points = points;
  }

 

 public abstract int RecordEvent();
 

 public abstract bool IsComplete();
 

 public string GetDetailsString()
 {
   
   return $"Goal,{_name},{_description},{_points}";

 }


 public abstract string GetStringRepresentation();
 




}