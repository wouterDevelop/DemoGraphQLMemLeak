using WebApplication1.Domain.RealEstateCore.Spaces;

namespace WebApplication1.Domain.Spaces
{
    public class Level : Architecture
    {
        public Level() : base(SpaceType.Level)
        {
        }

        public int? LevelNumber { get; set; } = 0;
    }
}