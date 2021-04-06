using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests._1_DomainCode
{
    public class CategoryTest
    {
        [Test]
        public void CategoryCreationTest()
        {
            string name = "Test";
            Colour colour = Colour.RED;
            Money limit = new Money(20, Currency.EURO);

            //Two categories with same properties should not be equal because of different GUID
            Category category1 = new Category(name, colour, limit);
            Category category2 = new Category(name, colour, limit);
            Assert.AreNotEqual(category1, category2);

            //When setting negative limit, limit is set automatically to 0
            Money falseLimit = new Money(-5, Currency.EURO);
            Category category3 = new Category(name, colour, falseLimit);
            Assert.IsTrue(category3.GetLimit().GetValue() == 0);
        }

        [Test]
        public void SpendingManagingTest()
        {
            string name = "Test";
            Colour colour = Colour.RED;
            Money money = new Money(0, Currency.EURO);
            Category category = new Category(name, colour, money);
            Spending spending = new Spending(money, new DateTime(), "Test");

            category.AddSpending(spending);
            List<ISpending> spendingList = category.GetSpendings();
            Assert.IsTrue(spendingList.Count == 1 && spendingList.Contains(spending));

            category.RemoveSpending(spending);
            spendingList = category.GetSpendings();
            Assert.IsTrue(spendingList.Count == 0);
        }
    }
}
