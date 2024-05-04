using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
    static void Main(string[] args)
    {
        int menu; 
        Entry entry = null; //initalizing variables here enable me to use them in different methods in this file.
        
        Journal myJournal = new Journal();
        
        PromptGenerator getPrompts = new PromptGenerator();        
        
        do 
        {
        Console.WriteLine(@"Please Select one of the Following Choices: 
        1.Write
        2.Display
        3.Load
        4.Save
        5.Quit");
              
        menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            
            {                
                string user_prompt = getPrompts.GetRandomPrompt();
                
                Console.WriteLine(user_prompt); 
                
                string user_answer = Console.ReadLine(); 

                DateTime dateTime = DateTime.Now;
                string date = dateTime.ToShortDateString();

                entry = new Entry(date,user_answer, user_prompt);

                myJournal.AddEntry(entry);                

            }

            else if (menu ==2)
            
            {
                
                myJournal.DispayAll();        
            }

            else if (menu == 3)
            {
                Console.Write("Please Enter the file you'll want to read from: ");
                
                string userFile = Console.ReadLine();
                
                if (userFile== "Journal.txt")
                
                {                   
                    myJournal.LoadFromFile(userFile);

                }
            }

            else if (menu == 4)
            
            {
                Console.Write("In which file would you like to save today's entry?  ");
                
                string userFile = Console.ReadLine();
                
                if (userFile== "Journal.txt")

                {
                    if (entry != null)

                    
                    
                    myJournal.SaveToFile(userFile);
                }
            }

            else
            {
                Console.WriteLine ("Goodbye");
            }

        } while (menu != 5);

    }
}