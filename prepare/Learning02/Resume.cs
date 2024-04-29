using System.Collections.Generic;
using System.ComponentModel;

public class Resume
{

    public string _name = " ";
    public List<Job> Jobs = new List<Job> ();

        public void DisplayResume()
        {
            string name = "Bettina Achieng Menya";
            Console.WriteLine ($"Name: {name}");
            Console.WriteLine ($"Jobs:");
            
            foreach ( var job in Jobs)

            {
                job.DisplayJobDetails();
                
            
            }
        }
}