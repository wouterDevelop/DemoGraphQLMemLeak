using WebApplication1.Domain.RealEstateCore.Points;

namespace WebApplication1.GraphQLV2.Graph.Twin.Telemetries.Loaders.Models
{
    public class TelemetriesByPointParams
    {
        public TelemetriesByPointParams(Point point, DateTime startDate, DateTime endDate, string? timeSeriesSlice)
        {
            Point = point;
            StartDate = startDate;
            EndDate = endDate;
            TimeSeriesSlice = timeSeriesSlice;
        }

        public TelemetriesByPointParams(Point point, DateTime startDate, DateTime endDate)
        {
            Point = point;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Point Point { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? TimeSeriesSlice { get; set; }
    }
}