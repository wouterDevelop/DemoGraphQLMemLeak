using WebApplication1.Domain.Spaces;

namespace WebApplication1.Domain.RealEstateCore.Agents
{
    public class Organization : Agent
    {
        public Organization()
        {
        }

        public Organization(string name, string? logo)
        {
            Name = name;
            Logo = logo;
        }

        public SpaceType Type => SpaceType.Organization;
        public string? Logo { get; set; } = "";
    }
}
