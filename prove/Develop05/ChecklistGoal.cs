using System.Runtime;
using System.Threading.Channels;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public string checkbox;

    public int AmountCompleted {get; set;}
    public int Target{ get; set;}
    public int Bonus {get;set;}

    public ChecklistGoal(string name, string description, int points, int target, int amountCompleted, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        ;
    

        
    }

    public override int RecordEvent()

    {

        _amountCompleted = 0;
        _bonus = 500;


        if (!IsComplete())
        {
            AmountCompleted ++;
            if (AmountCompleted>= Target && IsComplete())
            {
                _points += _bonus;

                checkbox = "[X]";
            }
        }
        

        return _points;
    }

    public override bool IsComplete()
    {
        return true;
    }
    public new string GetDetailsString ()
    {
        return $"CheckList Goal,{_shortName},{_description},{_points},{_target}/{_amountCompleted},{_bonus}";

    }
    

    public override string GetStringRepresentation()
    {
        
        string checkbox = IsComplete() ? "[X]" : "[]";
        return $"CheckList Goal,{_shortName},{_description},{_points},{_target}/{_amountCompleted},{_bonus},{checkbox}";


    }

}