 
 
 using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
public class Scripture
{

  private Reference  _reference;
  private  List <Word> _Words;

  public Reference Reference
  {
    get {return _reference;}
    set {_reference = value;}
  }
  public List<Word> Words
  {
    get{return _Words;}
    set{_Words = value;}
  }

   public  Scripture ( Reference Reference, string text)
  {
    _reference = Reference; 

    Words = new List<Word>();

    string [] wordList = text.Split(" ");
    
    foreach (string wordText in wordList)
    {
      Word word = new Word(wordText);
      
      _Words.Add(word);

    }

  }

  public void HideRandomWords (int numberToHide)
  {
    //hide words and the number to hide

    Random random = new Random();
    
    
    int hiddenIndex = random.Next(Words.Count);
    Words[hiddenIndex].Hide();
    


  }
 
 public string GetDisplayText()
 {
   string newText = string.Join("_",Words);
   
    string newScriptureText = $"{Reference.GetDisplayText()} {newText}";
   
    return newScriptureText;

    

 }

  public bool IsCompletelyHidden()
  {
       foreach (Word word in Words)
       {
        if (word.IsHidden())
        {
          return false;
        }
       }
      return true;
  }
} 