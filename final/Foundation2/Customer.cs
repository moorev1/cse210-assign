// Customer.cs
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsUsaResident()
    {
        return string.Equals(address.Country, "USA", System.StringComparison.OrdinalIgnoreCase);
    }
}
