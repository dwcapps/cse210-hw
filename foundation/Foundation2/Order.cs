using System.Xml.XPath;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotal()
    {
        double result = 0;
        foreach (Product product in _products)
        {
            result += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            result += 5;
        }
        else
        {
            result += 35;
        }
        return result;
    }

    public string GetPackingLabel()
    {
        string result = "";
        foreach (Product product in _products)
        {
            result += $"{product.GetProductId()}: {product.GetName()}\n";
        }
        return result.TrimEnd('\n');
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}