using HotChocolate;
using HotChocolate.Types;
using WebApplication1.Domain.RealEstateCore.Assets;
using WebApplication1.Domain.Spaces;
using WebApplication1.GraphQLV2.Graph.Twin.Spaces.Loaders;

namespace WebApplication1.GraphQLV2.Graph.Twin.Spaces.Extensions
{
    [ExtendObjectType(typeof(Space))]
    public class SpacesExtenions
    {
        /// <summary>
        /// Get Spaces in Spaces
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Space>> GetChildSpacesAsync([Parent] Space space, SpacesInSpacesBatchLoader dataLoader) => await dataLoader.LoadAsync(space.Id);

        /// <summary>
        /// Get Parents of space
        /// </summary>
        /// <param name="space"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<Space> GetParentSpaceAsync([Parent] Space space, ParentSpacesInSpacesBatchLoader dataLoader) => await dataLoader.LoadAsync(space.Id);

        /// <summary>
        /// Get Asset in space
        /// </summary>
        /// <param name="space"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Asset>> GetAssetsAsync([Parent] Space space, AssetsInSpacesBatchLoader dataLoader) => await dataLoader.LoadAsync(space.Id);
    }
}
