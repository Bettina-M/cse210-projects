using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        
        job1._jobTitle = "Customer Service Rep";
        job1._company = "Ninja Partners";
        job1._startYear = 2019;
        job1._endYear = 2030;

        Job job2 = new Job ();
        job2._jobTitle = "Microbiologist";
        job2._company = "Kemri";
        job2._startYear = 2018;
        job2._endYear = 2018;

       
        
        Resume resume = new Resume();

        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);

        resume.DisplayResume();
    }
}