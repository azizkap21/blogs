

namespace CSharpFeatures.Version10.Models
{
   public record class Employee(string FirstName,string LastName, DateTime JoiningDate );

    public record struct SellAmount(string currency, decimal amount);

}
