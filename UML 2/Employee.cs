using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Employee : Account
{
    public bool ConfirmOrder { get; set; }

    public Employee() { Name = "Søren"; Age = 34; PhoneNumber = 32456476; ConfirmOrder = true; }

    public Employee(string name, int age, int phoneNumber, bool confirmOrder) : base(name, age, phoneNumber)
    {
        ConfirmOrder = confirmOrder;
    }

    public override string ToString()
    {
        return $"Name= {Name}, Age= {Age}, Phone number= {PhoneNumber}, Confirmed the order?= {ConfirmOrder}.";
    }
}
