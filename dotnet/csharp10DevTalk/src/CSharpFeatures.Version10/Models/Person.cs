using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.Version10.Models
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DOB { get; set; }

        public List<string> Reportees { get; set; } = new List<string>();

        
    }
}
