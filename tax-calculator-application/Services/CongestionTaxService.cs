using System;
using tax_calculator_application.Interfaces;

namespace tax_calculator_application.Services
{
    public class CongestionTaxService : ICongestionTaxService
    {
        private readonly ITaxCalculatorRepository _taxCalculatorRepository;

        public CongestionTaxService(ITaxCalculatorRepository taxCalculatorRepository)
        {
            _taxCalculatorRepository = taxCalculatorRepository ?? 
                throw new ArgumentNullException(nameof(taxCalculatorRepository));
        }

        public int GetTax(string vehicle, DateTime[] dates)
        {
            return _taxCalculatorRepository.GetTax(vehicle, dates);
        }
    }
}
