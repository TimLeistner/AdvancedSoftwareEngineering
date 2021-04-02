using _2_ApplicationCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Adapters
{
    public class AdapterManager
    {
        private FinanceManager financeManager;
        private CategoryAdapter categoryAdapter;

        public AdapterManager()
        {
            financeManager = new FinanceManager();
            categoryAdapter = new CategoryAdapter(financeManager);
        }

        public CategoryAdapter GetCategoryAdapter()
        {
            return categoryAdapter;
        }
    }
}
