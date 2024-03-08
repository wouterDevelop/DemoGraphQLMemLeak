using WebApplication1.Domain.RealEstateCore.Spaces;

namespace WebApplication1.Domain.Spaces
{
    public class Site : Architecture
    {
        public Site() : base(SpaceType.Site)
        {
        }

        public Site(string name) : base(SpaceType.Site)
        {
            Name = name;
        }
    }
}