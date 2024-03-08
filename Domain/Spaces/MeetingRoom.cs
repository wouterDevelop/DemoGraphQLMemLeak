using WebApplication1.Domain.RealEstateCore.Spaces;

namespace WebApplication1.Domain.Spaces
{
    public class MeetingRoom : Architecture
    {
        public MeetingRoom() : base(SpaceType.Room)
        {
        }

        public override SpaceType Type => SpaceType.Room;
    }
}