using System;
using _1_Domain_Code.Enums;

namespace _1_Domain_Code.ValueObjects
{
    public sealed class Money
    {
        private double value;
        private Currency currency;

        public Money(double value, Currency currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public double GetValue()
        {
            double result = value;
            return result;
        }

        public Currency GetCurrency()
        {
            Currency result = currency;
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Money money &&
                   value == money.value &&
                   currency == money.currency;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value, currency);
        }
    }
}
