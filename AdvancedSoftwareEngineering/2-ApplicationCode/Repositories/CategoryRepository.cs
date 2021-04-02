using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.Repositories
{
    public class CategoryRepository
    {
        private List<Category> categoryList;

        public CategoryRepository()
        {
            categoryList = new List<Category>();
        }

        public List<Category> GetCategories()
        {
            return categoryList;
        }

        public void CreateCategory(string name, Colour colour, Money limit)
        {
            Category category = new Category(name, colour, limit);
            categoryList.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            if (categoryList.Contains(category))
            {
                categoryList.Remove(category);
            }
        }

        public void ChangeCategoryName(Category category, string newName)
        {
            if (categoryList.Contains(category))
            {
                category.ChangeName(newName);
            }
        }

        public void ChangeCategoryColour(Category category, Colour newColour)
        {
            if (categoryList.Contains(category))
            {
                category.ChangeColour(newColour);
            }
        }

        public void ChangeCategoryLimit(Category category, Money newLimit)
        {
            if (categoryList.Contains(category))
            {
                category.ChangeLimit(newLimit);
            }
        }
    }
}
