using WebApplication1.Domain.RealEstateCore.Assets.Equipments;

namespace WebApplication1.Domain.RealEstateCore.Assets.Equipments.ICTEquipments
{
    public class ICTEquipment : Equipment
    {
        public int HeightRUs { get; set; }
        public int NumberOfPorts { get; set; }
        public string Standard { get; set; } = "";
    }
}
