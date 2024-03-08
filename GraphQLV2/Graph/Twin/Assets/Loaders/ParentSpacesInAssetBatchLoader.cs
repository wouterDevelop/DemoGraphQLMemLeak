using WebApplication1.Domain.Spaces;

namespace WebApplication1.GraphQLV2.Graph.Twin.Assets.Loaders
{
    public class ParentSpacesInAssetBatchLoader : BatchDataLoader<string, Space>
    {
        public ParentSpacesInAssetBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, Space>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, Space>();
        }
    }
}