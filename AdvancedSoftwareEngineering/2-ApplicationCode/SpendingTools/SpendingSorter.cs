using _1_Domain_Code.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.SpendingTools
{
    public class SpendingSorter
    {
        public static List<Spending> GetSpendingByMonth(List<Spending> spendings, DateTime month)
        {
            List<Spending> spendingOfMonth = new List<Spending>();
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

        public static void SortSpendingByDate(ref List<Spending> spendings)
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

        public static void SwapEntries(ref List<Spending> list, int entry1, int entry2)
        {
            Spending firstObject = list[entry1];
            Spending secondObject = list[entry2];
            list[entry1] = firstObject;
            list[entry2] = secondObject;
        }
    }
}
