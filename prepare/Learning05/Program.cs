using System;
using System.Data.SqlTypes;
using System.Globalization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

       
       List <Shape> shapes = new List<Shape> ();

       shapes.Add(new Square("Red", 20.00));
       shapes.Add(new Rectangle("blue", 15.20, 13.40));
       shapes.Add(new Circle("pink", 14.4));

       foreach(Shape newshape in shapes)
       {
         string mycolor = newshape.GetColor();
         double myarea = newshape.GetArea();

         Console.WriteLine($"The {mycolor} shape has an area of {myarea}");

       }
    }
}