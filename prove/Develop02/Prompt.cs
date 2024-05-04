using System;
using System.Collections.Generic;


public class PromptGenerator
{
   public List<string> _promptsList  = new List<string> (); 
   
   public string GetRandomPrompt()
   
   {
    _promptsList.Add("What am I most proud of today? ");
    _promptsList.Add("What would I change about today? ");
    _promptsList.Add("What lessons did I learn today? ");
    _promptsList.Add("What was the most interesting thing I saw today? ");
    _promptsList.Add("What was the most fun thing I did today? ");
    
    Random random = new Random();
   
    int RandomPrompt = random.Next (0,_promptsList.Count);  //since my list is in form of strings, i have use count to give a number of the index of strings.
     
    return (_promptsList[RandomPrompt]);    

   }

}
