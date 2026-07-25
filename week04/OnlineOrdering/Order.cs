class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int GetTotalCost()
    {
        int tempTotal = 0;

        foreach (Product product in _products)
        {
            tempTotal += product.GetTotalCost();
        }

        if (_customer.IsAmerican())
        {
            tempTotal += 5;
        }
        else
        {
            tempTotal += 35;
        }

        return tempTotal;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetAddress()}";
    }

    public string GetPackinglabel()
    {
        string returnString = "";

        foreach (Product product in _products)
        {
            returnString += $"{product.GetProductName()} - {product.GetProductId()}\n";
        }

        return returnString;
    }
}