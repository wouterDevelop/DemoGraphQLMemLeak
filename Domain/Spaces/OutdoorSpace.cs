namespace WebApplication1.Domain.Spaces
{
    public class OutdoorSpace : Space
    {
        public OutdoorSpace() : base(SpaceType.OutdoorSpace)
        {

        }
        public override SpaceType Type => SpaceType.OutdoorSpace;
    }
}
