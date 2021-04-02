using System;
using System.Collections.Generic;
using System.Text;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;

namespace _1_Domain_Code.Entities
{
    public sealed class Category
    {
        private Guid guid;
        private string name;
        private Colour colour;
        private Money limit;
        private List<Spending> spendings;

        public Category(string name, Colour colour, Money limit)
        {
            guid = new Guid();
            this.name = name;
            this.colour = colour;

            if (limit.GetValue() >= 0)
            {
                this.limit = limit;
            }
            else
            {
                this.limit = new Money(0, limit.GetCurrency());
            }

            spendings = new List<Spending>();
        }

        public Guid GetGuid()
        {
            Guid result = guid;
            return result;
        }

        public string GetCategoryName()
        {
            string result = name;
            return result;
        }

        public Colour GetColour()
        {
            Colour result = colour;
            return result;
        }

        public Money GetLimit()
        {
            Money result = limit;
            return result;
        }

        public List<Spending> GetSpendings()
        {
            List<Spending> result = spendings;
            return result;
        }

        public void AddSpending(Spending spending)
        {
            spendings.Add(spending);
        }

        public void RemoveSpending(Spending spending)
        {
            if (spendings.Contains(spending))
            {
                spendings.Remove(spending);
            }   
        }

        public void ChangeName(string newName)
        {
            if(newName != null)
            {
                name = newName;
            }
        }

        public void ChangeColour(Colour newColour)
        {
            colour = newColour;
        }

        public void ChangeLimit(Money newLimit)
        {
            if(newLimit != null)
            {
                if(newLimit.GetValue() >= 0)
                {
                    limit = newLimit;
                }
                else
                {
                    limit = new Money(0, newLimit.GetCurrency());
                }    
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Category category &&
                   guid.Equals(category.guid);
        }

        public override int GetHashCode()
        {
            return -1324198676 + guid.GetHashCode();
        }

        public override string ToString()
        {
            return GetCategoryName();
        }
    }
}
