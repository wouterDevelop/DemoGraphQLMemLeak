using WebApplication1.Domain.RealEstateCore.Agents;

namespace WebApplication1.GraphQLV2.Graph.Twin.Organizations
{
    public class OrganizationsQuery
    {
        public async Task<IEnumerable<Organization>> GetOrganizations(IEnumerable<string> orgIds, CancellationToken cancellationToken)
        {
            return new List<Organization>();
        }

        public async Task<Organization> GetOrganizationAsync(CancellationToken cancellationToken)
        {
            return null;
        }
    }
}