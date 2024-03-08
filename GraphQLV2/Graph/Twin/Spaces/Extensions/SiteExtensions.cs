using HotChocolate;
using HotChocolate.Types;
using WebApplication1.Domain.RealEstateCore.Agents;
using WebApplication1.Domain.Spaces;
using WebApplication1.GraphQLV2.Graph.Twin.Spaces.Loaders;

namespace WebApplication1.GraphQLV2.Graph.Twin.Spaces.Extensions
{
    [ExtendObjectType(typeof(Site))]
    public class SiteExtensions
    {
        /// <summary>
        /// Get Organization in Spaces
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<Organization> GetOrganization([Parent] Site achitecture, ParentOrganizationInSpacesLoader dataLoader) => await dataLoader.LoadAsync(achitecture.Id);
    }
}
