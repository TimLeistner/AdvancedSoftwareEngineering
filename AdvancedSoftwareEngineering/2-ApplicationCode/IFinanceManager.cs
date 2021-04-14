using _2_ApplicationCode.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ApplicationCode
{
    public interface IFinanceManager
    {
        ICategoryRepository GetCategoryRepository();
    }
}
