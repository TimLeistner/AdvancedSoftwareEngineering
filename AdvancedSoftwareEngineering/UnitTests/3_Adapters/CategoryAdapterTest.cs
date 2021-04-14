using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _1_DomainCode.ValueObjects.Interfaces;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using _2_ApplicationCode;
using _3_Adapters.Interfaces;
using _2_ApplicationCode.Repositories;
using _3_Adapters;

namespace UnitTests._3_Adapters
{
    class CategoryAdapterTest
    {
        ICategoryAdapter categoryAdapter;
        ICategory testCategory;
        [SetUp]
        public void Setup()
        {
            var financeManagerMock = new Mock<IFinanceManager>();
            var categoryRepositoryMock = new Mock<ICategoryRepository>();
            testCategory = new Category("Test", Colour.BLUE, new Money(200, Currency.EURO));

            financeManagerMock.Setup(f => f.GetCategoryRepository()).Returns(categoryRepositoryMock.Object);
            categoryRepositoryMock.Setup(c => c.GetCategoryList()).Returns(new List<ICategory>() { testCategory });

            categoryAdapter = new CategoryAdapter(financeManagerMock.Object);
        }

        [Test]
        public void CategoryAdapterChangeCategoryTest()
        {
            ICategory category = new Category("Test", Colour.BLUE, new Money(200, Currency.NONE));

            string testDescription = "New description";
            Assert.IsFalse(category.GetColour() == Colour.YELLOW || category.GetCategoryName().Equals(testDescription));
            categoryAdapter.ChangeCategory(category, testDescription, Colour.YELLOW);
            Assert.IsTrue(category.GetColour() == Colour.YELLOW && category.GetCategoryName().Equals(testDescription));

            double value1 = 20;
            double value2 = 50;
            categoryAdapter.ChangeCategory(category, newLimitValue: value1);
            Assert.IsTrue(category.GetLimit().GetValue() == value1);
            categoryAdapter.ChangeCategory(category, newLimitValue: value2, newCurrency: Currency.EURO);
            IMoney limit = category.GetLimit();
            Assert.IsTrue(limit.GetValue() == value2 && limit.GetCurrency() == Currency.EURO);
        }

        [Test]
        public void CategoryAdapterGetCategoryListTest()
        {
            List<ICategory> categoryList = categoryAdapter.GetCategoryList();
            Assert.IsTrue(categoryList.Count == 1 && categoryList.Contains(testCategory));
        }
    }
}
