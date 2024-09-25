Menu.MakeMenu();
Menu.PrintMenu();
Order test = new Order(new Customer("LabRat"));
test.AddToOrder(2);
test.AddToOrder(3);
Console.WriteLine(test.ToString());