using WebApplication1.Domain.RealEstateCore.Spaces;

namespace WebApplication1.Domain.Spaces
{
    public class Room : Architecture
    {
        public Room() : base(SpaceType.Room)
        {
        }

        public override SpaceType Type => SpaceType.Room;
    }
}