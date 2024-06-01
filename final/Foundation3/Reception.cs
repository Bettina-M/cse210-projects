using System.IO.Pipes;

public class Reception :Event
{
    private string _email;
    public string Email
    {
        get{return _email;}
        set{_email = value;}
    }

    public Reception()
    {
        Title = "Annual General Meeting";
        Description = "Join us for a celebration of our collective achievements.";
        Date = "10/6/2024";
        Time = "10:00Am - 5:00Pm";
        Eventtype = "Company Reception";
        Email="abc@company.com";

        Address.Street = "201 Bellevue Square";
        Address.City = "Corporate Town";
        Address.State = "Mombasa";
        Address.Country = "Kenya";
    }

    public void DisplayReception()
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Event 3");
        Console.WriteLine(GetShortDetails());
        Console.WriteLine("=====================");
        Console.WriteLine(GetStandardDetails());
        Console.WriteLine("======================================================");
        Console.WriteLine (GetFullDetails());
        Console.WriteLine($"To confirm your attendance, please RSVP by emailing us at {Email}.");
    }
    



}