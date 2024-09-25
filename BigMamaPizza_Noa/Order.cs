using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    static int nrOfOrders;
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
        _date = DateTime.Today.ToString();
        _pizzas = new List<Pizza>();
        //Increment the number of orders and give this order that number
        nrOfOrders++;
        _orderNr = nrOfOrders;
    }

    #endregion

    #region methods

    #endregion
}
