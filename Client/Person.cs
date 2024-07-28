using AutoBuilder;

namespace Client;

[AutoBuilder]
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public List<Order> Orders { get; set; } = [];

    [AutoBuilderIgnore]

    public double Ignored { get; set; }
    
    public Salary Salary { get; set; } = new Salary();
    
    
    // return json representation of the object
    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}

public class Order
{
    public string Product { get; set; } = string.Empty;
    public double Price { get; set; }
}

[AutoBuilder]
public class Salary
{
    public double Amount { get; set; }
    public string Currency { get; set; } = string.Empty;
}