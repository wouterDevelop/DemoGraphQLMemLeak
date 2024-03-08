using WebApplication1.Domain.RealEstateCore.Agents;

namespace WebApplication1.GraphQLV2.Graph.Twin.Spaces.Loaders
{
    public class ParentOrganizationInSpacesLoader : BatchDataLoader<string, Organization>
    {
        public ParentOrganizationInSpacesLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<string, Organization>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, Organization>();
        }
    }
}