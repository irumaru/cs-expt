// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    static void Main()
    {
        var person = new Person { Name = "Alice", Age = 25 };
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
