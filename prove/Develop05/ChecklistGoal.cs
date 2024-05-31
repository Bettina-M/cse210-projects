using System.Runtime;
using System.Threading.Channels;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public string checkbox;

    public int AmountCompleted
    {
        get{return _amountCompleted;}
        set{_amountCompleted = value;}
   
    } 
    public int Target
    {
        get{return _target;}
        set{_target = value;}
    }
    public int Bonus
    {
        get{return _bonus;}
        set{_bonus = value;}
    }

    public ChecklistGoal(string name, string description, int points, int target, int amountCompleted, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    

        
    }

    public override int RecordEvent()

    {

        if (!IsComplete())
        {
            AmountCompleted ++;
            if (AmountCompleted>= Target && IsComplete())
            {
                _points += _bonus;

            }
        }
        

        return _points;
    }

    public override bool IsComplete()
    {

        return AmountCompleted >= Target;
    }
   public new string GetDetailsString ()
    {
        return $"CheckList Goal,{_name},{_description},{_points},{_amountCompleted}/{_target},{_bonus}";

    }
    

    public override string GetStringRepresentation()
    {
        
        string checkbox = IsComplete() ? "[X]" : "[]";
        return $"CheckList Goal,{_name},{_description},{_points},{_target}/{_amountCompleted},{_bonus},{checkbox}";


    }

}