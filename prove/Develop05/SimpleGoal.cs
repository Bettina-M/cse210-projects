public class SimpleGoal : Goal
{

 private bool _isComplete;

 public bool iscomplete{get; set;}

public string checkbox;
public SimpleGoal(string name, string description,int  points) : base (name, description, points)
 {
      _isComplete = false;
 
 }

 public override int RecordEvent()
 {
      if(_isComplete)
      {
         _points += _points;
      }

      return _points;
 }

 public override bool IsComplete()
 {
    
   

   return _isComplete= true;

 }

 public override string GetStringRepresentation()
 { 
   string checkbox = _isComplete ? "[X]" : "[]";
   return $"Simple Goal,{_shortName},{_description},{_points},{checkbox}";
 }




}