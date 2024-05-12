
using System.Security.Permissions;
using Microsoft.VisualBasic;

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
      
       if (IsHidden())
       { 
        return  new string  ('_', Text.Length);
       }
       else
       {
        return Text;

        
       }
    }
}


