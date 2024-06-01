using System.ComponentModel.DataAnnotations;

public class Lecture: Event
{
    private string _speaker;
    private string _capacity;

    public string Speaker
    {
        get { return _speaker; }
        set { _speaker = value; }
    }

    public string Capacity
    {
        get { return _capacity; }
        set { _capacity = value; }
    }
    public Lecture ()
    {
        Title = "Programming with Classes";
        Description = "Exploring The Four Principles of Object Programming";
        Speaker = "Bettina M.";
        Date = "10/6/2024";
        Time = "11:00Am - 12:00Pm";
        Capacity = "200";
        Eventtype = "Public Lecture";

        Address.Street = "854 Avocado Ave";
        Address.City = "Los Angeles";
        Address.State = "California";
        Address.Country = "Kenya";

    }

    public void DisplayLecture()
    {
        Console.WriteLine("Event 1");
        Console.WriteLine("");
        Console.WriteLine(GetShortDetails());
        Console.WriteLine("=====================");
        Console.WriteLine(GetStandardDetails());
        Console.WriteLine("======================================================");
        Console.WriteLine($"{GetFullDetails()}\nThe speaker for the event will be {Speaker}\n{Capacity} attendess expected.");  
        
    }




}