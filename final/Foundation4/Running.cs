public class Running : Activity
{
    private double _distance;

    public double Distance
    {
        get{return _distance;}
        set{_distance = value;}
    }

    public Running()
    {
        Distance = 100;
        Minutes = 25;
        Date = "12/06/2024";
        Activitytype = "Running";
    }

    public override double GetDistance()
    {
        return 100;
    }

    public override double GetSpeed()
    {
        return Distance/Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes/Distance;

    } 

    

}