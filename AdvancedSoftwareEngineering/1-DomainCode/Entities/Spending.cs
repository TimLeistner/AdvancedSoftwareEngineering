using System;
using System.Collections.Generic;
using System.Text;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _1_DomainCode.ValueObjects.Interfaces;

namespace _1_Domain_Code.Entities
{
    public sealed class Spending: ISpending
    {
        private Guid guid;
        private IMoney spendMoney;
        private DateTime date;
        private string description;

        public Spending(IMoney spendMoney, DateTime date, string description)
        {
            guid = Guid.NewGuid();
            this.spendMoney = spendMoney;
            this.date = date;
            this.description = description;
        }

        public void ChangeDescription(string description)
        {
            this.description = description;
        }

        public IMoney GetSpendMoney()
        {
            return spendMoney;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public string GetDescription()
        {
            return description;
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
