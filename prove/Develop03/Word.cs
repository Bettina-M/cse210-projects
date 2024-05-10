
using System.Security.Permissions;

public class Word
{
   private string _text;
   private bool _isHidden;

    public string Text 
    {
        get{ return _text;}
        set{_text = value;}
        
    }


    public Word(string text)
    {
        _text = text; 
        _isHidden = false;
    }

    public void  Hide()
    {
       _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {


        return _isHidden;
    }

    public string GetDisplayText()
    {
      return _text;
    }
}


