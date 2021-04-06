using _1_Domain_Code.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.SpendingTools
{
    public class SpendingCalculator
    {
        Category category;
        SpendingCalculator(Category category)
        {
            this.category = category;
        }

        public bool IsLimitExceeded(DateTime month)
        {
            bool result = false;
            List<Spending> spendingOfMonth = SpendingSorter.GetSpendingByMonth(category.GetSpendings(), month);

            double limit = category.GetLimit().GetValue();
            double sumOfSpending = GetSumOfSpending(spendingOfMonth);

            result = limit < sumOfSpending;

            return result;
        }

        public double GetSumOfSpending(List<Spending> spendings)
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
