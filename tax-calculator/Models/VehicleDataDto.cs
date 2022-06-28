using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tax_calculator.Models
{
    public class VehicleDataDto
    {
        [Required] 
        public string VehicleType { get; set; }

        [Required] 
        public IList<string> DateTimes { get; set; }
    }
}
