using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    
    
    public Entry(string date,string user_answer,string user_Prompt)
    {
        _entryText= user_answer;
        
        _promptText = user_Prompt;

        _date = date;
    }
    

    public void Display()
    {
        Console.WriteLine($"{_date},{_promptText}, {_entryText}");
        
    }

}