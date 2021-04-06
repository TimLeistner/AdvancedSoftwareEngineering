using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _1_DomainCode.ValueObjects.Interfaces;
using _2_ApplicationCode.Repositories;
using _2_ApplicationCode.SpendingTools;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTests._2_ApplicationCode.Repositories
{
    public class CategoryRepositoryTest
    {
        [Test]
        public void CategoryCreationAndDeletionTest()
        {
            var moneyMock = new Mock<IMoney>();

            ICategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.CreateCategory("Test", Colour.BLUE, moneyMock.Object);

            List<ICategory> categoryList = categoryRepository.GetCategoryList();
            Assert.IsTrue(categoryList.Count == 1 && categoryList[0].GetCategoryName().Equals("Test") && categoryList[0].GetColour() == Colour.BLUE);

            Guid guid = categoryList[0].GetGuid();
            ICategory category = categoryRepository.GetCategory(guid);
            Assert.AreEqual(category, categoryList[0]);
            Assert.IsNull(categoryRepository.GetCategory(new Guid()));

            categoryRepository.DeleteCategory(category);
            Assert.IsTrue(categoryRepository.GetCategoryList().Count == 0);
        }
    }
}
