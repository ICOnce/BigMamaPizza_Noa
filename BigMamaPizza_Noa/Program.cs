Menu.MakeMenu();
Menu.PrintMenu();
Customer LabRat = new Customer("LabRat");
Order order = new Order(LabRat);
bool ordering = true;
Console.Title = "Ordering terminal";
while (ordering == true)
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"\nYou currently have {order.Pizzas.Length} pizzas in your order. Do you want to add a pizza to your order? Y/N");
    if (Console.ReadLine().Trim().ToLower().Equals("y"))
    {
        int pizzanr;
        Console.WriteLine("\nEnter a number from the menu");
        string orderString = Console.ReadLine();
        if (!int.TryParse(orderString, out pizzanr))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input was not a number, try again");
        }
        else order.AddToOrder(pizzanr);
    }
    else ordering = false;
}
Console.WriteLine(order.ToString());