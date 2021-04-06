using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using _1_Domain_Code.ValueObjects;
using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;

namespace UnitTests._1_DomainCode
{
    public class SpendingTest
    {
        [Test]
        public void TestChangeDescription()
        {
            Money money = new Money(0, Currency.NONE);
            string testDescription = "Test";
            string changedDescription = "This description has been changed";

            Spending spending = new Spending(money, new DateTime(), testDescription);
            Assert.AreEqual(testDescription, spending.GetDescription());

            spending.ChangeDescription(changedDescription);
            Assert.AreEqual(changedDescription, spending.GetDescription());
        }
    }
}
