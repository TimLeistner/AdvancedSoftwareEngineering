using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _1_DomainCode.ValueObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private List<ICategory> categoryList;

        public CategoryRepository()
        {
            categoryList = new List<ICategory>();
        }

        public List<ICategory> GetCategoryList()
        {
            return categoryList;
        }

        public ICategory GetCategory(Guid guid)
        {
            ICategory result = null;

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

        public void CreateCategory(string name, Colour colour, IMoney limit)
        {
            ICategory category = new Category(name, colour, limit);
            categoryList.Add(category);
        }

        public void DeleteCategory(ICategory category)
        {
            if (categoryList.Contains(category))
            {
                categoryList.Remove(category);
            }
        }
    }
}
