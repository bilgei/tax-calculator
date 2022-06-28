using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using tax_calculator_application;
using tax_calculator.Models;

namespace tax_calculator.Controllers
{
    [Route("api/calculate")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        [HttpPost]
        [Route("tax")]
        public ActionResult<int> CalculateTax([FromBody] VehicleDataDto vehicleData)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dates = vehicleData.DateTimes.Select(c => DateTime.Parse(c));

            var calculator = new CongestionTaxCalculator();
            
            var tax = calculator.GetTax(vehicleData.VehicleType.ToString(), dates.ToArray());

            return Ok(tax);
        }
    }
}

