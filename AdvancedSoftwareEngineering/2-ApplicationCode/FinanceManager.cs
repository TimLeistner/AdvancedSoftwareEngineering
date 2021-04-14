
using _2_ApplicationCode.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode
{
    
    public class FinanceManager: IFinanceManager
    {
        private static IFinanceManager instance;

        private ICategoryRepository categoryRepository;

        private FinanceManager()
        {
            categoryRepository = new CategoryRepository();
        }

        public ICategoryRepository GetCategoryRepository()
        {
            return categoryRepository;
        }

        public static IFinanceManager GetInstance()
        {
            if(instance == null)
            {
                instance = new FinanceManager();
            }

            return instance;
        }
    }
}
