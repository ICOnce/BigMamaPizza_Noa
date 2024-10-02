using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{
    #region instance fields
    private string _name;
    private string _address;
    private bool _isMember;
    #endregion

    #region constructors
    //Dependant on whether they want delivery or want to pick up
    public Customer(string name)
    {
        _name = name;
        _address = "No Address provided";
        _isMember = false;
    }

    public Customer(string name, string adress)
    {
        _name = name;
        _address = adress;
        _isMember = false;
    }
    #endregion

    #region properties
    public string Name { get { return _name; } }

    public bool IsMember { get { return _isMember; } }
    
    //Option to add an adress to a customer if they picked up before, but now want delivery
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    #endregion

    #region methods

    public void MakeMember()
    {
        _isMember = true;
    }

    public override string ToString()
    {
        return $"(Name: {_name}, Address: {_address}, IsMember: {_isMember})";
    }

    #endregion
}
