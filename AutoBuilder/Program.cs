using AutoBuilder;

Console.WriteLine("Hello, World!");

var builder = new PersonBuilder()
              .WithId(1)
              .WithName("John")
              .WithAddress("123 Main St")
              .AddJajo("test")
              .AddOrders(new Order() { Product = "Shoes", Price = 50.00 }, new Order() { Product = "Shirt", Price = 25.00 });
    
builder.Salary
       .WithAmount(1)
       .WithCurrency("USD");

Person john = builder;

Console.WriteLine(john);
