
using _2_ApplicationCode.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode
{
    
    public class FinanceManager
    {
        private CategoryRepository categoryRepository;

        public FinanceManager()
        {
            categoryRepository = new CategoryRepository();
        }

        public CategoryRepository GetCategoryRepository()
        {
            return categoryRepository;
        }
    }
}
