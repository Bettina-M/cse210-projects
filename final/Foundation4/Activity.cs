public abstract class Activity
{
    private string _date;
    private double _minutes;
    private string _activitytype;

    public string Date
    { 
        get{return _date;}
        set{_date = value;}
    }

    public double Minutes
    {
        get{return _minutes;}
        set{_minutes = value;}
    }
    public string Activitytype
    {
        get{return _activitytype;}
        set{_activitytype = value;}
    }

    public Activity()
    {
        Date = "";
        Minutes = 0;
    }

    

    public  string GetActivitySummary()
    {
        return $"{Date} {Activitytype} ({Minutes} min)-Distance {GetDistance()} Km, Speed {GetSpeed()} kph, Pace {GetPace()}:min per Km";
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();





}