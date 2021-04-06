using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.ValueObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DomainCode.Entities.Interfaces
{
    public interface ICategory
    {
        Guid GetGuid();
        string GetCategoryName();
        Colour GetColour();
        IMoney GetLimit();
        List<ISpending> GetSpendings();
        void AddSpending(ISpending spending);
        void RemoveSpending(ISpending spending);
        void ChangeName(string newName);
        void ChangeColour(Colour newColour);
        void ChangeLimit(IMoney newLimit);
    }
}
