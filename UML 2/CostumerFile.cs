using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class CostumerFile : Costumer
{
    private static List<Costumer> costumers = new List<Costumer>();

    public static void AddCostumer(Costumer costumer)
    {
        costumers.Add(costumer);
    }

    public static void AddCostumer(string name, int age, int phoneNumber, bool createOrder)
    {
        costumers.Add(new Costumer(name, age, phoneNumber, createOrder));
    }

    public static Costumer RemoveCostumerByName(string name)
    {
        foreach (Costumer costumer in costumers)
        {
            if (costumer.Name == name)
            {
                costumers.Remove(costumer);
                return costumer;
            }
        }

        return null;
    }

    public static List<Costumer> GetCostumer()
    {
        return costumers;
    }

    public static Costumer SearchCostumerbyName(string name)
    {
        foreach (Costumer costumer in costumers)
        {
            if (costumer.Name == name) return costumer;
        }

        return null;
    }

}
