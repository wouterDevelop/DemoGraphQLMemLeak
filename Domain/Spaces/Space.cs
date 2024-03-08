using System.Text.Json.Serialization;
using WebApplication1.Domain.RealEstateCore;

namespace WebApplication1.Domain.Spaces;

public class Space : BasicTwinInfo
{
    [JsonConstructor]
    public Space(SpaceType type)
    {
        Type = type;
    }

    public Space()
    {
    }

    public string Name { get; set; }
    public virtual SpaceType Type { get; }
}