using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _1_DomainCode.ValueObjects.Interfaces;
using _2_ApplicationCode.SpendingTools;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTests._2_ApplicationCode.SpendingTools
{
    public class SpendingSorterTest
    {
        List<ISpending> spendingList;

        [SetUp]
        public void Setup()
        {
            spendingList = new List<ISpending>();
            ISpending spending1 = new Spending(new Money(0, Currency.EURO), new DateTime(2021, 1, 1), "");
            ISpending spending2 = new Spending(new Money(0, Currency.EURO), new DateTime(2020, 1, 1), "");
            ISpending spending3 = new Spending(new Money(0, Currency.EURO), new DateTime(2021, 2, 1), "");
            ISpending spending4 = new Spending(new Money(0, Currency.EURO), new DateTime(2021, 1, 12), "");
            ISpending spending5 = new Spending(new Money(0, Currency.EURO), new DateTime(2021, 1, 27), "");

            spendingList.Add(spending1);
            spendingList.Add(spending2);
            spendingList.Add(spending3);
            spendingList.Add(spending4);
            spendingList.Add(spending5);
        }

        [Test]
        public void GetSpendingForMonthTest()
        {
            List<ISpending> spendingJanuary2021 = SpendingSorter.GetSpendingForMonth(spendingList, new DateTime(2021, 1, 1));
            Assert.IsTrue(spendingJanuary2021.Count == 3);
            Assert.IsTrue(spendingJanuary2021.Contains(spendingList[0]) && spendingJanuary2021.Contains(spendingList[3]) && spendingJanuary2021.Contains(spendingList[4]));
        }

        [Test]
        public void SortSpendingByDateTest()
        {
            List<ISpending> sortedList = new List<ISpending>();
            spendingList.ForEach((spending) =>
            {
                sortedList.Add(spending);
            });
            SpendingSorter.SortSpendingByDate(ref sortedList);
            Assert.IsTrue(sortedList[0].Equals(spendingList[1]) &&
                sortedList[1].Equals(spendingList[0]) &&
                sortedList[2].Equals(spendingList[3]) &&
                sortedList[3].Equals(spendingList[4]) &&
                sortedList[4].Equals(spendingList[2]));
        }
    }
}
