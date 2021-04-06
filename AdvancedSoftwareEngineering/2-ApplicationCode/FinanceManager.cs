
using _2_ApplicationCode.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode
{
    
    public class FinanceManager
    {
        private ICategoryRepository categoryRepository;

        public FinanceManager()
        {
            categoryRepository = new CategoryRepository();
        }

        public ICategoryRepository GetCategoryRepository()
        {
            return categoryRepository;
        }
    }
}
