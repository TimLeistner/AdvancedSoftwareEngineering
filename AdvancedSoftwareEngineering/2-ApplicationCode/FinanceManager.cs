
using _2_ApplicationCode.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode
{
    
    public class FinanceManager
    {
        public static FinanceManager instance;

        private ICategoryRepository categoryRepository;

        private FinanceManager()
        {
            categoryRepository = new CategoryRepository();
        }

        public ICategoryRepository GetCategoryRepository()
        {
            return categoryRepository;
        }

        public static FinanceManager GetInstance()
        {
            if(instance == null)
            {
                instance = new FinanceManager();
            }

            return instance;
        }
    }
}
