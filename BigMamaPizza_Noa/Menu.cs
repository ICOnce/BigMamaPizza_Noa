using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Menu
{
    private static Pizza[] pizzas;

    public static int MenuLength()
    {
        return pizzas.Length;
    }

    public static void MakeMenu()
    {
        pizzas = new Pizza[4];
        pizzas[0] = new Pizza("Margherita", new List<string> { "Tomato", "Cheese" }, 69);
        pizzas[1] = new Pizza("Vesuvio", new List<string> { "Tomato", "Cheese", "Ham" }, 75);
        pizzas[2] = new Pizza("Capricciosa", new List<string> { "Tomato", "Cheese", "ham", "Mushrooms" }, 80);
        pizzas[3] = new Pizza("Calzone", new List<string> { "Baked Pizza with Tomato", "Cheese", "Ham", "Mushrooms" }, 80);
    }

    public static Pizza GetPizza(int id)
    {
        return pizzas[id];
    }
}