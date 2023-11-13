using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Costumer : Account
{
    public bool CreateOrder { get; set; }

    public Costumer() { Name = "Jonas"; Age = 32; PhoneNumber = 27262826; CreateOrder = true; }

    public Costumer(string name, int age, int phoneNumber, bool createOrder) : base(name, age, phoneNumber)
    {
        CreateOrder = createOrder;
    }

    public override string ToString()
    {
        return "Name= " + Name + ", Age= " + Age + ", Phone number= " + PhoneNumber + ", Created order?= " + CreateOrder;
    }
}
