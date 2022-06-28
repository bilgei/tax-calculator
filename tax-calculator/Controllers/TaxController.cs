using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using tax_calculator_application.Interfaces;
using tax_calculator.Models;

namespace tax_calculator.Controllers
{
    [Route("api/calculate")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ICongestionTaxService _congestionTaxService;

        public TaxController(ICongestionTaxService congestionTaxService)
        {
            _congestionTaxService = congestionTaxService ?? 
                throw new ArgumentNullException(nameof(congestionTaxService));
        }

        [HttpPost]
        [Route("tax")]
        public ActionResult<int> CalculateTax([FromBody] VehicleDataDto vehicleData)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dates = vehicleData.DateTimes.Select(c => DateTime.Parse(c));
            
            var tax = _congestionTaxService.GetTax(vehicleData.VehicleType.ToString(), dates.ToArray());

            return Ok(tax);
        }
    }
}

