using HotChocolate;
using HotChocolate.Types;
using WebApplication1.Domain.RealEstateCore.Agents;
using WebApplication1.Domain.Spaces;
using WebApplication1.GraphQLV2.Graph.Twin.Organizations.Loaders;

namespace WebApplication1.GraphQLV2.Graph.Twin.Organizations.Extensions
{
    [ExtendObjectType(typeof(Organization))]
    public class OrganizationExtensions
    {
        /// <summary>
        /// Get Spaces (sites) by Organistions
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Space>> GetSpacesAsync([Parent] Organization organization, OrganistionSpaceBatchLoader dataLoader)
        {
            return await dataLoader.LoadAsync(organization.Id);
        }
    }
}
