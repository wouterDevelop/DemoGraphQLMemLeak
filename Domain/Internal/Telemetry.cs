namespace WebApplication1.Domain.Internal
{
    public class Telemetry
    {
        public DateTime TimeStamp { get; set; }

        public object Value { get; set; }

        public string EntityId { get; set; }

        public string Type { get; set; }
    }
}