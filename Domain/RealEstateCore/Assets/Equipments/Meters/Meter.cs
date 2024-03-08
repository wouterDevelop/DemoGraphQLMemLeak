using WebApplication1.Domain.RealEstateCore.Assets.Equipments;

namespace WebApplication1.Domain.RealEstateCore.Assets.Equipments.Meters
{
    public class Meter : Equipment
    {
        public bool IsVirtualMeter { get; set; } = false;
    }
}