using WebApplication1.Domain.Spaces;

namespace WebApplication1.Domain.RealEstateCore.Spaces
{
    public class Architecture : Space
    {
        public Architecture(SpaceType type) : base(type)
        {
        }

        public Architecture()
        {

        }

        public float? GrossArea { get; set; } = 0;
        public float? NetArea { get; set; } = 0;
        public float? RentableArea { get; set; } = 0;
        public int? MaxOccupancy { get; set; } = 0;
        public int? SeatingCapacity { get; set; } = 0;
    }
}
