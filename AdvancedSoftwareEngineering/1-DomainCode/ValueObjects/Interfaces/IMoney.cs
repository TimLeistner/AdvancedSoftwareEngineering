using _1_Domain_Code.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DomainCode.ValueObjects.Interfaces
{
    public interface IMoney
    {
        double GetValue();
        Currency GetCurrency();
    }
}
