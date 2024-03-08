namespace WebApplication1.Domain.RealEstateCore.Agents
{
    public class Agent : BasicTwinInfo
    {
        public IDictionary<string, IDictionary<string, string>>? CustomProperties { get; set; }
        public IDictionary<string, bool>? CustomTags { get; set; }
        public IDictionary<string, string>? Identifiers { get; set; }
        public string? Name { get; set; } = "";
    }
}
