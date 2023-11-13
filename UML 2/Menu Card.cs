using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Menu_Card
{
    public string Items { get; set; }

    public Menu_Card() { Items = "Items"; }
    public Menu_Card(string items)
    {
        Items = items;
    }

    public override string ToString()
    {
        return $"Items= {Items}";
    }
}
