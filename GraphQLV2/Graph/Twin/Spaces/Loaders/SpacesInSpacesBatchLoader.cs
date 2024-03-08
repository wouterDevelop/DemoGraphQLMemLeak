using WebApplication1.Domain.Spaces;

namespace WebApplication1.GraphQLV2.Graph.Twin.Spaces.Loaders
{
    public class SpacesInSpacesBatchLoader : BatchDataLoader<string, List<Space>>
    {
        public SpacesInSpacesBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, List<Space>>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, List<Space>>();
        }
    }
}