using System;
using ReloadingComponents;

namespace Equipment
{
    public class Firearm
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Barrel Barrel { get; set; }
    }

    public class Barrel
    { 
        public string Manufacturer { get; set; }
        public Caliber Caliber { get; set; }
        public double BarrelLength { get; set; }
        public double Twist { get; set; }
    }

    public class Chronograph
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
