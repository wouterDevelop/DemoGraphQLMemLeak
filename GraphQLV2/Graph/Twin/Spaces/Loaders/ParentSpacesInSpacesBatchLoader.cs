using WebApplication1.Domain.Spaces;

namespace WebApplication1.GraphQLV2.Graph.Twin.Spaces.Loaders
{
    public class ParentSpacesInSpacesBatchLoader : BatchDataLoader<string, Space>
    {
        public ParentSpacesInSpacesBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, Space>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, Space>();
        }
    }
}