using CSharpFeatures.Version10.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.Version10
{
    public class MyClass
    {
        public string MyMethod(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);

            return string.Concat(employee.FirstName, employee.LastName);

        }
    }
}
