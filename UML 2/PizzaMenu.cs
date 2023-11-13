using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


public class PizzaMenu : Pizza
{
    private Dictionary<int, Pizza> pizzas = new Dictionary<int, Pizza>();

        public PizzaMenu(string pizzaName, double prices, string ingredients, string topping, int pizzaId) : base(pizzaName,prices,ingredients,topping,pizzaId)
        {
        }

    public PizzaMenu()
    {

    }

        public Pizza? SearchPizza(int pizzaId)
        {
            if (pizzas.ContainsKey(pizzaId))
                return pizzas[pizzaId];
        return null;
        }

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza.PizzaId, pizza);
        }

        public void RemovePizza(int pizzaId)
        {
            pizzas.Remove(pizzaId);
        }

        public List<Pizza> GetPizza()
        {
            return pizzas.Values.ToList();
        }

}