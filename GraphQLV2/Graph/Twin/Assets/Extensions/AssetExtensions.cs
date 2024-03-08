using WebApplication1.Domain.RealEstateCore.Assets;
using WebApplication1.Domain.RealEstateCore.Points;
using WebApplication1.Domain.Spaces;
using WebApplication1.GraphQLV2.Graph.Twin.Assets.Loaders;

namespace WebApplication1.GraphQLV2.Graph.Twin.Assets.Extensions
{
    [ExtendObjectType(typeof(Asset))]
    public class AssetExtensions
    {
        ///// <summary>
        ///// Get Points in space
        ///// </summary>
        ///// <param name="space"></param>
        ///// <param name="dataLoader"></param>
        ///// <returns></returns>
        public async Task<IEnumerable<Point>> GetPointsAsync([Parent] Asset asset, PointsInAssetBatchLoader dataLoader) => await dataLoader.LoadAsync(asset.Id);

        /// <summary>
        /// Get child assets by asset
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Asset>> GetChildAssetsAsync([Parent] Asset asset, AssetInAssetBatchLoader dataLoader) => await dataLoader.LoadAsync(asset.Id);

        /// <summary>
        /// Get parent space by asset
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="dataLoader"></param>
        /// <returns></returns>
        public async Task<Space> GetParentSpaceAsync([Parent] Asset asset, ParentSpacesInAssetBatchLoader dataLoader) => await dataLoader.LoadAsync(asset.Id);
    }
}