using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    private static int nrOfOrders;
    #region instance fields
    private int _orderNr;
    private Customer _customer;
    private double _price;
    private List<Pizza> _pizzas;
    private string _date;
    private bool _isDone;
    private bool _delivery;
    #endregion

    #region constructors

    public Order(Customer customer)
    {
        _customer = customer;
        _isDone = false;
        _date = DateTime.Now.ToString();
        _pizzas = new List<Pizza>();
        //Increment the number of orders and give this order that number
        nrOfOrders++;
        _orderNr = nrOfOrders;
    }

    #endregion

    #region properties

    public int OrderNr {  get { return _orderNr; } }

    public Pizza[] Pizzas { get { return _pizzas.ToArray(); } }

    public string Date { get { return _date; } }

    public bool IsDone { get { return _isDone; } }

    public bool Delivery 
    { 
        get 
        { 
            return _delivery;
        }
        set
        {
            if (_customer.Address != null)
            {
                _delivery = value;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Customer needs an address to order delivery");
                Console.ForegroundColor= ConsoleColor.Gray;
            }
        }
    }
    #endregion

    #region methods

    public void AddToOrder(int id)
    {
        if (id > Menu.MenuLength() - 1 || id < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid menu ID");
            Console.ForegroundColor = ConsoleColor.Gray;
            return;
        }
        _pizzas.Add(Menu.GetPizza(id));
    }

    public double GetTotal()
    {
        foreach (Pizza pizza in _pizzas)
        {
            _price += pizza.Price;
        }
        if (_delivery == true) _price += 40;
        return _price;
    }

    public void Done()
    {
        _isDone = true;
    }

    public override string ToString()
    {
        string output = $"\nOrder number: {_orderNr}\n\nCustomer: {_customer}\nDate: {_date}\n\nShould be delivered: {_delivery}\nIs Done: {_isDone}\n\n{_pizzas.Count} pizzas in order";
        foreach (Pizza pizza in _pizzas)
        {
            output += "\n*  " + pizza.ToString();
        }
        output += $"\nPrice: {GetTotal()} kr";
        return output;
    }

    #endregion
}
