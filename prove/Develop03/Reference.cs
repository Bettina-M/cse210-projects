public class Reference
{
   private string _book;
   private int _chapter;
   private int _verse;
   private int _endVerse;

// used auto-implemented properties directly below member variables to reduce repeating codes

    public string Book 
    {
        get{return _book;}
        set{_book = value;}
    }
    public int Chapter 
    {
        get{return _chapter;}
        set{_chapter = value;}
    }
    public int Verse 
    {
        get{return _verse;}
        set{_verse = value;}
    }
    public int EndVerse 
    {
        get{return _endVerse;}
        set{_endVerse = value;}
    }


 public Reference(string book, int chapter, int verse)//scripture verse will be stored in variables in this method
    {
        Book = book;
        
        Chapter = chapter;

        Verse = verse;
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse)//this is for scripture with multiple verses
    {
        Book = book;
        
        Chapter = chapter;
        
        EndVerse = endVerse;

    }

    public string GetDisplayText() 
    {
        string displayText = $"{Book} {Chapter}:{Verse}";

        return displayText;
    }

    
}