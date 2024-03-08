using System.Text.Json.Serialization;
using WebApplication1.Domain.RealEstateCore.Assets.Equipments.Meters;

namespace WebApplication1.Domain.Internal.Assets
{
    public class ChargingPole : Meter
    {
        [JsonPropertyName("chargingStationId")]
        public string? ChargingStationId { get; set; }

        [JsonPropertyName("ocppIdentity")]
        public string? OcppIdentity { get; set; }
    }
}