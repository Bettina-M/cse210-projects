using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Excercise Tracking");
        Running myobj1 = new Running();
        Swimming myobj2 = new Swimming();
        Biking myobj3 = new Biking();

        List <Activity> activities = new List<Activity>();

        activities.Add(myobj1);
        activities.Add(myobj2);
        activities.Add(myobj3);

        foreach (var item in activities)
        {
            Console.WriteLine(item.GetActivitySummary());
        }
    }
}