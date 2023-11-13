using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    private bool _eatIN;
    private string _orderStatus;
    public static int _nextOrderNumber = 1;
    private int _orderNumber;
    private double _price;

    public Order(bool eatIN, string orderStatus, double price)
    {
        _eatIN = true;
        _orderStatus = orderStatus;
        _orderNumber = _nextOrderNumber++;
        _price = price;
    }

    public bool EatIN
    {
        get { return _eatIN; }
        set { _eatIN = value; }
    }

    public string OrderStatus
    {
        get { return _orderStatus; }
        set { _orderStatus = value; }
    }

    public int OrderNumber
    {
        get { return _orderNumber; }
        set { _orderNumber = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public double GetPriceEatOut()
    {
        return Price * 1.25 + 40;
    }

    public double GetPriceEatIn()
    {
        return Price * 1.25;
    }

    public override string ToString()
    {
        return $"Is the costumer going to eat In?= {EatIN}, Order status= {OrderStatus}, Order number= {OrderNumber}";
    }
}
