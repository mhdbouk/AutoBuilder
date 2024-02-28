# AutoBuilder

AutoBuilder is a .NET solution that uses the power of Source Generators to automatically generate builder classes for your entities. It consists of two projects: `AutoBuilder` and `AutoBuilderGenerator`.

## AutoBuilder

The [`AutoBuilder`](AutoBuilder/AutoBuilder.csproj) project is where you define your entities. It references the `AutoBuilderGenerator` project as an analyzer. This project contains entities like [`Person`](AutoBuilder/Person.cs), [`Order`](AutoBuilder/Person.cs), and [`Salary`](AutoBuilder/Person.cs). These entities are decorated with the [`AutoBuilderAttribute`](AutoBuilder/AutoBuilderAttribute.cs), which triggers the generation of the corresponding builder classes.

## AutoBuilderGenerator

The [`AutoBuilderGenerator`](AutoBuilderGenerator/AutoBuilderGenerator.csproj) project is a Source Generator that generates builder classes for entities decorated with the `AutoBuilderAttribute`. The main class in this project is [`AutoEntityBuilder`](AutoBuilderGenerator/AutoEntityBuilder.cs), which implements the `IIncrementalGenerator` interface from `Microsoft.CodeAnalysis`.

## Usage

To use AutoBuilder, you need to decorate your entity classes with the `AutoBuilderAttribute`. For example:

```cs
[AutoBuilder]
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    // other properties...
}
```
Once you've done this, a PersonBuilder class will be automatically generated. You can use this builder class to create instances of Person:

```cs
var builder = new PersonBuilder()
              .WithId(1)
              .WithName("John")
              // set other properties...
              
Person john = builder;
```

## Ignoring Properties

If you want to ignore a property and not generate builder methods for it, you can decorate it with the `AutoBuilderIgnoreAttribute`:

```cs
[AutoBuilderIgnore]
public double Ignored { get; set; }
```

## License
This project is licensed under the terms of the [MIT License](LICENSE).
