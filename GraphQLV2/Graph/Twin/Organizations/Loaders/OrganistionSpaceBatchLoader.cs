using WebApplication1.Domain.Spaces;

namespace WebApplication1.GraphQLV2.Graph.Twin.Organizations.Loaders
{
    public class OrganistionSpaceBatchLoader : BatchDataLoader<string, List<Space>>
    {
        public OrganistionSpaceBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, List<Space>>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken) => new Dictionary<string, List<Space>>();
    }
}