using WebApplication1.Domain.RealEstateCore.Spaces;

namespace WebApplication1.Domain.Spaces
{
    public class Zone : Architecture
    {
        public Zone() : base(SpaceType.Zone)
        {
        }

        public override SpaceType Type => SpaceType.Zone;
    }
}