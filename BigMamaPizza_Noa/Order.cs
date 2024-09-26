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

    #endregion

    #region methods

    public void AddToOrder(int id)
    {
        if (id > Menu.MenuLength() - 1 || id < 0)
        {
            Console.WriteLine("Invalid menu ID");
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
        return _price;
    }

    public void Done()
    {
        _isDone = true;
    }

    public override string ToString()
    {
        string output = $"Order number: {_orderNr}\n\nCustomer: {_customer}\nDate: {_date}\n\nIsDone: {_isDone}\n\nPizzas in order";
        foreach (Pizza pizza in _pizzas)
        {
            output += "\n*  " + pizza.ToString();
        }
        output += $"\nPrice: {GetTotal()} kr";
        return output;
    }

    #endregion
}
