using System;

namespace ReloadingComponents
{
    public enum PrimerSize
    {
        SmallPistol,
        SmallRifle,
        LargePistol,
        LargeRifle,
        MagnumPistol,
        MagnumRifle
    }

    public class Caliber
    {
        public double NominalDiameterInches { get; set; }
    }

    public class Case
    {
        public string Manufacturer { get; set; }
        public Caliber Caliber { get; set; }
        public PrimerSize PrimerSize { get; set; }
    }

    public class Bullet
    {
        public string Manufacturer { get; set; } 
        public string ProductLine { get; set; }
        public int BulletWeight { get; set; }
        public double NominalDiameterInches { get; set; }
        public double BallisticCoefficient { get; set; }
        public enum BallisticCoefficientModel 
        {
            G1,
            G7
        };
    }

    public class Powder
    {
        public string Manufacturer { get; set; }
        public string PowderModel { get; set; }

        public enum PowderBase
        {
            Single,
            Double
        }
    }

    public class Primer
    {
        public string Manufacturer { get; set; }
        public string PrimerModel { get; set; }
        public PrimerSize PrimerSize { get; set; }
    }
}
