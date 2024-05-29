using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        GoalManager goalManager = new GoalManager();

        goalManager.Start();
        
    }
}