using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;



public class Order
{
    private List<Product>_products;
    private Customer _customer;

    public Customer Customer {get;set;}

    public List<Product> Products
    {
        get{return _products;}
        set{ _products = value;}

    }

    public Order(Customer customer)
    {
        _products = new List<Product>();
       
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    
    public void  PackingLabel()
    {
        foreach(var product  in _products)
        {
           product.ProductLabel();
        
        }
    }

    public string ShippingLabel()
    {
       
       return _customer.CustomerDetails();
    }

    public double TotalCost()
    {

        double sum = 0;
            
        foreach (var product in _products)
        {
           
            sum +=product.ProductCost();
        }  
        if (_customer.Address.Country!= "USA")
        {
            sum +=35;
        }
        

        return sum;
        
    }

}
    
    