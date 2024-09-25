using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{
    #region instance fields
    string _name;
    string _adress;
    bool _isMember;
    #endregion

    #region constructors
    //Dependant on whether they want delivery or want to pick up
    public Customer(string name)
    {
        _name = name;
        _adress = "";
        _isMember = false;
    }

    public Customer(string name, string adress)
    {
        _name = name;
        _adress = adress;
        _isMember = false;
    }

    #endregion
}
