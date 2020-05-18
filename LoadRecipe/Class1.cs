using System;
using ReloadingComponents;

namespace LoadRecipe
{
    public class Load
    {
        public Caliber Caliber { get; set; }
        public Case Case { get; set; }
        public Bullet Bullet { get; set; }
        public Powder Powder { get; set; }
        public Primer Primer { get; set; }
        public double PowderChargeGrains { get; set; }
        public double SeatingDepthOverallInches { get; set; }
        public double SeatingDepthBaseToDatumInches { get; set; }
    }
}
