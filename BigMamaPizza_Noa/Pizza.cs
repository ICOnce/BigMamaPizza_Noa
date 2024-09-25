using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{
    #region instance fields

    private string _name;
    private List<string> _toppings;
    private double _price;

    #endregion

    #region constructors

    public Pizza(string name, List<string> toppings, double price)
    {
        _name = name;
        _toppings = toppings;
        _price = price;
    }

    #endregion

    #region properties

    public string[] Toppings
    {
        get { return _toppings.ToArray(); }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public string Name
    {
        get { return _name; }
    }

    #endregion

    #region methods
    public override string ToString()
    {
        string output = $"{_name}: {_price} kr\n    ";
        foreach (string s in _toppings)
        {
            output += s + ", ";
        }
        output = output.Remove(output.Length-2, 2);
        return output;
    }
    #endregion
}
