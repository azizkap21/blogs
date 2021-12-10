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

        public BuyAmount(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; init; }

        public string Currency { get; init; }


    }
}
