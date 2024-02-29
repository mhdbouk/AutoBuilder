using AutoBuilder;

Console.WriteLine("Hello, World!");

var builder = new PersonBuilder()
              .WithId(1)
              .WithName("John")
              .WithAddress("123 Main St")
              .AddOrders(new Order() { Product = "Shoes", Price = 50.00 }, new Order() { Product = "Shirt", Price = 25.00 });
    
builder.Salary
       .WithAmount(200)
       .WithCurrency("USD");

Person john = builder;

Console.WriteLine(john);

Console.WriteLine("New builder from existing object");
var johnBuilder = new PersonBuilder(john);
johnBuilder.AddOrders(new Order() { Product = "Socks", Price = 5.00 });

john = johnBuilder;

Console.WriteLine(john);
