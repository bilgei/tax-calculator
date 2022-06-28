using System;

namespace tax_calculator_application.Interfaces
{
    public interface ITaxCalculatorRepository
    {
        public int GetTax(string vehicle, DateTime[] dates);

        public int GetTollFee(string vehicle, DateTime date);
    }
}
