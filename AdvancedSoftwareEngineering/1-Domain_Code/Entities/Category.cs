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
            this.limit = limit;
            spendings = new List<Spending>();
        }

        public Category(Guid guid, string name, Colour colour, Money limit, List<Spending> spendings)
        {
            this.guid = guid;
            this.name = name;
            this.colour = colour;
            this.limit = limit;
            this.spendings = spendings;
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

        public override bool Equals(object obj)
        {
            return obj is Category category &&
                   guid.Equals(category.guid);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(guid);
        }
    }
}
