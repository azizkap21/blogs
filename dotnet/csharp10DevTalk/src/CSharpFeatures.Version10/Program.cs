// See https://aka.ms/new-console-template for more information
using CSharpFeatures.Version10;
using CSharpFeatures.Version10.Models;

using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var person = new Person("Aziz", "Kapadia");

Utility.LogExpression(person.FirstName); // Outputs "person.FirstName: Thomas"

var person1 = new Person(null, "Test");


//new MyClass().MyMethod(person1);


var buyAmount = new BuyAmount(10, "GBP");

var employee = new Employee("Aziz", "Kapadia", new DateTime(2021, 02, 14));

var employee2 = employee with { FirstName = "Raghu", LastName = "Gattapur" };

Console.WriteLine(employee);

Console.WriteLine(employee2);


Console.ReadKey();



public static class Utility
{

    public static void LogExpression<T>(T value, [CallerArgumentExpression("value")] string? expression = null)
    {
        Console.WriteLine($"{expression}: {value}");
    }

    public static void ThrowIfNull<T>(T some, [CallerArgumentExpression("some")] string? expression = null) 
    {
        if (some == null)
            throw new ArgumentNullException($"{expression} can not be null");

    }


}
