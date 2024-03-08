using WebApplication1.Domain.RealEstateCore.Spaces;

namespace WebApplication1.Domain.Spaces
{
    public class Building : Architecture
    {
        public Building() : base(SpaceType.Building)
        {
        }

        public Building(string name) : base(SpaceType.Building)
        {
            Name = name;
        }
    }
}