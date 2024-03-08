using WebApplication1.Domain.RealEstateCore.Assets;

namespace WebApplication1.GraphQLV2.Graph.Twin.Assets
{
    public class AssetsQuery
    {
        /// <summary>
        /// Get Assets
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="spaceIds"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Asset>> GetAssetsAsync(IEnumerable<string> assetIds, CancellationToken cancellationToken) => new List<Asset>();
    }
}