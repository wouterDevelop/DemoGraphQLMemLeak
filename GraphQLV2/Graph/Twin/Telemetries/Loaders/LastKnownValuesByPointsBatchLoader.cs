using WebApplication1.Domain.Internal;
using WebApplication1.Domain.RealEstateCore.Points;

namespace WebApplication1.GraphQLV2.Graph.Twin.Telemetries.Loaders
{
    public class LastKnownValuesByPointsBatchLoader : BatchDataLoader<Point, Telemetry>
    {
        public LastKnownValuesByPointsBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<Point, Telemetry>> LoadBatchAsync(IReadOnlyList<Point> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<Point, Telemetry>();
        }
    }
}