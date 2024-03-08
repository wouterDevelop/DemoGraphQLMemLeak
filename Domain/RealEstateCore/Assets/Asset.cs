namespace WebApplication1.Domain.RealEstateCore.Assets
{
    public class Asset : BasicTwinInfo
    {
        public string? AssetTag { get; set; } = "";
        public DateTime? CommissioningDate { get; set; } = DateTime.UtcNow;
        public string? InitialCost { get; set; } = "";
        public DateTime? InstallationDate { get; set; } = DateTime.UtcNow;
        public string? IpAddress { get; set; } = "";
        public string? MacAddress { get; set; } = "";
        public TimeSpan? MaintenanceInterval { get; set; } = TimeSpan.Zero;
        public string? ModelNumber { get; set; } = "";
        public string? Name { get; set; } = "";
        public string? SerialNumber { get; set; } = "";
        public DateTime? TurnoverDate { get; set; } = DateTime.UtcNow;
        public string? Weight { get; set; } = "";
        public string Type => GetType().Name;
        public Dictionary<string, Dictionary<string, string>> CustomProperties { get; set; }
    }
}
