using System;
using System.Globalization;
using Equipment;
using LoadRecipe;

namespace LoadTestData
{
    public class LoadTestData
    {
        public Load Load { get; set; }
        public Firearm Firearm { get; set; }
        public Chronograph Chronograph { get; set; }
        public double TemperatureFahrenheit { get; set; }
        public double AltitudeFeet { get; set; }
        public int AverageVelocityFPS { get; set; }
    }
}
