
using System.Net;
using System.Xml.Linq;

#region Costumer List
Costumer costumer1 = new Costumer();
Costumer costumer2 = new Costumer("Michael", 45, 23242526, true);
Costumer costumer3 = new Costumer("Lis", 55, 82764536, true);

CostumerFile.AddCostumer(costumer1);
CostumerFile.AddCostumer(costumer2);
CostumerFile.AddCostumer(costumer3);
CostumerFile.AddCostumer(new Costumer("Bo", 78, 6543568, true));
#endregion

#region Print all Costumers
Console.WriteLine("List of all costumers:");
List<Costumer> costumers = CostumerFile.GetCostumer();

foreach (Costumer printAllCostumers in CostumerFile.GetCostumer())
{
    Console.WriteLine(printAllCostumers);
}
Console.WriteLine();
#endregion

#region Remove costumer by name
CostumerFile.RemoveCostumerByName("Michael");

Console.WriteLine();
Console.WriteLine("List of costumers after I removed Michael:");

foreach (Costumer printAllCostumers in CostumerFile.GetCostumer())
{
    Console.WriteLine(printAllCostumers);
}

Console.WriteLine();
#endregion

#region Search for a costumer by name
Console.WriteLine( );
Console.WriteLine("Search for a costumer called Lis:");
Console.WriteLine(CostumerFile.SearchCostumerbyName("Lis"));

Console.WriteLine();
#endregion

#region Update costumer
Console.WriteLine();
Console.WriteLine("Updating costumer 2's phone number:");
Console.WriteLine(costumer2);

costumer2 = new Costumer("Michael",45,99999999, true);
Console.WriteLine(costumer2);

Console.WriteLine();
#endregion

#region List of Pizzas
Console.WriteLine();
Pizza pizza1 = new Pizza();
Pizza pizza2 = new Pizza("Hawaii", 65, "ham and pineapple", "cheese", 2);
Pizza pizza3 = new Pizza("Potato pizza", 70, "potato and oregano", "Cheese", 3);

PizzaMenu pizzaMenu = new PizzaMenu();

pizzaMenu.AddPizza(pizza1);
pizzaMenu.AddPizza(pizza2);
pizzaMenu.AddPizza(pizza3);
pizzaMenu.AddPizza(new Pizza("SaladPizza", 65, "salad and chicken", "Cheese", 4));
#endregion

#region Print all Pizzas
List<Pizza> pizzas = pizzaMenu.GetPizza();

Console.WriteLine("List of all pizzas:");

foreach (Pizza printAllPizzas in pizzaMenu.GetPizza())
{
    Console.WriteLine(printAllPizzas);
}
Console.WriteLine();
#endregion

#region Remove Pizza by ID
pizzaMenu.RemovePizza(2);

Console.WriteLine();
Console.WriteLine("List of all pizzas after I removed the one with ID = 2");

foreach (Pizza printAllPizzas in pizzaMenu.GetPizza())
{
    Console.WriteLine(printAllPizzas);
}

Console.WriteLine();
#endregion

#region Search for a pizza by ID
Console.WriteLine();
Console.WriteLine("Search for a pizza with the ID = 4");

Console.WriteLine(pizzaMenu.SearchPizza(4));

#endregion

#region Update Pizza
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Updating pizza number 3's topping");
Console.WriteLine(pizza3);
pizza3 = new Pizza("Potato pizza", 70, "potato and oregano", "Tomato", 3);
Console.WriteLine(pizza3);
#endregion

#region Orders
Console.WriteLine();
Console.WriteLine();
Order order1 = new Order(false, "ongoing", 80);
Order order2 = new Order(true, "ongoing", 90);
Order order3 = new Order(false, "ongoing", 60);

Console.WriteLine($"{order1}, Total price= {order1.GetPriceEatOut()}");
Console.WriteLine($"{order2}, Total price= {order2.GetPriceEatIn()}");
Console.WriteLine($"{order3}, Total price= {order3.GetPriceEatOut()}");
#endregion
