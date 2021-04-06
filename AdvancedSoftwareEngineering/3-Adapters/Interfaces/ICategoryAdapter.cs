using _1_Domain_Code.Enums;
using _1_DomainCode.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Adapters.Interfaces
{
    public interface ICategoryAdapter
    {
        List<ICategory> GetCategoryList();
        void ChangeCategory(ICategory category, string newName = null, Colour newColour = Colour.NONE, double newLimitValue = Double.NaN, Currency newCurrency = Currency.NONE);
        void AddCategory(string name, Colour colour, double limitValue, Currency limitCurrency);
    }
}
