using System.Data.Common;
using System.Dynamic;

public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;
    

    public string Name 
    {
        get{ return _name;}
        set{_name = value;}
    }

    public int ProductId
    {
       get{return _id;}
       set{_id = value;}
    }
    public int Quantity 
    {
        get{return _quantity;}
        set{_quantity = value;}
    }
    public double Price
    {
    get{return _price;}
    set{_price = value;}
    }
    
    
    
    public Product(string name, int productId, double price,int quantity)
    {
        _name = name;
        _id = productId;
        _quantity = quantity;
        _price = price;

    }

    

    public double ProductCost()
    {
       return _price * _quantity;
       
    }

    public void ProductLabel()
    {
        Console.WriteLine($"Product Name:{_name}, Id:{_id}");
    }

}