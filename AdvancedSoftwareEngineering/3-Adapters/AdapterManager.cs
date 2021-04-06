using _2_ApplicationCode;
using _3_Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Adapters
{
    public class AdapterManager
    {
        private FinanceManager financeManager;
        private ICategoryAdapter categoryAdapter;

        public AdapterManager()
        {
            financeManager = new FinanceManager();
            categoryAdapter = new CategoryAdapter(financeManager);
        }

        public ICategoryAdapter GetCategoryAdapter()
        {
            return categoryAdapter;
        }
    }
}
