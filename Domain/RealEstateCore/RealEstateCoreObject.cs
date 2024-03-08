using System.Text.Json.Serialization;

namespace WebApplication1.Domain.RealEstateCore
{
    public class RealEstateCoreObject
    {
        public string Name { get; set; }
        public Dictionary<string, string> Identifiers { get; set; } = new();
        public Dictionary<string, string> CustomProperties { get; set; } = new();
        public List<string> CustomTags { get; set; } = new();

        [JsonConstructor]
        public RealEstateCoreObject(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public bool HasCustomTag(string tag) => CustomTags.Contains(tag);
    }
}