using System.ComponentModel;

public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) : base (name, description, points)
  {
   
 
  }

  public override int RecordEvent()
  {
      if (!IsComplete())
      {
         _points ++;
      }

      return _points;
  
  }

 public override bool IsComplete()
 {
    return false;
 }

 public override string GetStringRepresentation()

 {
   return $"Eternal Goal,{_name},{_description},{_points}";
 }


}