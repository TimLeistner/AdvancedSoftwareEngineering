using _1_Domain_Code.Enums;
using _1_DomainCode.Entities.Interfaces;
using _1_DomainCode.ValueObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode.Repositories
{
    public interface ICategoryRepository
    {
        List<ICategory> GetCategoryList();
        ICategory GetCategory(Guid guid);
        void CreateCategory(string name, Colour colour, IMoney limit);
        void DeleteCategory(ICategory category);
    }
}
