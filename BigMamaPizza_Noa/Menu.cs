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
        pizzas = new Pizza[20];
        pizzas[0] = new Pizza("The forbidden Pizza", new List<string> { "Pineapple", "Pineapple", "Pineapple", "Pineapple" }, 666.69);
        pizzas[1] = new Pizza("Margherita", new List<string> { "Tomato", "Cheese" }, 69);
        pizzas[2] = new Pizza("Vesuvio", new List<string> { "Tomato", "Cheese", "Ham" }, 75);
        pizzas[3] = new Pizza("Capricciosa", new List<string> { "Tomato", "Cheese", "Ham", "Mushrooms" }, 80);
        pizzas[4] = new Pizza("Calzone", new List<string> { "Baked Pizza with Tomato", "Cheese", "Ham", "Mushrooms" }, 80);
        pizzas[5] = new Pizza("Quatro stagioni", new List<string> { "Tomato", "Cheese", "Ham", "Mushrooms", "Shrimp", "Peppers"}, 85);
        pizzas[6] = new Pizza("Marinara", new List<string> { "Tomato", "Cheese", "Shrimp", "Mussels", "Garlic"}, 85);
        pizzas[7] = new Pizza("Vegetarian", new List<string> { "Tomato", "Cheese", "Vegetables"}, 80);
        pizzas[8] = new Pizza("Italiana", new List<string> { "Tomato", "Cheese", "Onion", "Meat sauce" }, 75);
        pizzas[9] = new Pizza("Gorgonzola", new List<string> { "Tomato", "Gorgonzola", "Onion", "Mushroom"}, 85);
        pizzas[10] = new Pizza("Contadina", new List<string> { "Tomato", "Cheese", "Mushrooms", "Olives" }, 75);
        pizzas[11] = new Pizza("Naples", new List<string> { "Tomato", "Cheese", "Anchovies", "Olives" }, 79);
        pizzas[12] = new Pizza("Vichinga", new List<string> { "Tomato", "Cheese", "Ham", "Mushrooms", "Peppers", "Garlic", "Chili(strong)" }, 80);
        pizzas[13] = new Pizza("Calzone special", new List<string> { "(Not baked) Tomato", "Cheese", "Shrimp", "Pineapple" }, 80);
        pizzas[14] = new Pizza("Esotica", new List<string> { "Tomato", "Cheese", "Ham", "Shrimp", "Ham", "Meat sauce" }, 80);
        pizzas[15] = new Pizza("Tonno", new List<string> { "Tomato", "Cheese", "Tuna", "Shrimp" }, 85);
        pizzas[16] = new Pizza("Sardegna", new List<string> { "Tomato", "Cheese", "Cocktail sausages", "Bacon", "Onions", "Eggs" }, 80);
        pizzas[17] = new Pizza("Romana", new List<string> { "Tomato", "Cheese", "Ham", "Bacon", "Onion" }, 78);
        pizzas[18] = new Pizza("Sole", new List<string> { "Tomato", "Cheese", "Ham", "Bacon", "Eggs" }, 78);
        pizzas[19] = new Pizza("Big Mamma", new List<string> { "Tomato", "Gorgonzola", "Shrimp", "Asparagus", "Parma ham" }, 90);
    }

    public static void PrintMenu()
    {
        for (int i = 1; i < pizzas.Length ; i++)
        {
            Console.WriteLine(i + ":" + pizzas[i].ToString() + "\n");
        }
        Console.WriteLine("------------------------------------------------------------------------");
    }

    public static Pizza GetPizza(int id)
    {
        return pizzas[id];
    }
}