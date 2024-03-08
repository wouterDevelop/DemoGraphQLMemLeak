using WebApplication1.Domain.RealEstateCore.Assets;

namespace WebApplication1.GraphQLV2.Graph.Twin.Assets.Loaders
{
    public class AssetInAssetBatchLoader : BatchDataLoader<string, List<Asset>>
    {
        public AssetInAssetBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, List<Asset>>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, List<Asset>>();
        }
    }
}