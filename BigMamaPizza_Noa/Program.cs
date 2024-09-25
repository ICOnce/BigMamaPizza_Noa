Menu.MakeMenu();

Order test = new Order(new Customer("LabRat"));
test.AddToOrder(2);
test.AddToOrder(3);
Console.WriteLine(test.ToString());