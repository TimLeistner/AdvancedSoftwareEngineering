using _1_Domain_Code.Entities;
using _1_DomainCode.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.SpendingTools
{
    public class SpendingSorter
    {
        public static List<ISpending> GetSpendingForMonth(List<ISpending> spendings, DateTime month)
        {
            List<ISpending> spendingOfMonth = new List<ISpending>();
            spendings.ForEach((spending) =>
            {
                DateTime spendingDate = spending.GetDate();
                if (spendingDate.Year == month.Year)
                {
                    if (spendingDate.Month == month.Month)
                    {
                        spendingOfMonth.Add(spending);
                    }
                }
            });
            SortSpendingByDate(ref spendingOfMonth);

            return spendingOfMonth;
        }

        public static void SortSpendingByDate(ref List<ISpending> spendings)
        {
            int n = spendings.Count;
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    int c = DateTime.Compare(spendings[i].GetDate(), spendings[i + 1].GetDate());
                    if (c > 0)
                    {
                        SwapEntries(ref spendings, i, i + 1);
                        swapped = true;
                    }
                }
                n = n - 1;
            } while (swapped);
        }

        private static void SwapEntries(ref List<ISpending> list, int entry1, int entry2)
        {
            ISpending firstObject = list[entry1];
            ISpending secondObject = list[entry2];
            list[entry2] = firstObject;
            list[entry1] = secondObject;
        }
    }
}
