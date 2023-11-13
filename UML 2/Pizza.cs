using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Pizza
{
    private double _prices;
    private string _ingredients;
    private string _topping;
    private string _pizzaName;
    private int _pizzaId;

    public Pizza() { PizzaName = "Magherita"; Prices = 60; Ingredients = "cheese and tomato"; Topping = "cheese"; PizzaId = 1; }

    public Pizza(string pizzaName, double prices, string ingredients, string topping, int pizzaId)
    {
        _pizzaName = pizzaName;
        _prices = prices;
        _ingredients = ingredients;
        _topping = topping;
        _pizzaId = pizzaId;
    }

    public double Prices
    {
        get { return _prices; }
        set { _prices = value; }
    }

    public string Ingredients
    {
        get { return _ingredients; }
        set { _ingredients = value; }
    }

    public string Topping
    {
        get { return _topping; }
        set { _topping = value; }
    }

    public string PizzaName
    {
        get { return _pizzaName; }
        set { _pizzaName = value; }
    }

    public int PizzaId
    {
        get { return _pizzaId; }
        set { _pizzaId= value; }
    }

    public override string ToString()
    {
        return $"Pizza name= {PizzaName}, Price= {Prices}, Ingredients= {Ingredients}, Topping= {Topping}, Pizza number= {PizzaId}.";
    }

}
