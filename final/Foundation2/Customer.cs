using System;

public class Customer {

    private string _name;
    private Address _address;

    public void SetCustomer (string name, Address address) {
        _name = name;
        _address = address;
    }

    public bool IsCitizen() {

        return _address.CitizenStatus();


        // var globalStatus = new CitizenStatus();
        // if country == true

        // else
        // {
            
        // }
    }

    public string GetName() {
        return _name;
    }

    public string GetAddress() {
        return _address.SetAddress();
    }
}