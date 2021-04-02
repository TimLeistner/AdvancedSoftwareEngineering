using System;
using System.Collections.Generic;
using System.Text;
using _1_Domain_Code.ValueObjects;

namespace _1_Domain_Code.Entities
{
    public sealed class Spending
    {
        private Guid guid;
        private Money spendMoney;
        private DateTime date;
        private string description;

        public Spending(Money spendMoney, DateTime date, string description)
        {
            guid = new Guid();
            this.spendMoney = spendMoney;
            this.date = date;
            this.description = description;
        }

        public Spending(Guid guid, Money spendMoney, DateTime date, string description)
        {
            this.guid = guid;
            this.spendMoney = spendMoney;
            this.date = date;
            this.description = description;
        }

        public void ChangeDescription(string description)
        {
            this.description = description;
        }

        public override bool Equals(object obj)
        {
            return obj is Spending spending &&
                   guid.Equals(spending.guid);
        }

        public override int GetHashCode()
        {
            return -1324198676 + guid.GetHashCode();
        }
    }
}
