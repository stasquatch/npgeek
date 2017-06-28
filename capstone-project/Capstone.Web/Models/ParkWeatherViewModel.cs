﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class ParkWeatherViewModel
    {
        public Park Park { get; set; }
        public List<Weather> Forecast { get; set; }

        public bool IsCelsius { get; set; }
    }
}