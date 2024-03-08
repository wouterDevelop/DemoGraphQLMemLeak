using WebApplication1.Domain.RealEstateCore.Points;

namespace WebApplication1.GraphQLV2.Graph.Twin.Assets.Loaders
{
    public class PointsInAssetBatchLoader : BatchDataLoader<string, List<Point>>
    {
        public PointsInAssetBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, List<Point>>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, List<Point>>();
        }
    }
}