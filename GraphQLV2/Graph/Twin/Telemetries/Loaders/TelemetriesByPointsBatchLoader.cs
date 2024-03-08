using WebApplication1.Domain.Internal;
using WebApplication1.GraphQLV2.Graph.Twin.Telemetries.Loaders.Models;

namespace WebApplication1.GraphQLV2.Graph.Twin.Telemetries.Loaders
{
    public class TelemetriesByPointsBatchLoader : BatchDataLoader<TelemetriesByPointParams, IEnumerable<Telemetry>>
    {
        public TelemetriesByPointsBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<TelemetriesByPointParams, IEnumerable<Telemetry>>> LoadBatchAsync(IReadOnlyList<TelemetriesByPointParams> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<TelemetriesByPointParams, IEnumerable<Telemetry>>();
        }
    }
}