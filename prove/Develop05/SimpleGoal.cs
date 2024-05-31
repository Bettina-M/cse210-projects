public class SimpleGoal : Goal
{

 private bool _isComplete;

    public bool IsCompleteStatus
    {
        get { return _isComplete; }
        set { _isComplete = value; }
    }
public string checkbox;
public SimpleGoal(string name, string description,int  points) : base (name, description, points)
 {
      _isComplete = false;
 
 }

 public override int RecordEvent()
 {
      if(!_isComplete)
      {
        _points += _points;
        _isComplete = true;

      }

      return _points;
 }

 public override bool IsComplete()
 {
    
   

   return _isComplete;

 }

 public override string GetStringRepresentation()
 { 
   string checkbox = _isComplete ? "[X]" : "[]";
   return $"Simple Goal,{_name},{_description},{_points},{checkbox}";
 }




}