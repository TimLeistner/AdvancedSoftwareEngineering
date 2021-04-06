using _2_ApplicationCode;
using _3_Adapters.Interfaces;


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
