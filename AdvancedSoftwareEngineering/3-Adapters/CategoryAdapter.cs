using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _2_ApplicationCode;
using _2_ApplicationCode.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Adapters
{
    public class CategoryAdapter
    {
        private CategoryRepository categoryRepository;

        public CategoryAdapter(FinanceManager financeManager)
        {
            categoryRepository = financeManager.GetCategoryRepository();
        }

        public List<Category> GetCategoryList()
        {
            return categoryRepository.GetCategoryList();
        }

        public void ChangeCategory(Category category, string newName = null, Colour newColour = Colour.NONE, double newLimitValue = Double.NaN, Currency newCurrency = Currency.NONE)
        {
            if(newName != null)
            {
                category.ChangeName(newName);
            }

            if(newColour != Colour.NONE)
            {
                category.ChangeColour(newColour);
            }

            if (newLimitValue != Double.NaN || newCurrency != Currency.NONE)
            {
                double limitValue;
                Currency limitCurrency;

                if(newLimitValue == Double.NaN)
                {
                    limitValue = category.GetLimit().GetValue();
                }
                else
                {
                    limitValue = newLimitValue;
                }

                if(newCurrency == Currency.NONE)
                {
                    limitCurrency = category.GetLimit().GetCurrency();
                }
                else
                {
                    limitCurrency = newCurrency;
                }

                category.ChangeLimit(new Money(limitValue, limitCurrency));
            }
        }

        public void AddCategory(string name, Colour colour, double limitValue, Currency limitCurrency)
        {
            Money limit = new Money(limitValue, limitCurrency);
            categoryRepository.CreateCategory(name, colour, limit);
        }
    }
}
