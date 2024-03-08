namespace WebApplication1.Domain.RealEstateCore.Points
{
    public class Point : BasicTwinInfo
    {
        public Dictionary<string, Dictionary<string, string>> CustomProperties { get; set; }
    }
}
