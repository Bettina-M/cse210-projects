using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        List<Product> products1 = new List<Product>
        {
            new Product ("laptop", 1427,10, 5),
            new Product( "Glasses", 1090,100,2),
            new Product ("Shoes",900,25,10),
        };

         List<Product> products2 = new List<Product>
        {
            new Product ("Keyholder", 1274,20, 1),
            new Product( "Sufuria", 1090,20,10),
            new Product ("Pens",900,1,10),

        };

       
        Address address1 = new Address("12th Street","Kingston","Washington","USA");
        Customer customer1 = new Customer ("Mary LittleLamb",address1);

        

        Address address2 = new Address("Spine Road Kayole","Donholm","Nairobi","Kenya");
        Customer customer2 = new Customer ("Barack Obama",address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
    

        order1.PackingLabel();
        order1.ShippingLabel();

        foreach(var product in products1)
        {
            order1.AddProduct(product);
        }

        foreach (var product in products2)
        {
            order2.AddProduct(product);

        }


        Console.WriteLine("First Order");
        
        order1.PackingLabel();
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"The cost of this order is {order1.TotalCost()}");
        
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("-----------------------------------------------------------------------------");
        
        Console.WriteLine("2nd Order");
        
        order2.PackingLabel();
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine ($"The cost of this order is {order2.TotalCost()}"); 
        
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("-----------------------------------------------------------------------------");
        


    }
}