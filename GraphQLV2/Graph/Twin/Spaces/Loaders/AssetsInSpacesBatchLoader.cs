using WebApplication1.Domain.RealEstateCore.Assets;

namespace WebApplication1.GraphQLV2.Graph.Twin.Spaces.Loaders
{
    public class AssetsInSpacesBatchLoader : BatchDataLoader<string, List<Asset>>
    {
        public AssetsInSpacesBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, List<Asset>>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, List<Asset>>();
        }
    }
}