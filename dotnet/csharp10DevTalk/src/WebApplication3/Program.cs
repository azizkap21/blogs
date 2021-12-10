var builder = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(c=>c.UseStartup<Startup>());
DoSomething();

builder.Build().Run();


static void DoSomething()
{

    Console.WriteLine($"{nameof(DoSomething)} is called");

}



public class MyClass
{
    public string FullName([]string firstName, string? lastName)
    {

    }
}

