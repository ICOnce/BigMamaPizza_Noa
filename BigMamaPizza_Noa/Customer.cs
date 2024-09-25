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
        _adress = "No Adress provided";
        _isMember = false;
    }

    public Customer(string name, string adress)
    {
        _name = name;
        _adress = adress;
        _isMember = false;
    }
    #endregion

    #region properties
    public string Name { get { return _name; } }

    public bool IsMember { get { return _isMember; } }
    
    //Option to add an adress to a customer if they picked up before, but now want delivery
    public string Adress
    {
        get { return _adress; }
        set { _adress = value; }
    }
    #endregion

    #region methods

    public void MakeMember()
    {
        _isMember = true;
    }

    public override string ToString()
    {
        return $"Name:{_name}\nAdress:{_adress}\nIsMember:{_isMember}";
    }

    #endregion
}
