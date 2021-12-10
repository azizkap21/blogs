using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.Version10.Models
{
    public struct BuyAmount
    {
        public BuyAmount()
        {
            Amount = 0;
            Currency = string.Empty;
        }
        public decimal Amount { get; set; }

        public string Currency { get; set; }


    }
    public class Addable<int>
    {
        public static R operator +(int t1, int t2)
        {
            return t1 + t2; 
        }

    }

    public interface IAddable<T> where T : IAddable<T>
    {
    }
}
