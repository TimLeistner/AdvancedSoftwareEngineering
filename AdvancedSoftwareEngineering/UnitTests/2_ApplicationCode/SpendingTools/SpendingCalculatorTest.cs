using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _1_DomainCode.ValueObjects.Interfaces;
using _2_ApplicationCode.SpendingTools;
using NUnit.Framework;
using System;

namespace UnitTests._2_ApplicationCode.SpendingTools
{
    public class SpendingCalculatorTest
    {
        ICategory category;

        [SetUp]
        public void Setup()
        {
            IMoney limit = new Money(100, Currency.EURO);
            category = new Category("Test", Colour.RED, limit);
            ISpending spending1 = new Spending(new Money(10, Currency.EURO), new DateTime(), "");
            ISpending spending2 = new Spending(new Money(20, Currency.EURO), new DateTime(), "");
            ISpending spending3 = new Spending(new Money(30, Currency.EURO), new DateTime(), "");
            ISpending spending4 = new Spending(new Money(-10, Currency.EURO), new DateTime(), "");

            category.AddSpending(spending1);
            category.AddSpending(spending2);
            category.AddSpending(spending3);
            category.AddSpending(spending4);
        }

        [Test]
        public void GetSumOfSpendingTest()
        {
            double sum = SpendingCalculator.GetSumOfSpending(category.GetSpendings());
            Assert.IsTrue(sum == 50);
        }

        [Test]
        public void IsLimitExceededTest()
        {
            bool limitExceeded = SpendingCalculator.IsLimitExceeded(category, new DateTime());
            Assert.IsFalse(limitExceeded);

            category.AddSpending(new Spending(new Money(1000, Currency.EURO), new DateTime(), ""));
            limitExceeded = SpendingCalculator.IsLimitExceeded(category, new DateTime());
            Assert.IsTrue(limitExceeded);
        }
    }
}
