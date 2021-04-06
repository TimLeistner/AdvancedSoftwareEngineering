using _1_Domain_Code.Entities;
using _1_DomainCode.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.SpendingTools
{
    public class SpendingCalculator
    {
        ICategory category;
        SpendingCalculator(ICategory category)
        {
            this.category = category;
        }

        public bool IsLimitExceeded(DateTime month)
        {
            bool result = false;
            List<ISpending> spendingOfMonth = SpendingSorter.GetSpendingByMonth(category.GetSpendings(), month);

            double limit = category.GetLimit().GetValue();
            double sumOfSpending = GetSumOfSpending(spendingOfMonth);

            result = limit < sumOfSpending;

            return result;
        }

        public double GetSumOfSpending(List<ISpending> spendings)
        {
            double sumOfSpending = 0;

            spendings.ForEach((spending) =>
            {
                sumOfSpending += spending.GetSpendMoney().GetValue();
            });

            return sumOfSpending;
        }
    }
}
