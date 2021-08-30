﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern3
{
    public static class ManufacturerDataProvider
    {
        public List<Manufacturer> GetData() =>
           new List<Manufacturer>
           {
            new Manufacturer { City = "Italy", Name = "Alfa Romeo", Year = 2016 },
            new Manufacturer { City = "UK", Name = "Aston Martin", Year = 2018 },
            new Manufacturer { City = "USA", Name = "Dodge", Year = 2017 },
            new Manufacturer { City = "Japan", Name = "Subaru", Year = 2016 },
            new Manufacturer { City = "Germany", Name = "BMW", Year = 2015 }
           };
    }
}
