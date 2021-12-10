// See https://aka.ms/new-console-template for more information
using CSharpFeatures.Version10;
using CSharpFeatures.Version10.Models;

using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var person = new Person("Aziz", "Kapadia");

SomeClass.LogExpression(person.FirstName); // Outputs "person.FirstName: Thomas"

Console.ReadKey();

new MyClass().MyMethod(null);



public class SomeClass
{

    public static void LogExpression<T>(T value, [CallerArgumentExpression("value")] string? expression = null)
    {
        Console.WriteLine($"{expression}: {value}");
    }

    

}
