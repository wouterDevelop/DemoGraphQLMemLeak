using WebApplication1.Domain.RealEstateCore.Agents;

namespace WebApplication1.GraphQLV2.Graph.Twin.Organizations.Loaders
{
    public class OrganizationBatchLoader : BatchDataLoader<string, Organization>
    {
        public OrganizationBatchLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler, options)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override async Task<IReadOnlyDictionary<string, Organization>> LoadBatchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            return new Dictionary<string, Organization>();
        }
    }
}