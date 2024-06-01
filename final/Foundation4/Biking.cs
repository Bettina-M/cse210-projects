public class Biking: Activity
{
    private double _speed;

    public double Speed
    {
        get{return _speed;}
        set{_speed = value;}
    }

    public Biking ()
    {
        Speed= 100;
        Minutes = 25;
        Date = "05/05/2024";
        Activitytype = "Biking";
    }

    public override double GetDistance()
    {
        return Speed * Minutes/60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60/Speed;

    } 

    

}