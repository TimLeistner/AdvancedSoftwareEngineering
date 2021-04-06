
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.ValueObjects.Interfaces;
using System;

namespace _1_DomainCode.Entities.Interfaces
{
    public interface ISpending
    {
        void ChangeDescription(string description);
        IMoney GetSpendMoney();
        DateTime GetDate();
        string GetDescription();
    }
}
