using WebApplication1.Domain.Internal;
using WebApplication1.Domain.RealEstateCore.Points;
using WebApplication1.GraphQLV2.Graph.Twin.Telemetries.Loaders;
using WebApplication1.GraphQLV2.Graph.Twin.Telemetries.Loaders.Models;

namespace WebApplication1.GraphQLV2.Graph.Twin.Points.Loaders
{
    [ExtendObjectType(typeof(Point))]
    public class PointExtensions
    {
        /// <summary>
        /// Get last known value of point
        /// </summary>
        /// <param name="point"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<Telemetry?> GetLastKnownValueAsync([Parent] Point point, LastKnownValuesByPointsBatchLoader dataLoader) => await dataLoader.LoadAsync(point);

        /// <summary>
        /// Extension of Telemetry data
        /// </summary>
        /// <param name="point"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="slice"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>

        public async Task<IEnumerable<Telemetry>?> GetTimeSerieAsync([Parent] Point point, DateTime? startDate, DateTime? endDate, string? slice, TelemetriesByPointsBatchLoader dataLoader) => await dataLoader.LoadAsync(new TelemetriesByPointParams(point, startDate.Value, endDate.Value, slice));
    }
}