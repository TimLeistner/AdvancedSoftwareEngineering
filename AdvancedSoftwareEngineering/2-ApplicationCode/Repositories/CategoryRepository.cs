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

        public List<Category> GetCategoryList()
        {
            return categoryList;
        }

        public Category GetCategory(Guid guid)
        {
            Category result = null;

            categoryList.ForEach((category) =>
            {
                if (category.GetGuid().Equals(guid))
                {
                    result = category;
                    return;
                }
            });

            return result;
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
    }
}
