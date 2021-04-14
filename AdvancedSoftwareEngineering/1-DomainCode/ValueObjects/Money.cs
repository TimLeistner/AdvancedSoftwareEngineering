using System;
using _1_Domain_Code.Enums;
using _1_DomainCode.ValueObjects.Interfaces;

namespace _1_Domain_Code.ValueObjects
{
    public class Money: IMoney
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
            int hashCode = 2139521936;
            hashCode = hashCode * -1521134295 + value.GetHashCode();
            hashCode = hashCode * -1521134295 + currency.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            string result = value + " " + currency;
            return result;
        }
    }
}
