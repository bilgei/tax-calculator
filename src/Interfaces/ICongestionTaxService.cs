using System;

namespace tax_calculator_application.Interfaces
{
    public interface ICongestionTaxService
    {
        public int GetTax(string vehicle, DateTime[] dates);
    }
}
