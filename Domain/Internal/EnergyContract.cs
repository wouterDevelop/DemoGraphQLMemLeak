using WebApplication1.Domain.RealEstateCore;

namespace WebApplication1.Domain.Internal
{
    public class EnergyContract : BasicTwinInfo
    {
        public EnergyContract(bool dynamicContract, float? electricityPricePeakRate, float? electricityPriceOffPeakRate, float? gasPriceRate, float? powerLimit = null)
        {
            DynamicContract = dynamicContract;
            ElectricityPricePeakRate = electricityPricePeakRate;
            ElectricityPriceOffPeakRate = electricityPriceOffPeakRate;
            GasPriceRate = gasPriceRate;
            PowerLimit = powerLimit;
        }

        public bool DynamicContract { get; set; } = false;
        public float? ElectricityPricePeakRate { get; set; }
        public float? ElectricityPriceOffPeakRate { get; set; }
        public float? GasPriceRate { get; set; }
        public float? PowerLimit { get; set; }
    }
}