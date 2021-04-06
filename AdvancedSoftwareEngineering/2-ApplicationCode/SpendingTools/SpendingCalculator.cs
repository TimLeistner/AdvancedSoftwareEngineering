using _1_Domain_Code.Entities;
using _1_DomainCode.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.SpendingTools
{
    public class SpendingCalculator
    {
        public static bool IsLimitExceeded(ICategory category, DateTime month)
        {
            bool result = false;
            List<ISpending> spendingOfMonth = SpendingSorter.GetSpendingForMonth(category.GetSpendings(), month);

            double limit = category.GetLimit().GetValue();
            double sumOfSpending = GetSumOfSpending(spendingOfMonth);

            result = limit < sumOfSpending;

            return result;
        }

        public static double GetSumOfSpending(List<ISpending> spendings)
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
