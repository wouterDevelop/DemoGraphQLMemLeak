using System.Text.Json.Serialization;
using WebApplication1.Domain.RealEstateCore.Assets.Equipments.Meters;

namespace WebApplication1.Domain.Internal.Assets
{
    public class ChargingSocket : Meter
    {
        [JsonPropertyName("evseId")]
        public string? EvseId { get; set; }

        [JsonPropertyName("connectorId")]
        public string? ConnectorId { get; set; }
    }
}