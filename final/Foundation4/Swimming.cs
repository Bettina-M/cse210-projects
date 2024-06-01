public class Swimming: Activity
{
    private int _laps;

    public int Laps
    {
        get{return _laps;}
        set{_laps = value;}
    }

    public Swimming ()
    {
        Laps = 100;
        Minutes = 100;
        Date = "10/05/2024";
        Activitytype = "Swimming";
    }

    public override double GetDistance()
    {
        double distance =Laps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        return GetDistance()/ Minutes * 60;
    }

    public override double GetPace()
    {
        double pace =Minutes/GetDistance();
        return pace;
    } 

    

}