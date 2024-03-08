using WebApplication1.Domain.RealEstateCore;

namespace WebApplication1.Domain.Internal
{
    public class EmissionFactor : BasicTwinInfo
    {
        public EmissionFactor(float? electricity, float? gas)
        {
            Electricity = electricity;
            Gas = gas;
        }

        public float? Electricity { get; set; }
        public float? Gas { get; set; }
    }
}