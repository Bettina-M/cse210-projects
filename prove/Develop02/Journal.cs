using System;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Microsoft.VisualBasic;

public class Journal
{
    public List <Entry> _entries = new List <Entry>();

        public void AddEntry (Entry newEntry)

        {
            _entries.Add(newEntry);
        
        }
        public void DispayAll ()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                
                //Console.WriteLine();
            }
        }

        public void SaveToFile (string file)
        {
            
           using (StreamWriter newfile = new StreamWriter (file))
            
            {
                foreach (Entry entry in _entries)
                {
                    newfile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
                    
                }
            }

        }

        public void LoadFromFile (string file)
        {
            
            string [] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
               string [] parts = line.Split(",");

               string date  = parts[0];
               string prompt = parts[1];
               string entryText = parts[2];

               Entry newEntry = new Entry(date,prompt, entryText);

              _entries.Add(newEntry);

              Console.WriteLine($"{date}, {prompt},{entryText}");
            }
        }

}
