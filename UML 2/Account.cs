using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Account
{
    public string Name { get; set; }
    protected int Age { get; set; }
    protected int PhoneNumber { get; set; }

    public Account() { Name = "Lotte"; Age = 44; PhoneNumber = 14151312; }

    public Account(string name, int age, int phoneNumber)
    {
        Name = name;
        Age = age;
        PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return "Name= " + Name + ",Age= " + Age + ",Phone number= " + PhoneNumber;
    }
}
