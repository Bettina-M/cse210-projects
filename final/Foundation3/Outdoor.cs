public class Outdoor :Event
{
    private string _weather;

    public String Weather
    {
        get{return _weather;}
        set{_weather = value;}
    }
    public Outdoor()
    {
        Title = "Kids Festival";
        Description = "Fun Play for all Children";
        Date = "10/6/2024";
        Time = "10:00Am - 5:00Pm";
        Eventtype = "Festival";
        Weather = "Expect to have fun all day under the Sunny weather ";

        Address.Street = "3750 Wailea Drive";
        Address.City = "Carnival City";
        Address.State = "Nairobi";
        Address.Country = "Kenya";
    }

    public void DisplayOutdoor()
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Event 2");
        Console.WriteLine(GetShortDetails());
        Console.WriteLine("=====================");
        Console.WriteLine(GetStandardDetails());
        Console.WriteLine("======================================================");
        Console.WriteLine (GetFullDetails());
        Console.WriteLine(Weather);
    }
}